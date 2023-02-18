using System.Text.Json.Serialization;

namespace OBDErrorErase.EditorSource.ProfileManagement
{
    public interface IDirty
    {
        [JsonIgnore]
        bool IsDirty { get; }
        void ClearDirty(bool deep = true);
    }
}