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
            profile.AddNewMap(new MapBosch(MapBosch.DTC, "0000", "16"));
        }

        public int Process(BinaryFile file, SubprofileData subprofile, List<string> errors, List<int> mapIndices)
        {
            int totalErased = 0;
            var mapsToProcess = subprofile.Maps.GetElementsAtIndexes(mapIndices);

            if (mapsToProcess.Count == 0)
                return 0;

            foreach(var error in errors)
            {
                List<int> errorLocations = new();
                byte[] byteError = Convert.FromHexString(error);

                MapBosch dtcMap = (MapBosch)subprofile.Maps[0];

                int dtcValueSize = dtcMap.NewValue.Count;
                var dtcLocation = dtcMap.Location;
                var dtcEnd = dtcLocation + (subprofile.MapLength + 1) * dtcValueSize;
                int seeker = dtcLocation;
                do
                {
                    seeker = file.FindValue(byteError, seeker, dtcEnd);

                    if (seeker == -1)
                        break;

                    if(seeker % dtcValueSize == 0)
                    {
                        errorLocations.Add(seeker);
                        seeker += dtcValueSize;
                    }

                    seeker += dtcValueSize / 2;
                } while (seeker != -1);
                
                if (errorLocations.Count == 0)
                    continue;

                foreach (var errorLocation in errorLocations)
                {
                    int errorIndex = (errorLocation - dtcLocation) / dtcValueSize;
                
                    foreach(MapBosch map in mapsToProcess.Cast<MapBosch>())
                    {
                        var valueLocation = map.Location + errorIndex * map.NewValue.Count;
                        file.WriteValue(valueLocation, map.NewValue.ToArray());
                    }
                }

                ++totalErased;
            }

            return totalErased;
        }
    }
}