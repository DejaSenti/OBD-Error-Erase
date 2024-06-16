using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.GUI;
using OBDErrorErase.EditorSource.ProfileManagement;

namespace OBDErrorErase.EditorSource.AppControl
{
    public class MainController
    {
        private readonly Main mainGUI;
        private readonly ProfileManager profileManager;
        private readonly BinaryFileManager binaryFileManager;
        private readonly EditorController editorController;
        private readonly EraserController eraserController;

        public MainController(Main mainGUI, EditorController editorController, EraserController eraserController)
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

            editorController.AddressChangedEvent += OnAddressChanged;
            editorController.ProfileSavedEvent += OnProfileSaved;

            eraserController.EraseCompleteEvent += OnEraseComplete;
        }

        private void OnEraseComplete()
        {
            UpdateFilePreview();
        }

        private void OnProfileSaved()
        {
            OnProfileDBChanged();
        }

        private void OnAddressChanged()
        {
            UpdateFilePreview();
        }

        private void OnFlipBytesToggled(bool value)
        {
            if (binaryFileManager.CurrentFile == null || profileManager.CurrentSubProfile == null)
                return;

            profileManager.CurrentSubProfile.FlipBytes = value;

            UpdateFilePreview();
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
            if (profileManager.CurrentProfile != null)
            {
                UnloadProfile();
            }

            if (string.IsNullOrEmpty(profileID))
                return;

            var profile = ProfileManager.LoadProfile(profileID);

            if (profile == null)
                return;

            profileManager.SetCurrentProfile(profile);

            eraserController.OnNewProfileLoaded();

            if (binaryFileManager.CurrentFile != null)
            {
                OnBinaryAndProfileLoaded();
            }

            mainGUI.UpdateProfileSelection(profileID);
        }

        private void OnBinaryAndProfileLoaded()
        {
            if (binaryFileManager.CurrentFile == null || profileManager.CurrentProfile == null)
                return;

            var subprofile = profileManager.CurrentProfile.GetMatchingSubprofile(binaryFileManager.CurrentFile);

            if (subprofile == null)
            {
                ClearFilePreview();

                var result = MessageBox.Show("Couldn't find matching subprofile! Would you like to edit profile?", "No subprofile match", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    mainGUI.LoadEditorTab();
                }

                return;
            }

            profileManager.SetCurrentSubprofile(subprofile);
            editorController.OnNewSubprofileLoaded();
            editorController.EnableAddressFields();
            UpdateFilePreview();
        }

        private void ClearFilePreview()
        {
            mainGUI.ClearFilePreview();
        }

        private void UpdateFilePreview()
        {
            var subprofile = profileManager.CurrentSubProfile;

            if (subprofile == null || binaryFileManager.CurrentFile == null) 
                return;

            var map = subprofile.Maps[0];

            var file = binaryFileManager.CurrentFile;
            var displayLocation = map.Location;

            if (displayLocation == -1)
                return;

            var errorList = map.GetErrorList(file, displayLocation);

            if (subprofile.FlipBytes)
            {
                for (int i = 0; i < errorList.Length; ++i)
                {
                    (errorList[i][0], errorList[i][1]) = (errorList[i][1], errorList[i][0]);
                }
            }

            mainGUI.UpdateFilePreview(displayLocation, map.NewValue.Count, errorList);
        }

        private void OnNewProfileRequested()
        {
            UnloadProfile();
            mainGUI.LoadEditorTab();
        }

        private void OnProfileDuplicationRequested()
        {
            var newProfile = profileManager.DuplicateCurrentProfile();

            if (newProfile == null) 
                return;

            profileManager.SetCurrentProfile(newProfile);

            profileManager.SaveCurrentProfile();

            OnProfileDBChanged();

            mainGUI.LoadEditorTab();
        }

        private void OnRemoveProfileRequested(string profileID)
        {
            var nextProfileID = mainGUI.GetNextProfileSelection();

            profileManager.RemoveProfile(profileID);

            OnProfileDBChanged();

            OnLoadProfileRequested(nextProfileID);
        }

        private void UnloadProfile()
        {
            profileManager.UnloadProfile();
            mainGUI.ClearFields();
            editorController.OnProfileUnloaded();
            eraserController.OnProfileUnloaded();
        }

        private void OnProfileDBChanged()
        {
            mainGUI.UpdateManufacturerList();
            mainGUI.UpdateProfilesList();
        }
    }
}