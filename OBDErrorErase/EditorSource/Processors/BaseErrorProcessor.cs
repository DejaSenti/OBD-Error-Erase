using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.Maps;
using OBDErrorErase.EditorSource.ProfileManagement;
using System.Text.Json.Serialization;

namespace OBDErrorErase.EditorSource.Processors
{
    public interface IErrorProcessor
    {
        public void PopulateProfileDefaults(Profile profile);

        public int Process(BinaryFile file, SubprofileData subprofile, List<string> errors);
    }
}