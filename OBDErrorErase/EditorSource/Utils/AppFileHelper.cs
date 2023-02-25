using OBDErrorErase.EditorSource.Configs;
using System.IO;

namespace OBDErrorErase.EditorSource.Utils
{
    public static class AppFileHelper
    {
        private static readonly string appFolder;

        static AppFileHelper()
        {
            appFolder = AppDomain.CurrentDomain.BaseDirectory;
        }

        public static void ValidateAppSubFolder(string subFolderName)
        {
            var folderPath = GetSubfolderPath(subFolderName);

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
        }

        internal static FileInfo[] GetAllFilesInAppSubFolder(string subFolderName)
        {
            var folderPath = GetSubfolderPath(subFolderName);
            if (!Directory.Exists(folderPath))
                return Array.Empty<FileInfo>();

            return new DirectoryInfo(folderPath).GetFiles();
        }

        internal static FileInfo[] GetAllFilesInAppSubFolder(string subFolderName, AppFileExtension extension)
        {
            var allFiles = GetAllFilesInAppSubFolder(subFolderName);

            allFiles = allFiles.Where(fileInfo => fileInfo.Extension.ToLower().Equals($".{extension}")).ToArray();

            return allFiles;
        }

        internal static void SaveStringFile(string serialized, string subFolderName, string fileName, AppFileExtension extension = AppFileExtension.obde)
        {
            ValidateAppSubFolder(subFolderName);

            File.WriteAllText(GetFilePath(subFolderName, fileName, extension), serialized);
        }

        internal static void RemoveFile(string subFolderName, string fileName, AppFileExtension fileExtension = AppFileExtension.obde)
        {
            var filePath = GetFilePath(subFolderName, fileName, fileExtension);

            if (File.Exists(filePath))
                File.Delete(filePath);
        }

        internal static string LoadStringFile(string subFolderName, string fileName, AppFileExtension fileExtension = AppFileExtension.obde)
        {
            var filePath = GetFilePath(subFolderName, fileName, fileExtension);

            if (!File.Exists(filePath))
                throw new Exception($"Could not load file at {filePath}, as it does not exist");

            return File.ReadAllText(filePath);
        }

        public static string GetSubfolderPath(string subFolderName)
        {
            var s = Path.DirectorySeparatorChar;
            return $"{appFolder}{s}{subFolderName}{s}";
        }

        public static string GetFilePath(string subFolderName, string fileName, AppFileExtension extension)
        {
            return $"{GetSubfolderPath(subFolderName)}{fileName}.{extension}";
        }

        public static string OpenFileFromDialog(AppFileExtension extension)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = $"{extension} files (*.{extension})|*.{extension}|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }

            return "";
        }

        public static Stream? GetFilestreamForWriting(AppFileExtension extension)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = $"{extension} files (*.{extension})|*.{extension}|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var stream = saveFileDialog.OpenFile();
                if (stream != null)
                {
                    return stream;
                }
            }

            return null;
        }

        public static byte[] LoadBinaryFile(string path)
        {
            byte[] fileBytes;

            using (FileStream fs = File.OpenRead(path))
            {
                fileBytes = new byte[fs.Length];
                fs.Read(fileBytes, 0, (int)fs.Length);
            }

            return fileBytes;
        }

        internal static void SaveBinaryFile(byte[] data)
        {
            var fileStream = GetFilestreamForWriting(AppFileExtension.bin);

            if (fileStream == null || !fileStream.CanWrite)
            {
                MessageBox.Show("Couldn't open file for writing!", "Error Saving File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            fileStream.Write(data, 0, data.Length);
            fileStream.Dispose();
        }
    }
}
