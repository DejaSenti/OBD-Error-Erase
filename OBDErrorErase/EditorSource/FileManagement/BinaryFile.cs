using OBDErrorErase.EditorSource.ProfileManagement;

namespace OBDErrorErase.EditorSource.FileManagement
{
    public class BinaryFile
    {
        private FileStream stream;

        public BinaryFile(FileStream stream)
        {
            this.stream = stream;
        }

        public int Length => (int)(stream?.Length ?? 0);

        /// <returns>-1 if not found</returns>
        internal int FindValue(byte[] value, int start, int end)
        {
            for (int i = start; i < end; ++i)
            {
                stream.Seek(i, SeekOrigin.Begin);

                var buffer = new byte[value.Length];
                stream.Read(buffer, 0, value.Length);

                bool isMatch = true;

                for (int j = 0; j < value.Length; ++j)
                {
                    if (value[j] != buffer[j])
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
            stream.Seek(location, SeekOrigin.Begin);

            byte[] result = new byte[length];
            stream.Read(result, 0, length);

            return result;
        }

        internal void WriteValue(int location, byte[] value)
        {
            stream.Seek(location, SeekOrigin.Begin);

            stream.Write(value, 0, value.Length);
        }
    }
}