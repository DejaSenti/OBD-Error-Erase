using System;

namespace UITest
{
    public class BinaryFileManager
    {
        public BinaryFile CurrentFile { get; private set; }

        internal BinaryFile LoadBinaryFile(string path)
        {
            throw new NotImplementedException();
        }

        internal void SetCurrentFile(BinaryFile file)
        {
            CurrentFile = file;
        }
    }


}