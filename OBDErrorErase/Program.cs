using OBDErrorErase.EditorSource.AppControl;
using OBDErrorErase.EditorSource.Maps;
using OBDErrorErase.EditorSource.ProfileManagement;
using OBDErrorErase.EditorSource.Utils;
using System.Diagnostics;
using System.Text.Json;

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
            InitializeServices();
            StartApp();
        }

        private static void InitializeServices()
        {
            ServiceContainer.AddService(new ProfileManager());
        }

        private static void StartApp()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}