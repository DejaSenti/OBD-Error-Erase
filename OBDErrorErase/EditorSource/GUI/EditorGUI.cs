using OBDErrorErase.EditorSource.ProfileManagement;
using OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors;
using OBDErrorErase.EditorSource.Configs;
using OBDErrorErase.EditorSource.AppControl;
using OBDErrorErase.EditorSource.FileManagement;

namespace OBDErrorErase.EditorSource.GUI
{
    public class EditorGUI
    {
        public event Action<string>? RequestManufacturerNameChangeEvent;
        public event Action<string>? RequestComputerNameChangeEvent;

        public event Action<ProfileType>? RequestProfileTypeChangeEvent;

        public event Action<int>? RequestChangeCurrentSubprofile;
        public event Action? RequestDuplicateCurrentSubprofile;
        public event Action? RequestRemoveCurrentSubprofile;


        private readonly Main guiHolder;
        private ProfileListController profileListController;

        private int currentSubProfileIndex = -1;

        public EditorGUI(Main guiHolder)
        {
            this.guiHolder = guiHolder;

            AddListeners();

            guiHolder.EditorComboBoxProfileType.Items.AddRange(Enum.GetNames<ProfileType>());
            guiHolder.EditorComboBoxProfileType.SelectedIndex = 0;

            UpdateAllProfileEnabledStatuses();
        }

        private void AddListeners()
        {

            guiHolder.EditorDropdownManufacturer.Validated += OnManufacturerValueValidated;
            guiHolder.EditorDropdownManufacturer.KeyUp += OnManufacturerKeyUp;
            guiHolder.EditorDropdownManufacturer.SelectionChangeCommitted += OnManufacturerChangeCommitted;

            guiHolder.EditorTextBoxComputerName.Validated += OnComputerNameValidated;
            guiHolder.EditorTextBoxComputerName.KeyUp += OnComputerNameKeyUp;

            guiHolder.EditorButtonDuplicateSubProfile.Click += OnDuplicateSubProfileClicked;
            guiHolder.EditorButtonRemoveSubProfile.Click += OnRemoveSubProfileClicked;

            guiHolder.EditorListSubprofiles.SelectedIndexChanged += OnSubProfileListSelectionChanged;

            guiHolder.EditorComboBoxProfileType.SelectionChangeCommitted += OnProfileTypeChangeCommitted;

        }

        #region Event Listeners

        private void OnProfileTypeChangeCommitted(object? sender, EventArgs e)
        {
            var newProfileType = (ProfileType)guiHolder.EditorComboBoxProfileType.SelectedIndex;
            RequestProfileTypeChangeEvent?.Invoke(newProfileType);
        }

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

        #endregion

        #region External notifications

        internal void OnCurrentProfileChanged(Profile currentProfile)
        {
            profileListController.SelectedProfileID = currentProfile.ID;
            guiHolder.EditorTextBoxComputerName.Text = currentProfile.Name;
            guiHolder.EditorDropdownManufacturer.Text = currentProfile.Manufacturer;

            guiHolder.EditorComboBoxProfileType.SelectedIndex = (int)currentProfile.Type;

            UpdateSubProfilesList(currentProfile.Subprofiles);

            profileListController.UpdateProfilesList(guiHolder.MainListProfiles);

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
            profileListController.SelectedProfileID = "";

            UpdateAllProfileEnabledStatuses();
        }

        public void OnProfileDBChanged(string[] newManufacturers)
        {
            guiHolder.EditorDropdownManufacturer.Items.Clear();
            guiHolder.EditorDropdownManufacturer.Items.AddRange(newManufacturers);

            profileListController.UpdateProfilesList(guiHolder.MainListProfiles);
            UpdateAllProfileEnabledStatuses();
        }

        #endregion

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

        private void UpdateAllProfileEnabledStatuses()
        {
            guiHolder.MainButtonRemoveProfile.Enabled = !string.IsNullOrEmpty(profileListController.SelectedProfileID);
            guiHolder.MainButtonDuplicateProfile.Enabled = !string.IsNullOrEmpty(profileListController.SelectedProfileID);
            guiHolder.EditorButtonDuplicateSubProfile.Enabled = !string.IsNullOrEmpty(profileListController.SelectedProfileID) && currentSubProfileIndex > -1;
            guiHolder.EditorButtonRemoveSubProfile.Enabled = !string.IsNullOrEmpty(profileListController.SelectedProfileID) && currentSubProfileIndex > 0;
        }

        internal void OnCurrentBinaryFileChanged(BinaryFile file, string path) // todo get this out of here into some file preview controller that will work with both preview boxes
        {
            guiHolder.MainLabelBinaryFilename.Text = path;
            //todo implement

            // look at selected subprofile
            // get location of first map
            // read display bytes
            // update preview display

            //AppHelper.PreviewFile(guiHolder.EditorErrorPreview, displayMapLocation, displayBytes);
        }
    }
}