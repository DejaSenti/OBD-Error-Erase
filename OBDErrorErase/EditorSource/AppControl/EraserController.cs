using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.GUI;
using OBDErrorErase.EditorSource.ProfileManagement;

namespace OBDErrorErase.EditorSource.AppControl
{

    public class EraserController
    {
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
            throw new NotImplementedException();
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

            if (binaryFileManager.CurrentFile != null && profileManager.CurrentProfile != null)
            {
                subprofile = profileManager.CurrentProfile.GetMatchingSubprofile(binaryFileManager.CurrentFile);
            }
            else
            {
                return;
            }

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

            profileManager.CurrentProfile.Process(binaryFileManager.CurrentFile, errorList);
        }

        private bool IsErasingValid()
        {
            return binaryFileManager.CurrentFile != null &&
                profileManager.CurrentProfile != null && profileManager.CurrentProfile.CurrentSubprofile != null;
        }

        private List<string> GetErrorList()
        {
            var result = new List<string>();
            // get error list from textbox
            // get error lists from presets

            return result;
        }

        private void RemoveGUIListeners() 
        {
            throw new NotImplementedException();
        }
    }
}