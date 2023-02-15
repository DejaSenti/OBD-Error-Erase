using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.Maps;
using OBDErrorErase.EditorSource.ProfileManagement;
using System.Diagnostics;

namespace OBDErrorErase
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        // UNCOMMENT TO USE MAIN APP
        //[STAThread]
        //static void Main()
        //{
        //    // To customize application configuration such as set high DPI settings or default font,
        //    // see https://aka.ms/applicationconfiguration.
        //    ApplicationConfiguration.Initialize();
        //    Application.Run(new Main());
        //}

        // TESTING
        [STAThread]
        static void Main()
        {
            // load file
            FileStream stream = new FileStream("C:\\Work\\Binary Files\\WinOLS RS (Citroen Berlingo (Original)) - Copy.bin", FileMode.Open);
            BinaryFile file = new BinaryFile(stream);

            // make bosch profile
            Profile profile = new Profile(ProfileType.BOSCH, "blah", "beh");
            
            profile.Subprofiles[0].Maps[0].SetSearchWord(file);
            MapBosch map = (MapBosch) profile.Subprofiles[0].Maps[0];
            map.NewValue = new byte[] { 0xff, 0xff };

            SubprofileData? subprofile = profile.GetMatchingSubprofile(file);

            if (subprofile == null)
            {
                Debug.WriteLine("No matching subprofile!\n");
                return;
            }

            subprofile.MapLength = 50;
            subprofile.FlipBytes = true; // wtf

            profile.SetSubprofile(subprofile);

            // run processor to delete some value
            profile.Process(file, new List<string> { "5000", "1000", "9080" });


            stream.Dispose();
        }
    }
}