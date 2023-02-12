using OBDErrorErase.EditorSource.FileManagement;
using System.Text.Json.Serialization;

namespace OBDErrorErase.EditorSource.Maps
{
    [JsonDerivedType(typeof(MapBosch), "Bosch")]
    [JsonDerivedType(typeof(MapDelphi), "Delphi")]
    [Serializable]
    public abstract class BaseProfileMap
    {
        public List<string> SearchWords { get; set; }
        public string Name { get; set; }

        public abstract void Process(BinaryFile file, string error);
    }
}