using OBDErrorErase.EditorSource.ProfileManagement;
using OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors;
using OBDErrorErase.EditorSource.Configs;
using OBDErrorErase.EditorSource.Utils;

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

        public event Action? RequestSaveCurrentProfile;

        private readonly Main guiHolder;

        private int currentSubProfileIndex = -1;

        public EditorGUI(Main guiHolder)
        {
            this.guiHolder = guiHolder;

            AddListeners();

            guiHolder.EditorComboBoxProfileType.Items.AddRange(Enum.GetNames<ProfileType>());
            guiHolder.EditorComboBoxProfileType.SelectedIndex = 0;

            guiHolder.EditorButtonSaveProfile.Enabled = false;

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

            guiHolder.EditorButtonSaveProfile.Click += OnSaveProfileClicked;
        }

        #region Event Listeners

        private void OnSaveProfileClicked(object? sender, EventArgs e)
        {
            RequestSaveCurrentProfile?.Invoke();
        }

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
            AppHelper.RunIfEnterKey(e.KeyCode, () => RequestComputerNameChangeEvent?.Invoke(guiHolder.EditorTextBoxComputerName.Text));
        }

        private void OnManufacturerValueValidated(object? sender, EventArgs e)
        {
            RequestManufacturerNameChangeEvent?.Invoke(guiHolder.EditorDropdownManufacturer.Text);
        }

        private void OnManufacturerKeyUp(object? sender, KeyEventArgs e)
        {
            AppHelper.RunIfEnterKey(e.KeyCode, () => RequestManufacturerNameChangeEvent?.Invoke(guiHolder.EditorDropdownManufacturer.Text));
        }

        private void OnManufacturerChangeCommitted(object? sender, EventArgs e)
        {
            RequestManufacturerNameChangeEvent?.Invoke((string)guiHolder.EditorDropdownManufacturer.SelectedItem);
        }

        #endregion

        #region External notifications

        public void OnCurrentProfileChanged(Profile currentProfile)
        {
            if (currentProfile == null)
            {
                guiHolder.EditorButtonSaveProfile.Enabled = false;
                return;
            }

            guiHolder.EditorButtonSaveProfile.Enabled = true;

            guiHolder.EditorTextBoxComputerName.Text = currentProfile.Name;
            guiHolder.EditorDropdownManufacturer.Text = currentProfile.Manufacturer;

            guiHolder.EditorComboBoxProfileType.SelectedIndex = (int)currentProfile.Type;

            UpdateSubprofilesList(currentProfile.Subprofiles);

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
            UpdateAllProfileEnabledStatuses();
        }

        public void OnProfileDBChanged(string[] newManufacturers)
        {
            guiHolder.EditorDropdownManufacturer.Items.Clear();
            guiHolder.EditorDropdownManufacturer.Items.AddRange(newManufacturers);

            UpdateAllProfileEnabledStatuses();
        }

        #endregion

        public void SetProfileEditorGUI(IProfileEditorGUI profileEditorGUI)
        {
            var control = profileEditorGUI.UserControl;

            if (control == null)
                return;

            var frame = guiHolder.EditorPanelEditFrame;

            frame.Controls.Add(control);
            control.Parent = frame;
        }

        public void UpdateSubprofilesList(IReadOnlyList<SubprofileData> subprofiles)
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
            guiHolder.EditorButtonDuplicateSubProfile.Enabled = currentSubProfileIndex > -1;
            guiHolder.EditorButtonRemoveSubProfile.Enabled = guiHolder.EditorListSubprofiles.Items.Count > 1;
        }

        public void ClearFields()
        {
            guiHolder.EditorDropdownManufacturer.Text = string.Empty;
            guiHolder.EditorTextBoxComputerName.Text = string.Empty;
            guiHolder.EditorComboBoxProfileType.SelectedIndex = -1;
            UpdateSubprofilesList(new List<SubprofileData>());
            UpdateAllProfileEnabledStatuses();
        }

        public int GetNextSubprofileIndex()
        {
            var list = guiHolder.EditorListSubprofiles;

            if (list.SelectedIndex == -1 || list.Items.Count == 1)
                return -1;

            var nextIndex = list.SelectedIndex + 1 == list.Items.Count ? list.SelectedIndex - 1 : list.SelectedIndex;

            return nextIndex;
        }
    }
}