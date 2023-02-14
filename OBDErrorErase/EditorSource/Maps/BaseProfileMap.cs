using OBDErrorErase.EditorSource.FileManagement;
using System.Text.Json.Serialization;

namespace OBDErrorErase.EditorSource.Maps
{
    [Serializable]
    public abstract class BaseProfileMap
    {
        public List<string> SearchWords { get; set; }
        public string Name { get; set; }
    }
}