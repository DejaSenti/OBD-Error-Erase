using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.Maps;
using OBDErrorErase.EditorSource.ProfileManagement;
using OBDErrorErase.EditorSource.Utils;
using System;
using System.CodeDom;
using static OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors.BoschProfileEditorController;

namespace OBDErrorErase.EditorSource.Processors
{
    [Serializable]
    internal class BoschErrorProcessor : BaseErrorProcessor
    {
        private BoschLengthAlgorithm lengthAlgorithm;
        public BoschLengthAlgorithm LengthAlgorithm { get => lengthAlgorithm; set { lengthAlgorithm = value; isDirty = true; } }

        public override void PopulateProfileDefaults(Profile profile)
        {
            profile.Subprofiles.Add(new SubprofileData());
            profile.AddNewMap(new MapBosch(MapBosch.DTC, "0000", "16"));
            lengthAlgorithm = BoschLengthAlgorithm.MANUAL;
        }

        public override int Process(BinaryFile file, SubprofileData subprofile, List<string> errors, List<int> mapIndices)
        {
            int totalErased = 0;
            var mapsToProcess = subprofile.Maps.GetElementsAtIndexes(mapIndices);

            if (mapsToProcess.Count == 0)
                return 0;

            MapBosch dtcMap = (MapBosch)subprofile.Maps[0];

            int dtcValueSize = dtcMap.NewValue.Count;
            var dtcLocation = dtcMap.Location;

            switch (lengthAlgorithm)
            {
                case BoschLengthAlgorithm.BMW:
                    int maskLocation = subprofile.GetMapLocation(MapBosch.MASK);

                    if (dtcLocation == -1 || maskLocation == -1)
                    {
                        return 0;
                    }

                    var length = Math.Abs(maskLocation - dtcLocation);

                    subprofile.MapLength = length;
                    break;
                case BoschLengthAlgorithm.MANUAL:
                default:
                    break;
            }

            var dtcEnd = dtcLocation + (subprofile.MapLength + 1) * dtcValueSize;

            foreach(var error in errors)
            {
                List<int> errorLocations = new();
                byte[] byteError = Convert.FromHexString(error);
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
                        continue;
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