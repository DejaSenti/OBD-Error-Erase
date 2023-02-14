using System;
using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.GUI;
using OBDErrorErase.EditorSource.ProfileManagement;

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

            AddGUIListeners();
        }

        private void AddGUIListeners()
        {
            throw new NotImplementedException();
        }

        private void OnNewProfileRequested()
        {
            var newProfile = profileManager.CreateNewProfile();
            profileManager.SetCurrentProfile(newProfile);

            OnProfileChanged();
        }

        private void OnProfileTypeChangeRequested(ProfileType type)
        {
            profileManager.UpdateCurrentProfileType(type);

            OnProfileChanged();
        }

        private void OnBinaryFileLoadRequested(string path)
        {
            var file = binaryFileManager.LoadBinaryFile(path);
            binaryFileManager.SetCurrentFile(file);
            editorGUI.OnCurrentBinaryFileChanged(path);
        }

        private void OnProfileLoadRequested(string id)
        {
            var profile = profileManager.LoadProfile(id);
            profileManager.SetCurrentProfile(profile);

            OnProfileChanged();
        }

        private void OnProfileSaveRequested()
        {
            profileManager.SaveProfile();
        }

        private void OnProfileChanged()
        {
            profileEditor?.RemoveListeners();
            profileEditorGUI?.RemoveListeners();

            profileEditor = ProfileEditorFactory.GetEditorController(profileManager.CurrentProfile.Type);
            profileEditorGUI = ProfileEditorGUIFactory.GetEditorGUI(profileManager.CurrentProfile.Type);

            profileEditor.SetGUI(profileEditorGUI);

            editorGUI.SetProfileEditorGUI(profileEditorGUI);

            editorGUI.OnCurrentProfileChanged(profileManager.CurrentProfile);
        }

        private void RemoveGUIListeners()
        {
            throw new NotImplementedException();
        }
    }
}