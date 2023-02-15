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

            var pm = ServiceContainer.GetService<ProfileManager>();

            var prof1 = pm.CreateNewProfile();
            var prof2 = pm.CreateNewProfile();
            var prof3= pm.CreateNewProfile();

            prof1.Manufacturer = "dood";
            prof3.Name = "what";

            pm.SaveCurrentProfile();
            pm.SaveProfile(prof1);

            var loadedProfile = pm.LoadProfile(prof1.ID);
            Debug.WriteLine("ID - "+loadedProfile?.ID);
            Debug.WriteLine("Manufacturer - "+loadedProfile?.Manufacturer);

            //if(loadedProfile != null)
              //  pm.RemoveProfile(loadedProfile.ID);

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