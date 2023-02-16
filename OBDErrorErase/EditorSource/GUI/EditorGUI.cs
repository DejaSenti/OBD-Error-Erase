using System;
using System.Text.RegularExpressions;
using OBDErrorErase.EditorSource.ProfileManagement;
using OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors;

namespace OBDErrorErase.EditorSource.GUI
{
    public class EditorGUI
    {
        public event Action? RequestNewProfileEvent;
        public event Action<string>? RequestRemoveProfileEvent;
        public event Action<string>? RequestLoadProfileEvent;

        private readonly Main guiHolder;

        private string[]? currentFilterWords;

        private IReadOnlyList<string> profileIDsRef;

#pragma warning disable CS8603 // Possible null reference return. (is validated to not happen)
        private string SelectedProfileID => guiHolder.EditorListProfiles.SelectedItems.Count > 0 ? guiHolder.EditorListProfiles.SelectedItems[0] as string : "";
#pragma warning restore CS8603 // Possible null reference return. (is validated to not happen)

        public EditorGUI(Main guiHolder)
        {
            this.guiHolder = guiHolder;
            AddListeners();
            UpdateProfilesRelatedEnableStatuses();
        }

        private void AddListeners()
        {
            guiHolder.EditorButtonNewProfile.Click += OnNewProfileClicked;
            guiHolder.EditorButtonProfileRemove.Click += OnRemoveProfileClicked;

            guiHolder.EditorListProfiles.SelectedIndexChanged += OnProfileSelectionChanged;

            guiHolder.EditorTextboxProfileFilter.TextChanged += OnFilterTextChanged;
        }

        private void OnProfileSelectionChanged(object? sender, EventArgs e)
        {
            UpdateProfilesRelatedEnableStatuses();

            if(!string.IsNullOrEmpty(SelectedProfileID))
                RequestLoadProfileEvent?.Invoke(SelectedProfileID);
        }

        private void OnRemoveProfileClicked(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SelectedProfileID))
                RequestRemoveProfileEvent?.Invoke(SelectedProfileID);
        }

        private void OnNewProfileClicked(object? sender, EventArgs e)
        {
            RequestNewProfileEvent?.Invoke();
        }

        private void OnFilterTextChanged(object? sender, EventArgs e)
        {
            currentFilterWords = Regex.Split(guiHolder.EditorTextboxProfileFilter.Text, @"\s+");

            UpdateProfilesList();
            UpdateProfilesRelatedEnableStatuses();
        }

        internal void OnCurrentProfileChanged(Profile currentProfile)
        {
            // create relevant view 
            //todo implement
        }

        internal void OnCurrentBinaryFileChanged(string path)
        {
            //todo implement
        }

        internal void SetProfileEditorGUI(IProfileEditorGUI profileEditorGUI)
        {
            //todo implement
        }

        internal void SetProfileIDs(IReadOnlyList<string> profileIDs)
        {
            profileIDsRef = profileIDs;

            UpdateProfilesList();
        }

        private void UpdateProfilesList()
        {
            guiHolder.EditorListProfiles.Items.Clear();

            foreach (var profileID in profileIDsRef)
            {
                if (ProfileIDMatchesFiltter(profileID))
                    guiHolder.EditorListProfiles.Items.Add(profileID);
            }
        }


        private bool ProfileIDMatchesFiltter(string profileID)
        {
            if (currentFilterWords == null || currentFilterWords.Length == 0 || string.IsNullOrEmpty(profileID))
                return true;

            int index = 0;
            foreach (string filterWord in currentFilterWords)
            {
                index = profileID.ToLower().IndexOf(filterWord.ToLower(), index);

                if (index == -1)
                    return false;

                index += filterWord.Length;
            }
            return true;
        }

        private void UpdateProfilesRelatedEnableStatuses()
        {
            guiHolder.EditorButtonProfileRemove.Enabled = !string.IsNullOrEmpty(SelectedProfileID);
        }
    }
}