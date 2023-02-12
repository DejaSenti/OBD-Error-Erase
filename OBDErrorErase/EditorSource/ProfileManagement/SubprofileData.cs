using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.Maps;

namespace OBDErrorErase.EditorSource.ProfileManagement
{
    [Serializable]
    public class SubprofileData
    {
        public uint MapLength { get; set; }
        public bool FlipBytes { get; set; }

        public List<BaseProfileMap> Maps { get; set; } = new();

        internal bool TryFile(BinaryFile file)
        {
            throw new NotImplementedException();
        }
    }
}