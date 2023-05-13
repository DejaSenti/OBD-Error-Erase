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
        protected bool isDirty;
        [JsonIgnore]
        public virtual bool IsDirty => isDirty;

        public abstract void PopulateProfileDefaults(Profile profile);

        public abstract int Process(BinaryFile file, SubprofileData subprofile, List<string> errors, List<int> mapIndices);
    }
}