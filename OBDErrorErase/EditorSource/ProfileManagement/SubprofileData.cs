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

        public bool IsSubprofileFit(BinaryFile file)
        {
            foreach (var map in Maps)
            {
                uint mapLocation = file.FindValue(map.SearchWord.ToArray(), 0, file.Length);

                if (mapLocation == uint.MaxValue)
                    return false;

                map.Location = mapLocation;
            }

            return true;
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