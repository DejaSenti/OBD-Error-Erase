using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.Maps;
using OBDErrorErase.EditorSource.ProfileManagement;

namespace OBDErrorErase.EditorSource.Processors
{
    internal class DelphiErrorProcessor : IErrorProcessor
    {
        public void PopulateProfileDefaults(Profile profile)
        {
            profile.Subprofiles.Add(new SubprofileData());
            profile.Subprofiles[0].Maps.Add(new MapDelphi("Delphi"));
        }

        public int Process(BinaryFile file, SubprofileData subprofile, List<string> errors, List<int> mapIndices)
        {
            if (subprofile.Maps.FirstOrDefault() is not MapDelphi map)
            {
                return 0;
            }

            int start = file.FindValue(map.SearchWord, 0, file.Length);

            if (start == -1)
                return 0;
            
            int mapEnd = start + (subprofile.MapLength + 1) * map.NewValue.Count;

            int totalErased = 0;

            foreach (var error in errors)
            {
                List<int> errorLocations = new();

                byte[] byteError = Convert.FromHexString(error);

                int seeker = start;
                do
                {
                    seeker = file.FindValue(byteError, seeker, mapEnd);

                    if (seeker == -1)
                        break;

                    if (((seeker - start) % map.NewValue.Count) == map.ErrorColumn)
                    {
                        errorLocations.Add(seeker - map.ErrorColumn);
                        seeker += map.NewValue.Count;
                        continue;
                    }

                    seeker += map.NewValue.Count;
                    seeker -= seeker % map.NewValue.Count;
                } while (seeker != -1);

                if (errorLocations.Count == 0)
                    continue;

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