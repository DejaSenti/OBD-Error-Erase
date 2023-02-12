using OBDErrorErase.EditorSource.Maps;

namespace OBDErrorErase.EditorSource.ProfileManagement
{
    public class SubprofileData
    {
        public uint MapLength;
        public bool FlipBytes;

        public List<IProfileMap> Maps = new();
    }
}