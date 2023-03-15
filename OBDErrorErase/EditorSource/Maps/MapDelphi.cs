using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.ProfileManagement;
using System.Text.Json.Serialization;

namespace OBDErrorErase.EditorSource.Maps
{
    [Serializable]
    public class MapDelphi : BaseProfileMap
    {
        [JsonIgnore]
        public override bool IsDirty => base.IsDirty || NewValue.IsDirty;

        private DirtyList<byte> newValue = new();
        public DirtyList<byte> NewValue { get => newValue; set { newValue = value; isDirty = true; } }

        private int rawLocation;
        public int RawLocation { get => rawLocation; set { rawLocation = value; isDirty = true; } }

        private int errorColumn;
        public int ErrorColumn { get => errorColumn; set { errorColumn = value; isDirty = true; } }

        public MapDelphi(string name) : base(name)
        {
        }

        public override byte[] GetErrorList(BinaryFile file, int displayLocation)
        {
            byte[] errors = new byte[PREVIEW_LENGTH * 2];

            for (int i = 0; i < PREVIEW_LENGTH; ++i)
            {
                byte[] value = file.ReadValue(displayLocation + i * newValue.Count, newValue.Count);

                (errors[i * 2], errors[i * 2 + 1]) = (value[errorColumn], value[errorColumn + 1]);
            }

            return errors;
        }
    }
}