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

        private int rawLocation;
        public int RawLocation { get => rawLocation; set { rawLocation = value; isDirty = true; } }

        private int errorColumn;
        public int ErrorColumn { get => errorColumn; set { errorColumn = value; isDirty = true; } }

        public MapDelphi(string name) : base(name)
        {
        }

        public override byte[][] GetErrorList(BinaryFile file, int displayLocation)
        {
            byte[][] errors = new byte[PREVIEW_LENGTH][];

            for (int i = 0; i < PREVIEW_LENGTH; ++i)
            {
                byte[] value = file.ReadValue(displayLocation + i * NewValue.Count, NewValue.Count);

                errors[i] = value[errorColumn..(errorColumn+ERROR_VALUE_LEN)];
            }

            return errors;
        }
    }
}