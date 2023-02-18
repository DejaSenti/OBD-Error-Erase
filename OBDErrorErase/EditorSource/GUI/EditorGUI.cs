using System.Text.RegularExpressions;
using OBDErrorErase.EditorSource.ProfileManagement;
using OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors;
using OBDErrorErase.EditorSource.Configs;

namespace OBDErrorErase.EditorSource.GUI
{
    public class EditorGUI
    {
        public event Action? RequestNewProfileEvent;
        public event Action? RequestDuplicateProfileEvent;
        public event Action<string>? RequestRemoveProfileEvent;
        public event Action<string>? RequestLoadProfileEvent;

        public event Action<string>? RequestManufacturerNameChangeEvent;
        public event Action<string>? RequestComputerNameChangeEvent;

        public event Action<int>? RequestChangeCurrentSubprofile;
        public event Action? RequestDuplicateCurrentSubprofile;
        public event Action? RequestRemoveCurrentSubprofile;

        private readonly Main guiHolder;

        private string[]? currentFilterWords;

        private IReadOnlyList<string> profileIDsRef;

        private string SelectedProfileID = "";
        private int currentSubProfileIndex = -1;

        public EditorGUI(Main guiHolder)
        {
            this.guiHolder = guiHolder;
            AddListeners();

            UpdateAllProfileEnabledStatuses();

            guiHolder.EditorListProfiles.Sorted = true; //todo set in gui editor and remove
            guiHolder.EditorListSubprofiles.Sorted = true; //todo set in gui editor and remove
        }

        private void AddListeners()
        {
            guiHolder.EditorButtonNewProfile.Click += OnNewProfileClicked;
            guiHolder.EditorButtonDuplicateProfile.Click += OnDuplicateProfileClicked;
            guiHolder.EditorButtonRemoveProfile.Click += OnRemoveProfileClicked;

            guiHolder.EditorListProfiles.SelectedIndexChanged += OnProfileListSelectionChanged;

            guiHolder.EditorTextboxProfileFilter.TextChanged += OnFilterTextChanged;

            guiHolder.EditorDropdownManufacturer.Validated += OnManufacturerValueValidated;
            guiHolder.EditorDropdownManufacturer.KeyUp += OnManufacturerKeyUp;
            guiHolder.EditorDropdownManufacturer.SelectionChangeCommitted += OnManufacturerChangeCommitted;

            guiHolder.EditorTextBoxComputerName.Validated += OnComputerNameValidated;
            guiHolder.EditorTextBoxComputerName.KeyUp += OnComputerNameKeyUp;

            guiHolder.EditorButtonDuplicateSubProfile.Click += OnDuplicateSubProfileClicked;
            guiHolder.EditorButtonRemoveSubProfile.Click += OnRemoveSubProfileClicked;

            guiHolder.EditorListSubprofiles.SelectedIndexChanged += OnSubProfileListSelectionChanged;
        }

        #region Event Listeners

        private void OnSubProfileListSelectionChanged(object? sender, EventArgs e)
        {
            RequestChangeCurrentSubprofile?.Invoke(guiHolder.EditorListSubprofiles.SelectedIndex);
        }

        private void OnDuplicateSubProfileClicked(object? sender, EventArgs e)
        {
            RequestDuplicateCurrentSubprofile?.Invoke();
        }

        private void OnRemoveSubProfileClicked(object? sender, EventArgs e)
        {
            RequestRemoveCurrentSubprofile?.Invoke();
        }

        private void OnComputerNameValidated(object? sender, EventArgs e)
        {
            RequestComputerNameChangeEvent?.Invoke(guiHolder.EditorTextBoxComputerName.Text);
        }

        private void OnComputerNameKeyUp(object? sender, KeyEventArgs e)
        {
            RunIfEnterKey(e.KeyCode, () => RequestComputerNameChangeEvent?.Invoke(guiHolder.EditorTextBoxComputerName.Text));
        }

        private void OnManufacturerValueValidated(object? sender, EventArgs e)
        {
            RequestManufacturerNameChangeEvent?.Invoke(guiHolder.EditorDropdownManufacturer.Text);
        }

        private void OnManufacturerKeyUp(object? sender, KeyEventArgs e)
        {
            RunIfEnterKey(e.KeyCode, () => RequestManufacturerNameChangeEvent?.Invoke(guiHolder.EditorDropdownManufacturer.Text));
        }

