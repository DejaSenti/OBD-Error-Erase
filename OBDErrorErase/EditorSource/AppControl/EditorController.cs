using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.GUI;
using OBDErrorErase.EditorSource.ProfileManagement;
using OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors;

namespace OBDErrorErase.EditorSource.AppControl
{
    public class EditorController
    {
        public event Action? AddressChangedEvent;
        public event Action? ProfileSavedEvent;   

        private readonly EditorGUI editorGUI;

        private readonly ProfileManager profileManager;

        private IProfileEditorController? profileEditor;
        private IProfileEditorGUI? profileEditorGUI;

        public EditorController(EditorGUI editorGUI)
        {
            this.editorGUI = editorGUI;
            profileManager = ServiceContainer.GetService<ProfileManager>();

            editorGUI.OnProfileDBChanged(profileManager.GetManufacturers());

            AddGUIListeners();
        }

        private void AddGUIListeners()
        {
            editorGUI.RequestDuplicateCurrentSubprofile += OnDuplicateCurrentSubprofileRequested;
            editorGUI.RequestRemoveCurrentSubprofile += OnRemoveCurrentSubprofileRequested;
            editorGUI.RequestChangeCurrentSubprofile += OnChangeCurrentSubprofileRequested;

            editorGUI.RequestFillSubprofileData += OnFillSubprofileDataRequested;
            editorGUI.RequestProfileTypeChangeEvent += OnProfileTypeChangeRequested;

            editorGUI.RequestSaveCurrentProfile += OnProfileSaveRequested;
        }

        private void OnFillSubprofileDataRequested(int index)
        {
            
        }

        private void OnProfileSaveRequested()
        {
            profileManager.SaveCurrentProfile();

            ProfileSavedEvent?.Invoke();
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

            int nextSubprofileIndex = editorGUI.GetNextSubprofileIndex();

            if (nextSubprofileIndex == -1) // not supposed to happen
                return;

            profileManager.RemoveCurrentSubProfile();
            editorGUI.UpdateSubprofilesList(profileManager.CurrentProfile.Subprofiles);

            profileManager.SetCurrentSubprofile(nextSubprofileIndex);

            editorGUI.OnCurrentSubprofileChanged(profileManager.CurrentSubProfileIndex);

            profileEditor?.FillSubprofileData(profileManager.CurrentSubProfile);
        }

        private void OnChangeCurrentSubprofileRequested(int newIndex)
        {
            profileManager.SetCurrentSubprofile(newIndex);
            OnNewSubprofileLoaded();
        }

        private void OnProfileTypeChangeRequested(ProfileType type)
        {
            DisposeProfileEditor();

            profileEditor = ProfileEditorFactory.GetEditorController(type);
            profileEditorGUI = ProfileEditorGUIFactory.GetEditorGUI(type);
            profileEditor.SetGUI(profileEditorGUI);
            profileEditor.AddressChangedEvent += OnAddressChanged;

            editorGUI.SetProfileEditorGUI(profileEditorGUI);
        }

        public void OnNewSubprofileLoaded()
        {
            editorGUI.OnCurrentSubprofileChanged(profileManager.CurrentSubProfileIndex);
            profileEditor?.FillSubprofileData(profileManager.CurrentSubProfile);

            var binaryFileManager = ServiceContainer.GetService<BinaryFileManager>();
            if (binaryFileManager.CurrentFile != null)
            {
                profileEditorGUI?.EnableAddressFields();
            }
        }

        public void OnProfileUnloaded()
        {
            editorGUI.ClearFields();
        }

        private void OnAddressChanged()
        {
            AddressChangedEvent?.Invoke();
        }

        public void EnableAddressFields()
        {
            profileEditorGUI?.EnableAddressFields();
        }

        private void DisposeProfileEditor()
        {
            if (profileEditor != null)
            {
                profileEditor.AddressChangedEvent -= OnAddressChanged;
            }

            profileEditor?.Dispose();
            profileEditorGUI?.Dispose();
        }
    }
}