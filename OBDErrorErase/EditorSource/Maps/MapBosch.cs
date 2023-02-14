using OBDErrorErase.EditorSource.FileManagement;

namespace OBDErrorErase.EditorSource.Maps
{
    [Serializable]
    public class MapBosch : BaseProfileMap
    {
        public byte[] NewValue { get; set; }

        public MapBosch(string name, string newValue, uint location) : base(name, location)
        {
            NewValue = Convert.FromHexString(newValue);
        }
    }
}