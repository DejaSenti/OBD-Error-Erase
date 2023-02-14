using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.Maps;
using OBDErrorErase.EditorSource.ProfileManagement;
using System.Text.Json.Serialization;

namespace OBDErrorErase.EditorSource.Processors
{
    [JsonDerivedType(typeof(BoschErrorProcessor), "Bosch")]
    [JsonDerivedType(typeof(DelphiErrorProcessor), "Delphi")]
    [Serializable]
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