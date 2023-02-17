using OBDErrorErase.EditorSource.AppControl;
using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.GUI;
using OBDErrorErase.EditorSource.ProfileManagement;

namespace OBDErrorErase
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            InitializeServices();

            var mainForm = new Main();

            InitializeViewControllers(mainForm);

            Application.Run(mainForm);
        }

        private static void InitializeViewControllers(Main mainForm)
        {
            var editorGUI = new EditorGUI(mainForm);
            var editorController = new EditorController(editorGUI);
            var eraserGUI = new EraserGUI(mainForm);
            var eraserController = new EraserController(eraserGUI);
        }

        private static void InitializeServices()
        {
            ServiceContainer.AddService(new BinaryFileManager());
            ServiceContainer.AddService(new ProfileManager());
        }
    }
}