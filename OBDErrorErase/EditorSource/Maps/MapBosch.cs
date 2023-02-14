using OBDErrorErase.EditorSource.FileManagement;

namespace OBDErrorErase.EditorSource.Maps
{
    [Serializable]
    public class MapBosch : BaseProfileMap
    {
        public string NewValue { get; set; }

        public MapBosch(string name, string newValue, int location) : base(name, location)
        {
            NewValue = newValue;
        }
    }
}