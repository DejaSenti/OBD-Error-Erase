using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.ProfileManagement;
using System.Text.Json.Serialization;

namespace OBDErrorErase.EditorSource.Maps
{
    [Serializable]
    public class MapBosch : BaseProfileMap
    {
        public const string DTC = "DTC";
        public const string CLASS = "class";

        [JsonIgnore]
        public override bool IsDirty => base.IsDirty || NewValue.IsDirty;

        private DirtyList<byte> newValue = new();
        public DirtyList<byte> NewValue { get => newValue; set { newValue = value; isDirty = true; } }

        private int rawLocation;
        public int RawLocation { get => rawLocation; set { rawLocation = value; isDirty = true; } }

        private int rawWidth;
        public int RawWidth { get => rawWidth; set { rawWidth = value; isDirty = true; } }

        public MapBosch() { }

        public MapBosch(string name, string newValue, int rawWidth) : base(name)
        {
            if (newValue.Length % 2 != 0)
                newValue = newValue.PadLeft(newValue.Length + 1, '0');

            NewValue = new DirtyList<byte>(Convert.FromHexString(newValue));
            RawWidth = rawWidth;
        }

        public override byte[] GetErrorList(BinaryFile file, int displayLocation)
        {
            return file.ReadValue(displayLocation, PREVIEW_LENGTH);
        }
    }
}