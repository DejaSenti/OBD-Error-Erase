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

        private IProfileEditorController profileEditor;
        private IProfileEditorGUI profileEditorGUI;

        public EditorController(EditorGUI editorGUI)
        {
            this.editorGUI = editorGUI;
            profileManager = ServiceContainer.GetService<ProfileManager>();

            editorGUI.OnProfileDBChanged(profileManager.GetManufacturers());

            AddGUIListeners();
        }

        private void AddGUIListeners()
        {
            // todo listen to any changes in the editor frame gui

            editorGUI.RequestManufacturerNameChangeEvent += OnManufacturerNameChangeRequested;
            editorGUI.RequestComputerNameChangeEvent += OnComputerNameChangeRequest;

            editorGUI.RequestDuplicateCurrentSubprofile += OnDuplicateCurrentSubprofileRequested;
            editorGUI.RequestRemoveCurrentSubprofile += OnRemoveCurrentSubprofileRequested;
            editorGUI.RequestChangeCurrentSubprofile += OnChangeCurrentSubprofileRequested;

            editorGUI.RequestProfileTypeChangeEvent += OnProfileTypeChangeRequested;
        }

        private void OnDuplicateCurrentSubprofileRequested()
        {
            if (profileManager.CurrentProfile == null)
                return;

            profileManager.DuplicateCurrentSubprofile();
            profileManager.SetCurrentSubprofile(profileManager.CurrentProfile.Subprofiles.Count - 1);

            editorGUI.UpdateSubprofilesList(profileManager.CurrentProfile.Subprofiles);
            editorGUI.OnCurrentSubprofileChanged(profileManager.CurrentSubProfileIndex);
        }

        private void OnRemoveCurrentSubprofileRequested()
        {
            if (profileManager.CurrentProfile == null)
                return;

            profileManager.RemoveCurrentSubProfile();
            editorGUI.UpdateSubprofilesList(profileManager.CurrentProfile.Subprofiles);
            editorGUI.OnCurrentSubprofileChanged(profileManager.CurrentSubProfileIndex);
        }

        public void OnChangeCurrentSubprofileRequested(int newIndex)
        {
            profileManager.SetCurrentSubprofile(newIndex);
            OnNewSubprofileLoaded();
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
            if (profileManager.CurrentProfile == null)
                return;

            profileManager.ChangeCurrentProfileType(type);

            OnNewProfileLoaded(profileManager.CurrentProfile);
        }

        internal void OnNewProfileLoaded(Profile newProfile)
        {
            editorGUI.OnProfileDBChanged(profileManager.GetManufacturers());

            profileEditor?.Dispose();
            profileEditorGUI?.Dispose();

            profileEditor = ProfileEditorFactory.GetEditorController(newProfile.Type);
            profileEditorGUI = ProfileEditorGUIFactory.GetEditorGUI(newProfile.Type);

            profileEditor.SetGUI(profileEditorGUI);

            editorGUI.SetProfileEditorGUI(profileEditorGUI);

            editorGUI.OnCurrentProfileChanged(newProfile);

            editorGUI.OnCurrentSubprofileChanged(profileManager.CurrentSubProfileIndex);
        }

        internal void OnNewSubprofileLoaded()
        {
            editorGUI.OnCurrentSubprofileChanged(profileManager.CurrentSubProfileIndex);
        }
    }
}