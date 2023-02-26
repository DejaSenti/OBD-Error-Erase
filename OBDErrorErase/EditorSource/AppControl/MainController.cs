using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.GUI;
using OBDErrorErase.EditorSource.ProfileManagement;

namespace OBDErrorErase.EditorSource.AppControl
{
    public class MainController
    {
        private MainGUI mainGUI;
        private ProfileManager profileManager;
        private BinaryFileManager binaryFileManager;
        private EditorController editorController;
        private EraserController eraserController;

        public MainController(MainGUI mainGUI, EditorController editorController, EraserController eraserController)
        {
            this.mainGUI = mainGUI;

            profileManager = ServiceContainer.GetService<ProfileManager>();
            binaryFileManager = ServiceContainer.GetService<BinaryFileManager>();
            
            this.editorController = editorController;
            this.eraserController = eraserController;

            AddGUIListeners();
        }

        private void AddGUIListeners()
        {
            mainGUI.RequestNewProfileEvent += OnNewProfileRequested;
            mainGUI.RequestRemoveProfileEvent += OnRemoveProfileRequested;
            mainGUI.RequestLoadProfileEvent += OnLoadProfileRequested;
            mainGUI.RequestDuplicateProfileEvent += OnProfileDuplicationRequested;
            mainGUI.RequestBinaryFileBrowseEvent += OnBinaryFileLoadRequested;

            mainGUI.FlipBytesEvent += OnFlipBytesToggled;
        }

        private void OnFlipBytesToggled(bool value)
        {
            // todo implement
            throw new NotImplementedException();
        }

        private void OnBinaryFileLoadRequested(string path)
        {
            var file = binaryFileManager.LoadBinaryFile(path);

            if (file == null)
                return;

            binaryFileManager.SetCurrentFile(file);
            mainGUI.UpdateFilenameLabel(Path.GetFileName(path));

            if (profileManager.CurrentProfile != null)
            {
                OnBinaryAndProfileLoaded();
            }
        }

        private void OnLoadProfileRequested(string profileID)
        {
            var profile = profileManager.LoadProfile(profileID);

            if (profile == null)
                return;

            profileManager.SetCurrentProfile(profile);

            if (binaryFileManager.CurrentFile != null)
            {
                OnBinaryAndProfileLoaded();
            }

            editorController.OnNewProfileLoaded(profile);
            eraserController.OnNewProfileLoaded();

            mainGUI.UpdateProfileSelection(profileID);
        }

        private void OnBinaryAndProfileLoaded()
        {
            if (binaryFileManager.CurrentFile == null || profileManager.CurrentProfile == null)
                return;

            var subprofile = profileManager.CurrentProfile.GetMatchingSubprofile(binaryFileManager.CurrentFile);

            if (subprofile == null)
            {
                var result = MessageBox.Show("Couldn't find matching subprofile! Would you like to edit profile?", "No subprofile match", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    mainGUI.LoadEditorTab();
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }

            editorController.OnChangeCurrentSubprofileRequested(profileManager.CurrentSubProfileIndex);

            mainGUI.UpdateFilePreview();
        }

        private void OnNewProfileRequested()
        {
            var newProfile = profileManager.CreateNewProfile();

            if (newProfile == null) 
                return;

            OnProfileDBChanged();

            OnLoadProfileRequested(newProfile.ID);
            mainGUI.LoadEditorTab();
        }

        private void OnProfileDuplicationRequested()
        {
            var newProfile = profileManager.DuplicateCurrentProfile();

            if (newProfile == null) 
                return;

            OnProfileDBChanged();

            OnLoadProfileRequested(newProfile.ID);
            mainGUI.LoadEditorTab();
        }

        private void OnRemoveProfileRequested(string profileID)
        {
            var nextProfileID = mainGUI.GetNextProfileSelection();

            profileManager.RemoveProfile(profileID);

            OnProfileDBChanged();

            if (nextProfileID == null)
                return;

            OnLoadProfileRequested(nextProfileID);
        }

        private void OnProfileDBChanged()
        {
            mainGUI.OnProfileDBChanged(profileManager.GetManufacturers());
        }
    }
}