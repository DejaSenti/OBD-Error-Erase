using System.Diagnostics;
using System.Reflection;

namespace OBDErrorErase.EditorSource.Utils
{
    public static class AppFileHelper
    {
        private static readonly string appFolder;

        static AppFileHelper()
        {
            appFolder = AppDomain.CurrentDomain.BaseDirectory;
        }

        internal static void SaveStringFile(string serialized, string folderName, string fileName, string extension = "obde")
        {
            var s = Path.DirectorySeparatorChar;
            var folderPath = $"{appFolder}{s}{folderName}";

            if(!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            var filePath = $"{folderPath}{s}{fileName}.{extension}";
            File.WriteAllText(filePath, serialized);
        }
    }
}
