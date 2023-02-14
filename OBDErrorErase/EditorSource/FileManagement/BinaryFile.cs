namespace OBDErrorErase.EditorSource.FileManagement
{
    public class BinaryFile
    {
        private FileStream stream;

        public BinaryFile(FileStream stream)
        {
            this.stream = stream;
        }

        // returns uint.Max if not found
        internal uint FindValue(byte[] value, uint start, uint end)
        {
            for (uint i = start; i < end; ++i)
            {
                stream.Seek(i, SeekOrigin.Begin);

                var buffer = new byte[value.Length];
                stream.Read(buffer, 0, value.Length);

                bool isMatch = true;

                for (uint j = 0; j < value.Length; ++j)
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

            return uint.MaxValue;
        }

        internal void WriteValue(uint location, byte[] value)
        {
            stream.Seek(location, SeekOrigin.Begin);

            stream.Write(value, 0, value.Length);
        }
    }
}