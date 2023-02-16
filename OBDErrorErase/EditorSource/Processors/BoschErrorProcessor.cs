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
            profile.Subprofiles[0].Maps.Add(new MapBosch("DTC", "0000"));
        }

        public int Process(BinaryFile file, SubprofileData subprofile, List<string> errors)
        {
            int totalErased = 0;

            Dictionary<BaseProfileMap, uint> locationByMap = new();

            foreach (var map in subprofile.Maps)
            {
                uint location = file.FindValue(map.SearchWord, 0, file.Length);
                locationByMap[map] = location;
            }

            foreach(var error in errors)
            {
                uint location = 0;
                byte[] byteError = Convert.FromHexString(error);

                do
                {
                    location = file.FindValue(byteError, locationByMap[subprofile.Maps[0]], locationByMap[subprofile.Maps[0]] + subprofile.MapLength);
                } while (location != uint.MaxValue && location % 2 != 0);
                
                if (location == uint.MaxValue)
                    continue;

                uint offset = location - locationByMap[subprofile.Maps[0]];
                
                foreach(MapBosch map in subprofile.Maps)
                {
                    var valueOffset = offset * (uint)(map.NewValue.Count / ((MapBosch)subprofile.Maps[0]).NewValue.Count);
                    file.WriteValue(locationByMap[map] + valueOffset, map.NewValue.ToArray());
                }

                ++totalErased;
            }

            return totalErased;
        }
    }
}