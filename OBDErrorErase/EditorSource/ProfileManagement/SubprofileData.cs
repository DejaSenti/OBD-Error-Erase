using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.Maps;

namespace OBDErrorErase.EditorSource.ProfileManagement
{
    [Serializable]
    public class SubprofileData : IDirty
    {
        protected bool isDirty;
        public bool IsDirty => isDirty || Maps.IsDirty || Maps.Any(map => map.IsDirty);

        private uint mapLength;
        public uint MapLength { get => mapLength; set { mapLength = value; isDirty = true; } }

        private bool flipBytes;
        public bool FlipBytes { get => flipBytes; set { flipBytes = value; isDirty = true; } }

        private DirtyList<BaseProfileMap> maps = new();
        public DirtyList<BaseProfileMap> Maps { get => maps; }

        internal bool TryFile(BinaryFile file)
        {
            throw new NotImplementedException();
        }

        public void ClearDirty(bool deep = true)
        {
            isDirty = false;
            if (!deep)
                return;

            maps.ClearDirty();
            foreach (var map in maps)
                map.ClearDirty();
        }
    }
}