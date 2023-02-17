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

        private string SelectedProfileID = "";

        public EditorGUI(Main guiHolder)
        {
            this.guiHolder = guiHolder;
            AddListeners();
            UpdateRemoveButtonEnabled();
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
            SelectedProfileID = (string)guiHolder.EditorListProfiles.Items[guiHolder.EditorListProfiles.SelectedIndex];

            UpdateRemoveButtonEnabled();

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
            UpdateRemoveButtonEnabled();

            if (!string.IsNullOrEmpty(SelectedProfileID) && guiHolder.EditorListProfiles.Items.Contains(SelectedProfileID))
                guiHolder.EditorListProfiles.SelectedItem = SelectedProfileID;
        }

        public void OnProfileRemoved()
        {
            SelectedProfileID = "";
            UpdateRemoveButtonEnabled();
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
            var previousSelection = guiHolder.EditorListProfiles.SelectedIndex;

            guiHolder.EditorListProfiles.Items.Clear();

            foreach (var profileID in profileIDsRef)
            {
                if (ProfileIDMatchesFilter(profileID))
                    guiHolder.EditorListProfiles.Items.Add(profileID);
            }

            
            guiHolder.EditorListProfiles.SelectedItem = SelectedProfileID;
        }


        private bool ProfileIDMatchesFilter(string profileID)
        {
            if (currentFilterWords == null || currentFilterWords.Length == 0)
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

        private void UpdateRemoveButtonEnabled() => guiHolder.EditorButtonProfileRemove.Enabled = !string.IsNullOrEmpty(SelectedProfileID);
    }
}