        private void RunIfEnterKey(Keys keyCode, Action method)
        {
            if (keyCode == Keys.Enter || keyCode == Keys.Return)
                method.Invoke();
        }

        private void OnManufacturerChangeCommitted(object? sender, EventArgs e)
        {
            RequestManufacturerNameChangeEvent?.Invoke((string)guiHolder.EditorDropdownManufacturer.SelectedItem);
        }

        private void OnProfileListSelectionChanged(object? sender, EventArgs e)
        {
            if (guiHolder.EditorListProfiles.SelectedIndex == -1)
                return;

            var desiredProfileID = (string)guiHolder.EditorListProfiles.Items[guiHolder.EditorListProfiles.SelectedIndex];

            if (desiredProfileID == SelectedProfileID)
                return;

            UpdateAllProfileEnabledStatuses();

            RequestLoadProfileEvent?.Invoke(desiredProfileID);
        }

        private void OnNewProfileClicked(object? sender, EventArgs e)
        {
            RequestNewProfileEvent?.Invoke();
        }

        private void OnRemoveProfileClicked(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SelectedProfileID))
                RequestRemoveProfileEvent?.Invoke(SelectedProfileID);
        }

        private void OnDuplicateProfileClicked(object? sender, EventArgs e)
        {
            RequestDuplicateProfileEvent?.Invoke();
        }

        private void OnFilterTextChanged(object? sender, EventArgs e)
        {
            currentFilterWords = Regex.Split(guiHolder.EditorTextboxProfileFilter.Text, @"\s+");

            UpdateProfilesList();

            if (!string.IsNullOrEmpty(SelectedProfileID) && guiHolder.EditorListProfiles.Items.Contains(SelectedProfileID))
                guiHolder.EditorListProfiles.SelectedItem = SelectedProfileID;
        }

        #endregion

        #region External notifications

        internal void OnCurrentProfileChanged(Profile currentProfile)
        {
            SelectedProfileID = currentProfile.ID;
            guiHolder.EditorTextBoxComputerName.Text = currentProfile.Name;
            guiHolder.EditorDropdownManufacturer.Text = currentProfile.Manufacturer;

            UpdateSubProfilesList(currentProfile.Subprofiles);
            UpdateProfilesList();
            UpdateAllProfileEnabledStatuses();
        }

        public void OnCurrentSubprofileChanged(int newIndex)
        {
            currentSubProfileIndex = newIndex;
            guiHolder.EditorListSubprofiles.SelectedIndex = newIndex;

            UpdateAllProfileEnabledStatuses();
        }

        public void OnProfileRemoved()
        {
            SelectedProfileID = "";

            UpdateAllProfileEnabledStatuses();
        }

        public void OnProfileDBChanged(string[] newManufacturers)
        {
            guiHolder.EditorDropdownManufacturer.Items.Clear();
            guiHolder.EditorDropdownManufacturer.Items.AddRange(newManufacturers);

            UpdateProfilesList();
            UpdateAllProfileEnabledStatuses();
        }

        #endregion

        public void SetProfileIDsRef(IReadOnlyList<string> profileIDs)
        {
            profileIDsRef = profileIDs;
        }

        public void SetProfileEditorGUI(IProfileEditorGUI profileEditorGUI)
        {
            //todo implement
        }

        public void UpdateSubProfilesList(IReadOnlyList<SubprofileData> subprofiles)
        {
            guiHolder.EditorListSubprofiles.Items.Clear();

            for (int i = 0; i < subprofiles.Count; i++)
            {
                var visualName = string.Format(ProfileStrings.SUBPROFILE_VISUAL_FORMAT, i);
                guiHolder.EditorListSubprofiles.Items.Add(visualName);
            }
        }

        private void UpdateProfilesList()
        {
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

        private void UpdateAllProfileEnabledStatuses()
        {
            guiHolder.EditorButtonRemoveProfile.Enabled = !string.IsNullOrEmpty(SelectedProfileID);
            guiHolder.EditorButtonDuplicateProfile.Enabled = !string.IsNullOrEmpty(SelectedProfileID);
            guiHolder.EditorButtonDuplicateSubProfile.Enabled = !string.IsNullOrEmpty(SelectedProfileID) && currentSubProfileIndex > -1;
            guiHolder.EditorButtonRemoveSubProfile.Enabled = !string.IsNullOrEmpty(SelectedProfileID) && currentSubProfileIndex > 0;
        }

        internal void OnCurrentBinaryFileChanged(string path)
        {
            //todo implement
        }
    }
}