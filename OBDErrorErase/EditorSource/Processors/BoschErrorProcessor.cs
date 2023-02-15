using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.Maps;
using OBDErrorErase.EditorSource.ProfileManagement;

namespace OBDErrorErase.EditorSource.Processors
{
    internal class BoschErrorProcessor : IErrorProcessor
    {
        public void PopulateProfileDefaults(Profile profile)
        {
            profile.Manufacturer = "None";
            profile.Name = "None";
            profile.Subprofiles.Add(new SubprofileData());
            profile.Subprofiles[0].Maps.Add(new MapBosch("DTC", "00", 0));
        }

        public int Process(BinaryFile file, SubprofileData subprofile, List<string> errors)
        {
            int totalErased = 0;

            foreach(var error in errors)
            {
                uint location = 0;
                byte[] byteError = Convert.FromHexString(error);

                do
                {
                    location = file.FindValue(byteError, subprofile.Maps[0].Location, subprofile.Maps[0].Location + subprofile.MapLength);
                } while (location != uint.MaxValue && location % 2 != 0);
                
                if (location == uint.MaxValue)
                    continue;

                uint offset = location - subprofile.Maps[0].Location;
                
                foreach(MapBosch map in subprofile.Maps)
                {
                    file.WriteValue(map.Location + offset, map.NewValue.ToArray());
                }

                ++totalErased;
            }

            return totalErased;
        }
    }
}