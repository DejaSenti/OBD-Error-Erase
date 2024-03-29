﻿using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.GUI;
using OBDErrorErase.EditorSource.ProfileManagement;
using OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors;

namespace OBDErrorErase.EditorSource.AppControl
{
    public class EditorController
    {
        public event Action? AddressChangedEvent;
        public event Action? ProfileSavedEvent;   

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

            editorGUI.RequestSaveCurrentProfile += OnProfileSaveRequested;
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

            profileEditor.OnCurrentSubprofileChanged();
        }

        private void OnChangeCurrentSubprofileRequested(int newIndex)
        {
            profileManager.SetCurrentSubprofile(newIndex);
            OnNewSubprofileLoaded();
        }

        private void OnManufacturerNameChangeRequested(string newManufacturer)
        {
            if (profileManager.CurrentProfile == null)
                return;

            profileManager.SetCurrentProfileManufacturer(newManufacturer);
            //editorGUI.OnCurrentProfileChanged(profileManager.CurrentProfile);
        }

        private void OnComputerNameChangeRequested(string newName)
        {
            if (profileManager.CurrentProfile == null)
                return;

            profileManager.SetCurrentProfileName(newName);
            //editorGUI.OnCurrentProfileChanged(profileManager.CurrentProfile);
        }

        private void OnProfileTypeChangeRequested(ProfileType type)
        {
            if (profileManager.CurrentProfile == null)
                return;

            profileManager.ChangeCurrentProfileType(type);

            OnNewProfileLoaded();
        }

        public void OnNewProfileLoaded()
        {
            var profile = profileManager.CurrentProfile;

            if (profile == null)
                return;

            editorGUI.OnProfileDBChanged(profileManager.GetManufacturers());

            DisposeProfileEditor();

            profileEditor = ProfileEditorFactory.GetEditorController(profile.Type);
            profileEditorGUI = ProfileEditorGUIFactory.GetEditorGUI(profile.Type);
            profileEditor.SetGUI(profileEditorGUI);
            profileEditor.AddressChangedEvent += OnAddressChanged;

            editorGUI.SetProfileEditorGUI(profileEditorGUI);

            editorGUI.OnCurrentProfileChanged(profile);

            editorGUI.OnCurrentSubprofileChanged(profileManager.CurrentSubProfileIndex);
        }

        public void OnNewProfileCreated(Profile profile)
        {
            if (profile == null)
                return;

            DisposeProfileEditor();

            profileEditor = ProfileEditorFactory.GetEditorController(profile.Type);
            profileEditorGUI = ProfileEditorGUIFactory.GetEditorGUI(profile.Type);
            profileEditor.SetGUI(profileEditorGUI);
            profileEditor.AddressChangedEvent += OnAddressChanged;

            editorGUI.SetProfileEditorGUI(profileEditorGUI);

            editorGUI.OnCurrentProfileChanged(profile);

            profileEditor.OnCurrentSubprofileChanged();
            editorGUI.OnCurrentSubprofileChanged(profileManager.CurrentSubProfileIndex);
        }

        public void OnNewSubprofileLoaded()
        {
            editorGUI.OnCurrentSubprofileChanged(profileManager.CurrentSubProfileIndex);
            profileEditor.OnCurrentSubprofileChanged();

            var binaryFileManager = ServiceContainer.GetService<BinaryFileManager>();
            if (binaryFileManager.CurrentFile != null)
            {
                profileEditorGUI.EnableAddressFields();
            }
        }

        public void OnProfileUnloaded()
        {
            editorGUI.ClearFields();
            editorGUI.OnCurrentSubprofileChanged(profileManager.CurrentSubProfileIndex);
            
            DisposeProfileEditor();
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