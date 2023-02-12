using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.ProfileManagement;

namespace OBDErrorErase.EditorSource.AppControl
{
    public class ErrorProcessor
    {
        public SubprofileData CurrentSubprofile { get; private set; }

        public void SetSubprofile(SubprofileData subprofile)
        {
            CurrentSubprofile = subprofile;
        }

        public void Process(BinaryFile file, List<string> errors)
        {
            foreach (var error in errors)
            {
                foreach (var map in CurrentSubprofile.Maps)
                {
                    map.Process(file, error);
                }
            }
        }
    }
}