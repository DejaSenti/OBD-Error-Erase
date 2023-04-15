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
        public const string MASK = "mask";

        [JsonIgnore]
        public override bool IsDirty => base.IsDirty || NewValue.IsDirty;

        private int rawLocation;
        public int RawLocation { get => rawLocation; set { rawLocation = value; isDirty = true; } }

        private string rawWidth;
        public string RawWidth { get => rawWidth; set { rawWidth = value; isDirty = true; } }

        public MapBosch() { }

        public MapBosch(string name, string newValue, string rawWidth) : base(name)
        {
            if (newValue.Length % 2 != 0)
                newValue = newValue.PadLeft(newValue.Length + 1, '0');

            NewValue = new DirtyList<byte>(Convert.FromHexString(newValue));
            RawWidth = rawWidth;
        }

        public override byte[][] GetErrorList(BinaryFile file, int displayLocation)
        {
            byte[][] result = new byte[PREVIEW_LENGTH][];

            for (int i = 0; i < result.Length; ++i)
            {
                result[i] = file.ReadValue(displayLocation + i * ERROR_VALUE_LEN, ERROR_VALUE_LEN);
            }

            return result;
        }
    }
}