using System;
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

            editorGUI.SetProfileIDs(profileManager.ProfileIDs);

            AddGUIListeners();
        }

        private void AddGUIListeners()
        {
            editorGUI.RequestNewProfileEvent += OnNewProfileRequested;
            editorGUI.RequestRemoveProfileEvent += OnRemoveProfileRequested;
            editorGUI.RequestLoadProfileEvent += OnLoadProfileRequested;
        }

        private void RemoveGUIListeners()
        {
            editorGUI.RequestNewProfileEvent -= OnNewProfileRequested;
            editorGUI.RequestRemoveProfileEvent -= OnRemoveProfileRequested;
            editorGUI.RequestLoadProfileEvent -= OnLoadProfileRequested;
        }

        private void OnNewProfileRequested()
        {
            var newProfile = profileManager.CreateNewProfile();

            SetCurrentProfile(newProfile);
            OnProfileDBChanged();
        }

        private void OnRemoveProfileRequested(string profileID)
        {
            profileManager.RemoveProfile(profileID);
            OnProfileDBChanged();
            editorGUI.OnProfileRemoved();
        }

        private void OnProfileTypeChangeRequested(ProfileType type)
        {
            var newProfile = profileManager.CreateNewProfile(type);

            SetCurrentProfile(newProfile);
        }

        private void OnBinaryFileLoadRequested(string path)
        {
            var file = binaryFileManager.LoadBinaryFile(path);
            binaryFileManager.SetCurrentFile(file);
            editorGUI.OnCurrentBinaryFileChanged(path);
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
        }

        private void OnProfileDBChanged()
        {
            editorGUI.SetProfileIDs(profileManager.ProfileIDs);
        }
    }
}