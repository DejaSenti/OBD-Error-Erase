using OBDErrorErase.EditorSource.ProfileManagement;

namespace OBDErrorErase.EditorSource.FileManagement
{
    public class BinaryFile
    {
        public byte[] Data => data;
        private byte[] data;

        public int Length => data?.Length ?? 0;

        public BinaryFile(byte[] data)
        {
            this.data = data;
        }

        /// <returns>-1 if not found</returns>
        internal int FindValue(byte[] value, int start, int end)
        {
            for (int i = start; (i + value.Length < Length) && (i < end - value.Length); ++i)
            {
                bool isMatch = true;

                for (int j = 0; (i + j < Length) && (j < value.Length); ++j)
                {
                    if (value[j] != data[i + j])
                    {
                        isMatch = false;
                        break;
                    }
                }

                if (isMatch)
                    return i;
            }

            return -1;
        }

        internal int FindValue(DirtyList<byte> value, int start, int end)
        {
            byte[] array = value.ToArray();
            return FindValue(array, start, end);
        }

        internal byte[] ReadValue(int location, int length)
        {
            byte[] result = new byte[length];

            for (int i = 0; i < length; ++i)
            {
                result[i] = data[location + i];
            }

            return result;
        }

        internal void WriteValue(int location, byte[] value)
        {
            for (int i = 0; location + i < Length && i < value.Length; ++i)
            {
                data[location + i] = value[i];
            }
        }
    }
}