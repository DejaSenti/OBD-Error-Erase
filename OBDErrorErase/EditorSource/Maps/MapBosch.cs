using OBDErrorErase.EditorSource.ProfileManagement;

namespace OBDErrorErase.EditorSource.Maps
{
    [Serializable]
    public class MapBosch : BaseProfileMap
    {
        private DirtyList<byte> newValue;
        public DirtyList<byte> NewValue { get => newValue; set { newValue = value; isDirty = true; } }

        public override bool IsDirty => base.IsDirty || NewValue .IsDirty;
		
        public MapBosch(string name, string newValue) : base(name)
        {
            NewValue = new DirtyList<byte>(Convert.FromHexString(newValue)); // fix this
        }
    }
}