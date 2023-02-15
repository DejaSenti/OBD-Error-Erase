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

        public bool IsSubprofileFit(BinaryFile file)
        {
            foreach (var map in Maps)
            {
                uint mapLocation = file.FindValue(map.SearchWord, 0, file.Length);

                if (mapLocation == uint.MaxValue)
                    return false;

                map.Location = mapLocation;
            }

            return true;
        }
    }
}