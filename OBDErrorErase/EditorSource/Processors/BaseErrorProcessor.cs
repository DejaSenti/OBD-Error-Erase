using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.ProfileManagement;

namespace OBDErrorErase.EditorSource.Processors
{
    public interface IErrorProcessor
    {
        public void PopulateProfileDefaults(Profile profile);

        public int Process(BinaryFile file, SubprofileData subprofile, List<string> errors, List<int> mapIndices);
    }
}