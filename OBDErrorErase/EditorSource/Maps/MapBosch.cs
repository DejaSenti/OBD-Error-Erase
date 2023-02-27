using OBDErrorErase.EditorSource.ProfileManagement;
using System.Text.Json.Serialization;

namespace OBDErrorErase.EditorSource.Maps
{
    [Serializable]
    public class MapBosch : BaseProfileMap
    {
        public const string ERROR_LIST = "DTC";

        [JsonIgnore]
        public override bool IsDirty => base.IsDirty || NewValue.IsDirty;

        private DirtyList<byte> newValue = new();
        public DirtyList<byte> NewValue { get => newValue; set { newValue = value; isDirty = true; } }

        public MapBosch() { }

        public MapBosch(string name, string newValue) : base(name)
        {
            NewValue = new DirtyList<byte>(Convert.FromHexString(newValue));
        }
    }
}