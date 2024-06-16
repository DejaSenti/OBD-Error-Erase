using OBDErrorErase.EditorSource.AppControl;
using OBDErrorErase.EditorSource.Configs;
using OBDErrorErase.EditorSource.ProfileManagement;
using OBDErrorErase.EditorSource.Utils;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace OBDErrorErase
{
    public partial class Main
    {
        public event Action? RequestNewProfileEvent;
        public event Action? RequestDuplicateProfileEvent;
        public event Action<string>? RequestRemoveProfileEvent;
        public event Action<string>? RequestLoadProfileEvent;
        public event Action<string>? RequestBinaryFileBrowseEvent;
        public event Action<bool>? FlipBytesEvent;

        private string[]? currentFilterWords;
        public string SelectedProfileID { get; set; } = "";

        public void InitGUI()
        {
            UpdateProfilesList();

            AddListeners();
        }

        private void AddListeners()
        {
            MainButtonNewProfile.Click += OnNewProfileClicked;
            MainButtonDuplicateProfile.Click += OnDuplicateProfileClicked;
            MainButtonRemoveProfile.Click += OnRemoveProfileClicked;
            MainButtonFileBrowse.Click += OnBrowseClick;
            MainButtonFileBrowse.DragDrop += OnDragDrop;
            MainButtonFileBrowse.DragEnter += OnDragEnter;

            MainTextboxProfileFilter.TextChanged += OnFilterTextFieldChanged;
            MainListProfiles.SelectedIndexChanged += OnSelectionChanged;

            MainCheckboxFlipBytes.CheckedChanged += OnFlipBytesToggled;
        }

        #region Event Notifications

        private void OnSelectionChanged(object? sender, EventArgs e)
        {
            ListBox list = MainListProfiles;

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
            TextBox textBox = MainTextboxProfileFilter;

            currentFilterWords = GenRegex().Split(textBox.Text);

            UpdateProfilesList();

            if (!string.IsNullOrEmpty(SelectedProfileID) && MainListProfiles.Items.Contains(SelectedProfileID))
                MainListProfiles.SelectedItem = SelectedProfileID;
        }

        private void OnNewProfileClicked(object? sender, EventArgs e)
        {
            Debug.WriteLine("New Profile Clicked");

            RequestNewProfileEvent?.Invoke();
        }

        private void OnDuplicateProfileClicked(object? sender, EventArgs e)
        {
            Debug.WriteLine("Duplicate Profile Clicked");

            if (string.IsNullOrEmpty(SelectedProfileID))
                return;

            RequestDuplicateProfileEvent?.Invoke();
        }

        private void OnRemoveProfileClicked(object? sender, EventArgs e)
        {
            Debug.WriteLine("Remove Profile Clicked");

            if (string.IsNullOrEmpty(SelectedProfileID))
                return;

            RequestRemoveProfileEvent?.Invoke(SelectedProfileID);
        }

        private void OnBrowseClick(object? sender, EventArgs e)
        {
            Debug.WriteLine("Browse Clicked");

            var filePath = AppFileHelper.OpenFileFromDialog(AppFileExtension.bin);

            if (filePath == null || !Path.Exists(filePath))
                return;

            RequestBinaryFileBrowseEvent?.Invoke(filePath);
        }

        private void OnDragEnter(object? sender, DragEventArgs e)
        {
            Debug.WriteLine("Dragged New File");

            if (!(e.Data?.GetDataPresent(DataFormats.FileDrop) ?? false))
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            e.Effect = DragDropEffects.Copy;
        }

        private void OnDragDrop(object? sender, DragEventArgs e)
        {
            Debug.WriteLine("Dropped New File");

            if (!(e.Data?.GetDataPresent(DataFormats.FileDrop) ?? false))
            {
                return;
            }

            string[]? files = (string[]?)e.Data.GetData(DataFormats.FileDrop);

            if (files == null || files.Length == 0) 
            { 
                return; 
            }

            string filePath = files[0];
            Debug.WriteLine("Path is " + filePath);

            RequestBinaryFileBrowseEvent?.Invoke(filePath);
        }

        private void OnFlipBytesToggled(object? sender, EventArgs e)
        {
            Debug.WriteLine("Flip Bytes Toggled");

            CheckBox checkBox = MainCheckboxFlipBytes;

            FlipBytesEvent?.Invoke(checkBox.Checked);
        }

        #endregion

        public void UpdateFilenameLabel(string filename)
        {
            MainLabelBinaryFilename.Text = filename;
        }

        public void UpdateProfileSelection(string newSelection)
        {
            if (string.IsNullOrEmpty(newSelection) || !MainListProfiles.Items.Contains(newSelection))
                return;

            SelectedProfileID = newSelection;

            MainListProfiles.SelectedItem = SelectedProfileID;
        }

        public void UpdateProfilesList()
        {
            MainListProfiles.Items.Clear();

            var profileManager = ServiceContainer.GetService<ProfileManager>();

            foreach (var profileID in profileManager.ProfileIDs)
            {
                if (ProfileIDMatchesFilter(profileID))
                    MainListProfiles.Items.Add(profileID);
            }

            MainListProfiles.Sorted = true;

            MainListProfiles.SelectedItem = SelectedProfileID;
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

        public void LoadEditorTab()
        {
            MainTabControl.SelectedTab = MainTabControl.TabPages[NAME_ERASER_TAB_PAGE];
        }

        public void UpdateFilePreview(int startAddress, int valueSize, byte[][] errors)
        {
            ClearFilePreview();

            for (int i = 0; i < errors.Length; ++i)
            {
                MainDataGridFilePreview.Rows.Add((startAddress + i * valueSize).ToString("X"), Convert.ToHexString(errors[i]));
            }
        }

        public string GetNextProfileSelection()
        {
            ListBox list = MainListProfiles;

            if (list.SelectedIndex == -1 || list.Items.Count == 1)
                return "";

            var nextIndex = list.SelectedIndex + 1 == list.Items.Count ? list.SelectedIndex - 1 : list.SelectedIndex + 1;

            var desiredProfileID = (string)list.Items[nextIndex];

            return desiredProfileID;
        }

        public void UpdateManufacturerList()
        {
            throw new NotImplementedException();
        }

        public void ClearFields()
        {
            MainListProfiles.SelectedIndex = -1;

            ClearFilePreview();
        }

        public void ClearFilePreview()
        {
            MainDataGridFilePreview.Rows.Clear();
        }

        [GeneratedRegex("\\s+")]
        private static partial Regex GenRegex();
    }
}