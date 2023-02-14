using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.Maps;
using OBDErrorErase.EditorSource.ProfileManagement;

namespace OBDErrorErase.EditorSource.Processors
{
    [Serializable]
    internal class BoschErrorProcessor : BaseErrorProcessor
    {
        public override void PopulateProfileDefaults(Profile profile)
        {
            profile.Manufacturer = "None";
            profile.Name = "None";
            profile.Subprofiles.Add(new SubprofileData());
            profile.Subprofiles[0].Maps.Add(new MapBosch("DTC", "00", 0));
        }

        public override BinaryFile Process(BinaryFile file, SubprofileData subprofile, List<string> errors, out int totalErased)
        {
            totalErased = 0;

            foreach(var error in errors)
            {
                int location = file.FindValue(error);

                if (location < 0)
                    continue;

                int offset = location - subprofile.Maps[0].Location;
                
                foreach(MapBosch map in subprofile.Maps)
                {
                    file.WriteValue(map.Location + offset, map.NewValue);
                }

                ++totalErased;
            }

            return file;
        }
    }
}