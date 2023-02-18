using System;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using OBDErrorErase.EditorSource.ProfileManagement;
using OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors;

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

        private readonly Main guiHolder;

        private string[]? currentFilterWords;

        private IReadOnlyList<string> profileIDsRef;

        private string SelectedProfileID = "";

        public EditorGUI(Main guiHolder)
        {
            this.guiHolder = guiHolder;
            AddListeners();
            UpdateRemoveProfileButtonEnabled();
            UpdateDuplicateProfileButtonEnabled();

            guiHolder.EditorListProfiles.Sorted = true; //todo set in gui editor and remove
        }

        private void AddListeners()
        {
            guiHolder.EditorButtonNewProfile.Click += OnNewProfileClicked;
            guiHolder.EditorButtonProfileRemove.Click += OnRemoveProfileClicked;
            guiHolder.EditorButtonDuplicateProfile.Click += OnDuplicateProfileClicked;

            guiHolder.EditorListProfiles.SelectedIndexChanged += OnProfileListSelectionChanged;

            guiHolder.EditorTextboxProfileFilter.TextChanged += OnFilterTextChanged;

            guiHolder.EditorDropdownManufacturer.Validated += OnManufacturerValueValidated;
            guiHolder.EditorDropdownManufacturer.KeyUp += OnManufacturerKeyUp;
            guiHolder.EditorDropdownManufacturer.SelectionChangeCommitted += OnManufacturerChangeCommitted;

            guiHolder.EditorTextBoxComputerName.Validated += OnComputerNameValidated;
            guiHolder.EditorTextBoxComputerName.KeyUp += OnComputerNameKeyUp;
        }

        #region Event Listeners

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
            var desiredProfileID = (string)guiHolder.EditorListProfiles.Items[guiHolder.EditorListProfiles.SelectedIndex];

            if (desiredProfileID == SelectedProfileID)
                return;

            UpdateRemoveProfileButtonEnabled();
            UpdateDuplicateProfileButtonEnabled();

            RequestLoadProfileEvent?.Invoke(desiredProfileID);
        }

        #endregion

        #region External notifications

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

        internal void OnCurrentProfileChanged(Profile currentProfile)
        {
            SelectedProfileID = currentProfile.ID;
            guiHolder.EditorTextBoxComputerName.Text = currentProfile.Name;
            guiHolder.EditorDropdownManufacturer.Text = currentProfile.Manufacturer;

            UpdateProfilesList();
        }

        public void OnProfileRemoved()
        {
            SelectedProfileID = "";

            UpdateRemoveProfileButtonEnabled();
            UpdateDuplicateProfileButtonEnabled();
        }

        public void OnProfileDBChanged(string[] newManufacturers)
        {
            guiHolder.EditorDropdownManufacturer.Items.Clear();
            guiHolder.EditorDropdownManufacturer.Items.AddRange(newManufacturers);

            UpdateProfilesList();
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

        private void UpdateRemoveProfileButtonEnabled() => guiHolder.EditorButtonProfileRemove.Enabled = !string.IsNullOrEmpty(SelectedProfileID);
        private void UpdateDuplicateProfileButtonEnabled() => guiHolder.EditorButtonProfileRemove.Enabled = !string.IsNullOrEmpty(SelectedProfileID);


        internal void OnCurrentBinaryFileChanged(string path)
        {
            //todo implement
        }
    }
}