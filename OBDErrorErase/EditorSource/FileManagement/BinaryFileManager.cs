using OBDErrorErase.EditorSource.Utils;
using System;

namespace OBDErrorErase.EditorSource.FileManagement
{
    public class BinaryFileManager
    {
        public BinaryFile CurrentFile { get; private set; }

        internal BinaryFile LoadBinaryFile(string path)
        {
            var bytes = AppFileHelper.LoadBinaryFile(path);
            var result = new BinaryFile(bytes);

            return result;
        }

        internal void SetCurrentFile(BinaryFile file)
        {
            CurrentFile = file;
        }
    }
}