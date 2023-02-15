using OBDErrorErase.EditorSource.FileManagement;
using System.Text.Json.Serialization;

namespace OBDErrorErase.EditorSource.Maps
{
    [JsonDerivedType(typeof(MapBosch), "Bosch")]
    [JsonDerivedType(typeof(MapDelphi), "Delphi")]
    [Serializable]
    public abstract class BaseProfileMap
    {
        const uint SEARCH_WORD_LENGTH = 50;

        public byte[] SearchWord { get; private set; }
        public string Name { get; set; }
        public uint Location { get; internal set; }

        public BaseProfileMap(string name, uint location)
        {
            Name = name;
            Location = location;
        }

        public void SetSearchWord(BinaryFile file)
        {
            if (file != null)
            {
                SearchWord = file.ReadValue(Location, SEARCH_WORD_LENGTH);
            }
        }
    }
}