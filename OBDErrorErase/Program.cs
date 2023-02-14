using OBDErrorErase.EditorSource.Maps;
using OBDErrorErase.EditorSource.ProfileManagement;
using OBDErrorErase.EditorSource.Utils;
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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Main());

            var testProfileData = new Profile(ProfileType.BOSCH, "Shoosh", "peepee-jojo");

            var subprof1 = new SubprofileData();
            subprof1.MapLength = 10;
            subprof1.FlipBytes = true;
            subprof1.Maps.Add(new MapBosch("WEEEE"));

            var subprof2 = new SubprofileData();
            subprof2.MapLength = 3;
            subprof2.FlipBytes = false;
            subprof2.Maps.Add(new MapBosch("wee"));

            testProfileData.Subprofiles.Add(subprof1);
            testProfileData.Subprofiles.Add(subprof2);

            var serializationOptions = new JsonSerializerOptions();

            serializationOptions.WriteIndented = true;

            var serialized = JsonSerializer.Serialize(testProfileData, serializationOptions);

            AppFileHelper.SaveStringFile(serialized, "Profiles", "DOOOD");
        }
    }
}