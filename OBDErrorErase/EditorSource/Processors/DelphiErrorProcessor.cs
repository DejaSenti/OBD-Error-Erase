using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.ProfileManagement;

namespace OBDErrorErase.EditorSource.Processors
{
    [Serializable]
    internal class DelphiErrorProcessor : BaseErrorProcessor
    {
        public override void PopulateProfileDefaults(Profile profile)
        {
            throw new NotImplementedException();
        }

        public override int Process(BinaryFile file, SubprofileData subprofile, List<string> errors)
        {
            throw new NotImplementedException();
        }
    }
}