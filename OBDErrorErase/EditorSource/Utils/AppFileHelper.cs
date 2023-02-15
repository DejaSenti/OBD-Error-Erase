namespace OBDErrorErase.EditorSource.Utils
{
    public static class AppFileHelper
    {
        public const string STRING_FILES_EXTENSION = "obde";

        private static readonly string appFolder;

        static AppFileHelper()
        {
            appFolder = AppDomain.CurrentDomain.BaseDirectory;
        }

        public static void ValidateAppSubFolder(string subFolderName)
        {
            var s = Path.DirectorySeparatorChar;
            var folderPath = $"{appFolder}{s}{subFolderName}";

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
    }
}
