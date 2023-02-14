using OBDErrorErase.EditorSource.FileManagement;
using System.Text.Json.Serialization;

namespace OBDErrorErase.EditorSource.Maps
{
    [Serializable]
    public abstract class BaseProfileMap
    {
        public List<string> SearchWords { get; set; } = new();
        public string Name { get; set; }
        public int Location { get; internal set; }

        public BaseProfileMap(string name, int location)
        {
            Name = name;
            Location = location;
        }
    }
}