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
    }
}