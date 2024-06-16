using OBDErrorErase.EditorSource.ProfileManagement;
using OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors;
using OBDErrorErase.EditorSource.Configs;
using OBDErrorErase.EditorSource.Utils;

namespace OBDErrorErase.EditorSource.GUI
{
    public class EditorGUI
    {
        public event Action<ProfileType>? RequestProfileTypeChangeEvent;
        public event Action<int>? RequestFillSubprofileData;

        public event Action<int>? RequestChangeCurrentSubprofile;
        public event Action? RequestDuplicateCurrentSubprofile;
        public event Action? RequestRemoveCurrentSubprofile;

        public event Action? RequestSaveCurrentProfile;

        private readonly Main guiHolder;

        public EditorGUI(Main guiHolder)
        {
            this.guiHolder = guiHolder;

            AddListeners();

            guiHolder.EditorComboBoxProfileType.Items.AddRange(Enum.GetNames<ProfileType>());
            guiHolder.EditorComboBoxProfileType.SelectedIndex = 0;
        }

        private void AddListeners()
        {
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

        #endregion

        #region External notifications

        public void OnCurrentProfileChanged(Profile currentProfile)
        {
            guiHolder.EditorTextBoxComputerName.Text = currentProfile.Name;
            guiHolder.EditorDropdownManufacturer.Text = currentProfile.Manufacturer;

            guiHolder.EditorComboBoxProfileType.SelectedIndex = (int)currentProfile.Type;

            UpdateSubprofilesList(currentProfile.Subprofiles);

            RequestFillSubprofileData?.Invoke(0);
        }

        public void OnCurrentSubprofileChanged(int newIndex)
        {
            guiHolder.EditorListSubprofiles.SelectedIndex = newIndex;

            RequestFillSubprofileData?.Invoke(newIndex);
        }

        public void OnProfileDBChanged(string[] newManufacturers)
        {
            guiHolder.EditorDropdownManufacturer.Items.Clear();
            guiHolder.EditorDropdownManufacturer.Items.AddRange(newManufacturers);
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

        public void ClearFields()
        {
            guiHolder.EditorDropdownManufacturer.Text = string.Empty;
            guiHolder.EditorTextBoxComputerName.Text = string.Empty;
            guiHolder.EditorComboBoxProfileType.SelectedIndex = -1;
            UpdateSubprofilesList(new List<SubprofileData>());
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