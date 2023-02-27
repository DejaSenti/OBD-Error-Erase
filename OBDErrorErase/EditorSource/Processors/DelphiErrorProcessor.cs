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
            throw new NotImplementedException();
        }
    }
}