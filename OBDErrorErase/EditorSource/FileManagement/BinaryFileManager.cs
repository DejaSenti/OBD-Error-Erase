using OBDErrorErase.EditorSource.Utils;

namespace OBDErrorErase.EditorSource.FileManagement
{
    public class BinaryFileManager
    {
        public BinaryFile? CurrentFile { get; private set; }

        internal BinaryFile? DuplicateCurrentFile()
        {
            return CurrentFile?.Copy();
        }

        internal BinaryFile LoadBinaryFile(string path)
        {
            var bytes = AppFileHelper.LoadBinaryFile(path);
            var result = new BinaryFile(bytes);

            return result;
        }

        internal void SaveBinaryFile(BinaryFile file)
        {
            if (CurrentFile == null)
            {
                MessageBox.Show("No binary file loaded! Save unavailable!", "Binary File Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AppFileHelper.SaveBinaryFile(file.Data);
        }

        internal void SetCurrentFile(BinaryFile file)
        {
            CurrentFile = file;
        }
    }
}