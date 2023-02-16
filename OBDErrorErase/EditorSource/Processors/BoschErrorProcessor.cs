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

            Dictionary<BaseProfileMap, int> locationByMap = new();

            foreach (var map in subprofile.Maps)
            {
                int location = file.FindValue(map.SearchWord, 0, file.Length);
                locationByMap[map] = location;
            }

            foreach(var error in errors)
            {
                int errorLocation = 0;
                byte[] byteError = Convert.FromHexString(error);

                MapBosch dtcMap = (MapBosch)subprofile.Maps[0];
                var dtcLocation = locationByMap[dtcMap];
                do
                {
                    errorLocation = file.FindValue(byteError, dtcLocation, dtcLocation + subprofile.MapLength);
                } while (errorLocation != -1 && errorLocation % 2 != 0);
                
                if (errorLocation == -1)
                    continue;

                int errorIndex = (errorLocation - dtcLocation) / dtcMap.NewValue.Count;
                
                foreach(MapBosch map in subprofile.Maps)
                {
                    var valueLocation = locationByMap[map] + errorIndex * map.NewValue.Count;
                    file.WriteValue(valueLocation, map.NewValue.ToArray());
                }

                ++totalErased;
            }

            return totalErased;
        }
    }
}