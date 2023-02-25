using OBDErrorErase.EditorSource.Configs;
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

        private Main guiHolder;

        private string[]? currentFilterWords;
        private string SelectedProfileID { get; set; } = "";

        private IReadOnlyList<string> profileIDsRef;

        public MainGUI(Main guiHolder, IReadOnlyList<string> profileIDsRef)
        {
            this.guiHolder = guiHolder;
            this.profileIDsRef = profileIDsRef;

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

            // TODO call this only from the controller on successful profile load!
            // UpdateAllProfileEnabledStatuses(); 
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
            if (string.IsNullOrEmpty(SelectedProfileID))
                return;

            RequestNewProfileEvent?.Invoke(); // todo controller should call select on newly created profile
        }

        private void OnDuplicateProfileClicked(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedProfileID))
                return;

            RequestDuplicateProfileEvent?.Invoke(); // todo controller should call select on newly created profile
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

            RequestBinaryFileBrowseEvent?.Invoke(filePath); // controller should call update filename label on successful load
        }

        #endregion

        private void UpdateAllProfileEnabledStatuses()
        {
            guiHolder.MainButtonRemoveProfile.Enabled = !string.IsNullOrEmpty(SelectedProfileID);
            guiHolder.MainButtonDuplicateProfile.Enabled = !string.IsNullOrEmpty(SelectedProfileID);
        }

        private void UpdateProfilesList()
        {
            var profileList = guiHolder.MainListProfiles;

            profileList.Items.Clear();

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
    }
}