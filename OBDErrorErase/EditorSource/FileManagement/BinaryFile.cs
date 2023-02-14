namespace OBDErrorErase.EditorSource.FileManagement
{
    public class BinaryFile
    {
        private FileStream stream;

        public BinaryFile(FileStream stream)
        {
            this.stream = stream;
        }

        internal int FindValue(string error)
        {
            throw new NotImplementedException();
        }

        internal void WriteValue(int location, string newValue)
        {
            throw new NotImplementedException();
        }
    }
}