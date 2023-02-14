using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.Maps;
using OBDErrorErase.EditorSource.ProfileManagement;
using System.Text.Json.Serialization;

namespace OBDErrorErase.EditorSource.Processors
{
    public abstract class BaseErrorProcessor
    {
        public SubprofileData CurrentSubprofile { get; private set; }

        public abstract void PopulateProfileDefaults(Profile profile);

        public void SetSubprofile(SubprofileData subprofile)
        {
            CurrentSubprofile = subprofile;
        }

        public abstract void Process(BinaryFile file, List<string> errors);
    }
}