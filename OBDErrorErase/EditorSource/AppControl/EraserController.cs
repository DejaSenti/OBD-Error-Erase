using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.GUI;
using OBDErrorErase.EditorSource.ProfileManagement;

namespace OBDErrorErase.EditorSource.AppControl
{

    public class EraserController
    {
        readonly char[] ERROR_DELIMITERS = new char[]{ ',', '.', ' ' };
        private EraserGUI eraserGUI;

        private ProfileManager profileManager;
        private BinaryFileManager binaryFileManager;

        public EraserController(EraserGUI eraserGUI)
        {
            this.eraserGUI = eraserGUI;
            profileManager = ServiceContainer.GetService<ProfileManager>();
            binaryFileManager = ServiceContainer.GetService<BinaryFileManager>();

            // TODO load error preset files

            AddGUIListeners();
        }

        private void AddGUIListeners()
        {
            //throw new NotImplementedException();
        }

        public void OnProfileSelected(string id)
        {
            var newProfile = profileManager.LoadProfile(id);

            if (newProfile == null)
                return;

            profileManager.SetCurrentProfile(newProfile);

            UpdateSubprofile();
        }

        public void OnBinaryFileLoadRequested(string path)
        {
            var file = binaryFileManager.LoadBinaryFile(path);

            if (file == null)
                return;

            binaryFileManager.SetCurrentFile(file);
            eraserGUI.OnCurrentBinaryFileChanged(path);

            UpdateSubprofile();
        }

        public void OnAddErrorPresetRequested(string path)
        {
            throw new NotImplementedException();
        }

        private void UpdateSubprofile()
        {
            SubprofileData? subprofile = null;

            if (binaryFileManager.CurrentFile == null || profileManager.CurrentProfile == null)
                return;

            subprofile = profileManager.CurrentProfile.GetMatchingSubprofile(binaryFileManager.CurrentFile);

            if (subprofile == null)
            {
                // TODO notify preview about no match

                return;
            }
			
            profileManager.CurrentProfile.SetSubprofile(subprofile);
			
            // TODO notify preview about match
        }

        public void OnErrorEraseRequested()
        {
            var errorList = GetErrorList();

            if (!IsErasingValid() || errorList.Count == 0)
            {
                // notify GUI about lack of needed pieces to start process
                return;
            }

            int totalErased = profileManager.CurrentProfile.Process(binaryFileManager.CurrentFile, errorList);

            // notify GUI about total erased and error list count
            // save new file
        }

        private bool IsErasingValid()
        {
            return binaryFileManager.CurrentFile != null &&
                profileManager.CurrentProfile != null && profileManager.CurrentProfile.CurrentSubprofile != null;
        }

        private List<string> GetErrorList()
        {
            var result = new List<string>();

            var textboxErrorList = eraserGUI.GetTextboxErrorList();
            AddErrorsFromStringToList(textboxErrorList, result);

            var errorPresetFilePathList = eraserGUI.GetPresetPathList();
            foreach(var path in errorPresetFilePathList)
            {
                var fileContents = File.ReadAllText(path);
                AddErrorsFromStringToList(fileContents, result);
            }

            return result;
        }

        private void AddErrorsFromStringToList(string errors, List<string> list)
        {
            var splitErrors = errors.Split(ERROR_DELIMITERS, StringSplitOptions.RemoveEmptyEntries);
            list.AddRange(splitErrors);
            list = list.Distinct().ToList();
        }

        private void RemoveGUIListeners() 
        {
            throw new NotImplementedException();
        }
    }
}