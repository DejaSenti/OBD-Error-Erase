using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.Maps;
using OBDErrorErase.EditorSource.ProfileManagement;

namespace OBDErrorErase.EditorSource.Processors
{
    internal class DelphiErrorProcessor : IErrorProcessor
    {
        public void PopulateProfileDefaults(Profile profile)
        {
            profile.Manufacturer = "None";
            profile.Name = "None";
            profile.Subprofiles.Add(new SubprofileData());
            profile.Subprofiles[0].Maps.Add(new MapDelphi());
        }

        public int Process(BinaryFile file, SubprofileData subprofile, List<string> errors, List<int> mapIndices)
        {
            MapDelphi? map = subprofile.Maps.FirstOrDefault() as MapDelphi;

            if (map == null)
            {
                return 0;
            }

            int start = file.FindValue(map.SearchWord, 0, file.Length);

            if (start == -1)
                return 0;
            
            int mapEnd = start + subprofile.MapLength;

            int totalErased = 0;

            foreach (var error in errors)
            {
                List<int> errorLocations = new();

                byte[] byteError = Convert.FromHexString(error);

                int seeker = start;
                do
                {
                    seeker = file.FindValue(byteError, seeker, mapEnd);

                    if ((seeker != -1) && (((seeker - start) % map.NewValue.Count) == map.ErrorColumn))
                    {
                        errorLocations.Add(seeker - map.ErrorColumn);
                        seeker += map.NewValue.Count;
                    }
                } while (seeker != -1);

                foreach (var location in errorLocations)
                {
                    file.WriteValue(location, map.NewValue.ToArray());
                }

                ++totalErased;
            }

            return totalErased;
        }
    }
}