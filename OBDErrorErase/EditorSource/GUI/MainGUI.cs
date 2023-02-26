﻿using OBDErrorErase.EditorSource.AppControl;
using OBDErrorErase.EditorSource.Configs;
using OBDErrorErase.EditorSource.ProfileManagement;
using OBDErrorErase.EditorSource.Utils;
using System.Text.RegularExpressions;

namespace OBDErrorErase.EditorSource.GUI
{
    public class MainGUI
    {
        public event Action? RequestNewProfileEvent;
        public event Action? RequestDuplicateProfileEvent;
        public event Action<string>? RequestRemoveProfileEvent;
        public event Action<string>? RequestLoadProfileEvent;
        public event Action<string>? RequestBinaryFileBrowseEvent;
        public event Action<bool>? FlipBytesEvent;

        private Main guiHolder;

        private string[]? currentFilterWords;
        private string SelectedProfileID { get; set; } = "";

        public MainGUI(Main guiHolder)
        {
            this.guiHolder = guiHolder;

            UpdateProfilesList();

            AddListeners();
        }

        private void AddListeners()
        {
            guiHolder.MainButtonNewProfile.Click += OnNewProfileClicked;
            guiHolder.MainButtonDuplicateProfile.Click += OnDuplicateProfileClicked;
            guiHolder.MainButtonRemoveProfile.Click += OnRemoveProfileClicked;
            guiHolder.MainButtonFileBrowse.Click += OnBrowseClick;

            guiHolder.MainTextboxProfileFilter.TextChanged += OnFilterTextFieldChanged;
            guiHolder.MainListProfiles.SelectedIndexChanged += OnSelectionChanged;

            guiHolder.MainCheckboxFlipBytes.CheckedChanged += OnFlipBytesToggled;
        }

        #region Event Notifications

        private void OnSelectionChanged(object? sender, EventArgs e)
        {
            ListBox list = guiHolder.MainListProfiles;

            if (list.SelectedIndex == -1)
                return;

            var desiredProfileID = (string)list.Items[list.SelectedIndex];

            if (desiredProfileID == SelectedProfileID)
                return;

            SelectedProfileID = desiredProfileID;

            RequestLoadProfileEvent?.Invoke(SelectedProfileID);
        }

        private void OnFilterTextFieldChanged(object? sender, EventArgs e)
        {
            TextBox textBox = guiHolder.MainTextboxProfileFilter;

            currentFilterWords = Regex.Split(textBox.Text, @"\s+");

            UpdateProfilesList();

            if (!string.IsNullOrEmpty(SelectedProfileID) && guiHolder.MainListProfiles.Items.Contains(SelectedProfileID))
                guiHolder.MainListProfiles.SelectedItem = SelectedProfileID;
        }

        private void OnNewProfileClicked(object? sender, EventArgs e)
        {
            RequestNewProfileEvent?.Invoke();
        }

        private void OnDuplicateProfileClicked(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedProfileID))
                return;

            RequestDuplicateProfileEvent?.Invoke();
        }

        private void OnRemoveProfileClicked(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedProfileID))
                return;

            RequestRemoveProfileEvent?.Invoke(SelectedProfileID); // todo controller should call select next profile on successful remove
        }

        private void OnBrowseClick(object? sender, EventArgs e)
        {
            var filePath = AppFileHelper.OpenFileFromDialog(AppFileExtension.bin);

            if (filePath == null || !Path.Exists(filePath))
                return;

            RequestBinaryFileBrowseEvent?.Invoke(filePath);
        }

        private void OnFlipBytesToggled(object? sender, EventArgs e)
        {
            CheckBox checkBox = guiHolder.MainCheckboxFlipBytes;

            FlipBytesEvent?.Invoke(checkBox.Checked);
        }

        #endregion

        public void UpdateFilenameLabel(string filename)
        {
            guiHolder.MainLabelBinaryFilename.Text = filename;
        }

        public void UpdateProfileSelection(string newSelection)
        {
            SelectedProfileID = newSelection;

            if (!string.IsNullOrEmpty(SelectedProfileID) && guiHolder.MainListProfiles.Items.Contains(SelectedProfileID))
                guiHolder.MainListProfiles.SelectedItem = SelectedProfileID;

            guiHolder.MainButtonRemoveProfile.Enabled = !string.IsNullOrEmpty(SelectedProfileID);
            guiHolder.MainButtonDuplicateProfile.Enabled = !string.IsNullOrEmpty(SelectedProfileID);
        }

        private void UpdateProfilesList()
        {
            var profileList = guiHolder.MainListProfiles;

            profileList.Items.Clear();

            var profileManager = ServiceContainer.GetService<ProfileManager>();
            var profileIDsRef = profileManager.ProfileIDs;

            foreach (var profileID in profileIDsRef)
            {
                if (ProfileIDMatchesFilter(profileID))
                    profileList.Items.Add(profileID);
            }

            profileList.SelectedItem = SelectedProfileID;
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

        internal void LoadEditorTab()
        {
            guiHolder.MainTabControl.SelectedTab = guiHolder.MainTabControl.TabPages["EditorTabPage"];
        }

        internal void UpdateFilePreview(int startAddress, byte[] errors)
        {
            guiHolder.MainDataGridFilePreview.Rows.Clear();

            for (int i = 0; i < errors.Length; i += 2)
            {
                guiHolder.MainDataGridFilePreview.Rows.Add((startAddress + i).ToString("X"), Convert.ToHexString(errors[i..(i+2)]));
            }
        }

        internal string? GetNextProfileSelection()
        {
            ListBox list = guiHolder.MainListProfiles;

            if (list.SelectedIndex == -1 || list.Items.Count == 1)
                return null;

            var nextIndex = list.SelectedIndex + 1 == list.Items.Count ? list.SelectedIndex - 1 : list.SelectedIndex + 1;

            var desiredProfileID = (string)list.Items[nextIndex];

            return desiredProfileID;
        }

        internal void OnProfileDBChanged(string[] newManufacturers)
        {
            guiHolder.EditorDropdownManufacturer.Items.Clear();
            guiHolder.EditorDropdownManufacturer.Items.AddRange(newManufacturers);

            UpdateProfilesList();
        }
    }
}