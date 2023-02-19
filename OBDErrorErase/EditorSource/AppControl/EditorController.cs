using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.GUI;
using OBDErrorErase.EditorSource.ProfileManagement;
using OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors;

namespace OBDErrorErase.EditorSource.AppControl
{

    public class EditorController
    {
        private EditorGUI editorGUI;

        private ProfileManager profileManager;
        private BinaryFileManager binaryFileManager;

        private IProfileEditorController profileEditor;
        private IProfileEditorGUI profileEditorGUI;

        public EditorController(EditorGUI editorGUI)
        {
            this.editorGUI = editorGUI;
            profileManager = ServiceContainer.GetService<ProfileManager>();
            binaryFileManager = ServiceContainer.GetService<BinaryFileManager>();

            editorGUI.OnProfileDBChanged(profileManager.GetManufacturers());

            AddGUIListeners();
        }

        private void AddGUIListeners()
        {
            editorGUI.RequestNewProfileEvent += OnNewProfileRequested;
            editorGUI.RequestRemoveProfileEvent += OnRemoveProfileRequested;
            editorGUI.RequestLoadProfileEvent += OnLoadProfileRequested;
            editorGUI.RequestDuplicateProfileEvent += OnProfileDuplicationRequested;

            editorGUI.RequestManufacturerNameChangeEvent += OnManufacturerNameChangeRequested;
            editorGUI.RequestComputerNameChangeEvent += OnComputerNameChangeRequest;

            editorGUI.RequestDuplicateCurrentSubprofile += OnDuplicateCurrentSubprofileRequested;
            editorGUI.RequestRemoveCurrentSubprofile += OnRemoveCurrentSubprofileRequested;
            editorGUI.RequestChangeCurrentSubprofile += OnChangeCurrentSubprofileRequested;

            editorGUI.RequestProfileTypeChangeEvent += OnProfileTypeChangeRequested;

            editorGUI.BinaryFileBrowse += OnBinaryFileLoadRequested;
        }

        private void OnDuplicateCurrentSubprofileRequested()
        {
            if (profileManager.CurrentProfile == null)
                return;

            profileManager.DuplicateCurrentSubprofile();
            profileManager.SetCurrentSubProfile(profileManager.CurrentProfile.Subprofiles.Count - 1);

            editorGUI.UpdateSubProfilesList(profileManager.CurrentProfile.Subprofiles);
            editorGUI.OnCurrentSubprofileChanged(profileManager.CurrentSubProfileIndex);
        }

        private void OnRemoveCurrentSubprofileRequested()
        {
            if (profileManager.CurrentProfile == null)
                return;

            profileManager.RemoveCurrentSubProfile();
            editorGUI.UpdateSubProfilesList(profileManager.CurrentProfile.Subprofiles);
            editorGUI.OnCurrentSubprofileChanged(profileManager.CurrentSubProfileIndex);
        }

        private void OnChangeCurrentSubprofileRequested(int newIndex)
        {
            profileManager.SetCurrentSubProfile(newIndex);
            editorGUI.OnCurrentSubprofileChanged(profileManager.CurrentSubProfileIndex);
        }

        private void RemoveGUIListeners()
        {
            editorGUI.RequestNewProfileEvent -= OnNewProfileRequested;
            editorGUI.RequestRemoveProfileEvent -= OnRemoveProfileRequested;
            editorGUI.RequestLoadProfileEvent -= OnLoadProfileRequested;
            editorGUI.RequestDuplicateProfileEvent -= OnProfileDuplicationRequested;

            editorGUI.RequestManufacturerNameChangeEvent -= OnManufacturerNameChangeRequested;
            editorGUI.RequestComputerNameChangeEvent -= OnComputerNameChangeRequest;
        }

        private void OnNewProfileRequested()
        {
            var newProfile = profileManager.CreateNewProfile();

            SetCurrentProfile(newProfile);
            editorGUI.OnProfileDBChanged(profileManager.GetManufacturers());
        }

        private void OnRemoveProfileRequested(string profileID)
        {
            profileManager.RemoveProfile(profileID);
            editorGUI.OnProfileDBChanged(profileManager.GetManufacturers());
            editorGUI.OnProfileRemoved();
        }

        private void OnProfileDuplicationRequested()
        {
            var newProfile = profileManager.DuplicateCurrentProfile();

            if (newProfile != null)
            {
                SetCurrentProfile(newProfile);
                editorGUI.OnProfileDBChanged(profileManager.GetManufacturers());
            }
        }

        private void OnManufacturerNameChangeRequested(string newManufacturer)
        {
            if (profileManager.CurrentProfile == null)
                return;

            profileManager.SetCurrentProfileManufacturer(newManufacturer);

            editorGUI.OnCurrentProfileChanged(profileManager.CurrentProfile);

            editorGUI.OnProfileDBChanged(profileManager.GetManufacturers());
        }

        private void OnComputerNameChangeRequest(string newName)
        {
            if (profileManager.CurrentProfile == null)
                return;

            profileManager.SetCurrentProfileName(newName);
            editorGUI.OnCurrentProfileChanged(profileManager.CurrentProfile);
        }

        private void OnProfileTypeChangeRequested(ProfileType type)
        {
            profileManager.ChangeCurrentProfileType(type);

            SetCurrentProfile(profileManager.CurrentProfile);
        }

        private void OnBinaryFileLoadRequested(string path)
        {
            var file = binaryFileManager.LoadBinaryFile(path);
            binaryFileManager.SetCurrentFile(file);
            editorGUI.OnCurrentBinaryFileChanged(file, path);
        }

        private void OnLoadProfileRequested(string id)
        {
            var profile = profileManager.LoadProfile(id);

            SetCurrentProfile(profile);
        }

        private void OnProfileSaveRequested()
        {
            profileManager.SaveCurrentProfile();
        }

        private void SetCurrentProfile(Profile newProfile)
        {
            profileManager.SetCurrentProfile(newProfile);

            profileEditor?.Dispose();
            profileEditorGUI?.Dispose();

            profileEditor = ProfileEditorFactory.GetEditorController(newProfile.Type);
            profileEditorGUI = ProfileEditorGUIFactory.GetEditorGUI(newProfile.Type);

            profileEditor.SetGUI(profileEditorGUI);

            editorGUI.SetProfileEditorGUI(profileEditorGUI);

            editorGUI.OnCurrentProfileChanged(newProfile);

            editorGUI.OnCurrentSubprofileChanged(profileManager.CurrentSubProfileIndex);
        }
    }
}