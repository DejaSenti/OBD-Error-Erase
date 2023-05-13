using OBDErrorErase.EditorSource.Utils;

namespace OBDErrorErase.EditorSource.FileManagement
{
    public class BinaryFileManager
    {
        public BinaryFile? CurrentFile { get; private set; }

        public BinaryFile? DuplicateCurrentFile()
        {
            return CurrentFile?.Copy();
        }

        public BinaryFile LoadBinaryFile(string path)
        {
            var bytes = AppFileHelper.LoadBinaryFile(path);
            var result = new BinaryFile(bytes);

            return result;
        }

        public void SaveBinaryFile(BinaryFile file)
        {
            if (CurrentFile == null)
            {
                MessageBox.Show("No binary file loaded! Save unavailable!", "Binary File Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AppFileHelper.SaveBinaryFile(file.Data);
        }

        public void SetCurrentFile(BinaryFile file)
        {
            CurrentFile = file;
        }
    }
}