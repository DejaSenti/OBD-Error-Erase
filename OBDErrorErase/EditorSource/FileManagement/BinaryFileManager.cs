using OBDErrorErase.EditorSource.Utils;
using System;
using System.IO;

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

        internal void SaveBinaryFile(Stream? fileStream)
        {
            if (fileStream == null)
                return;

            var bytes = CurrentFile.Data;
            fileStream.Write(bytes, 0, bytes.Length);
            fileStream.Dispose();
        }

        internal void SetCurrentFile(BinaryFile file)
        {
            CurrentFile = file;
        }
    }
}