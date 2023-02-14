using System.Text.Json.Serialization;

namespace OBDErrorErase.EditorSource.Maps
{
    [JsonDerivedType(typeof(MapBosch), "Bosch")]
    [JsonDerivedType(typeof(MapDelphi), "Delphi")]
    [Serializable]
    public abstract class BaseProfileMap
    {
        public List<string> SearchWords { get; set; } = new();
        public string Name { get; set; }
        public uint Location { get; internal set; }

        public BaseProfileMap(string name, uint location)
        {
            Name = name;
            Location = location;
        }
    }
}