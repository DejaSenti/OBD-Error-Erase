using OBDErrorErase.EditorSource.Configs;
using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.Maps;
using OBDErrorErase.EditorSource.ProfileManagement;
using OBDErrorErase.EditorSource.Utils;

namespace OBDErrorErase.EditorSource.Processors
{
    internal class BoschErrorProcessor : IErrorProcessor
    {
        public void PopulateProfileDefaults(Profile profile)
        {
            profile.Subprofiles.Add(new SubprofileData());
            profile.AddNewMap(new MapBosch(MapBosch.DTC, "0000", ValueWidth.WIDTH.IndexOf("16bit")));
        }

        public int Process(BinaryFile file, SubprofileData subprofile, List<string> errors, List<int> mapIndices)
        {
            int totalErased = 0;
            var mapsToProcess = subprofile.Maps.GetElementsAtIndexes(mapIndices);

            if (mapsToProcess.Count == 0)
                return 0;

            Dictionary<BaseProfileMap, int> locationByMap = new();

            foreach (var map in mapsToProcess)
            {
                int location = file.FindValue(map.SearchWord, 0, file.Length);
                locationByMap[map] = location;
            }

            foreach(var error in errors)
            {
                List<int> errorLocations = new();
                byte[] byteError = Convert.FromHexString(error);

                MapBosch dtcMap = (MapBosch)subprofile.Maps[0];

                var dtcLocation = locationByMap[dtcMap];
                var dtcEnd = dtcLocation + subprofile.MapLength;
                int seeker = dtcLocation;
                int dtcValueSize = dtcMap.NewValue.Count;
                do
                {
                    seeker = file.FindValue(byteError, seeker, dtcEnd);

                    if((seeker != -1) && ((seeker % dtcValueSize) == 0))
                    {
                        errorLocations.Add(seeker);
                        seeker += dtcValueSize;
                    }
                } while (seeker != -1);
                
                if (errorLocations.Count == 0)
                    continue;

                foreach (var errorLocation in errorLocations)
                {
                    int errorIndex = (errorLocation - dtcLocation) / dtcValueSize;
                
                    foreach(MapBosch map in subprofile.Maps.Cast<MapBosch>())
                    {
                        var valueLocation = locationByMap[map] + errorIndex * map.NewValue.Count;
                        file.WriteValue(valueLocation, map.NewValue.ToArray());
                    }
                }

                ++totalErased;
            }

            return totalErased;
        }
    }
}