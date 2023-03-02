using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.ProfileManagement;

namespace OBDErrorErase.EditorSource.Processors
{
    internal class DelphiErrorProcessor : IErrorProcessor
    {
        public void PopulateProfileDefaults(Profile profile)
        {
            //throw new NotImplementedException();
        }

        public int Process(BinaryFile file, SubprofileData subprofile, List<string> errors, List<int> mapIndices)
        {
            MapDelphi? map = subprofile.Maps.FirstOrDefault() as MapDelphi;

            if (map == null)
            {
                return 0;
            }

            // write new value
            int start = file.FindValue(map.SearchWord, 0, file.Length);

            int totalErased = 0;
            // for each error
            foreach (var error in errors)
            {
                // find location, round down according to column number
                byte[] byteError = Convert.FromHexString(error);
                var location = file.FindValue(byteError, start, start + subprofile.MapLength);
                
                if (location == -1)
                    continue;

                location -= map.ErrorColumn - 1;

                file.WriteValue(location, map.NewValue.ToArray());
                ++totalErased;
            }

            return totalErased;
        }
    }
}