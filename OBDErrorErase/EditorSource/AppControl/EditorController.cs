﻿using OBDErrorErase.EditorSource.GUI;
using OBDErrorErase.EditorSource.ProfileManagement;
using OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors;

namespace OBDErrorErase.EditorSource.AppControl
{

    public class EditorController
    {
        public event Action ProfileEditedEvent;

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
            editorGUI.RequestManufacturerNameChangeEvent += OnManufacturerNameChangeRequested;
            editorGUI.RequestComputerNameChangeEvent += OnComputerNameChangeRequested;

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

            int nextSubprofileIndex = editorGUI.GetNextSubprofileIndex();

            if (nextSubprofileIndex == -1) // not supposed to happen
                return;

            profileManager.RemoveCurrentSubProfile();
            editorGUI.UpdateSubprofilesList(profileManager.CurrentProfile.Subprofiles);

            profileManager.SetCurrentSubprofile(nextSubprofileIndex);

            editorGUI.OnCurrentSubprofileChanged(profileManager.CurrentSubProfileIndex);

            profileEditor.OnCurrentSubprofileChanged();
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

            ProfileEditedEvent?.Invoke();
        }

        private void OnComputerNameChangeRequested(string newName)
        {
            if (profileManager.CurrentProfile == null)
                return;

            profileManager.SetCurrentProfileName(newName);
            editorGUI.OnCurrentProfileChanged(profileManager.CurrentProfile);

            ProfileEditedEvent?.Invoke();
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
            profileEditor.OnCurrentSubprofileChanged();
        }

        internal void OnProfileUnloaded()
        {
            editorGUI.ClearFields();
            editorGUI.OnCurrentSubprofileChanged(profileManager.CurrentSubProfileIndex);

            profileEditor?.Dispose();
            profileEditorGUI?.Dispose();
        }
    }
}