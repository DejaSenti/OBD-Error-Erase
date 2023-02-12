using OBDErrorErase.EditorSource.FileManagement;
using System.Text.Json.Serialization;

namespace OBDErrorErase.EditorSource.Maps
{
    [JsonDerivedType(typeof(MapBosch), "Bosch")]
    [JsonDerivedType(typeof(MapDelphi), "Delphi")]
    [Serializable]
    public abstract class BaseProfileMap
    {
        public string SearchWord { get; set; }
        public string Name { get; set; }

        protected abstract void Process(BinaryFile file, string error);
    }
}