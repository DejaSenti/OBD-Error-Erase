using OBDErrorErase.EditorSource.AppControl;
using OBDErrorErase.EditorSource.Configs;
using OBDErrorErase.EditorSource.FileManagement;
using OBDErrorErase.EditorSource.ProfileManagement;
using OBDErrorErase.EditorSource.Utils;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace OBDErrorErase.EditorSource.GUI
{
    public class EraserGUI
    {
        private readonly string PROCESS_RESULT_DISPLAY = "Deleted: {0} / {1}";
        private readonly int FILE_PREVIEW_LENGTH = 30;
        
        public event Action<int>? PresetDeleteRequested;
        public event Action<int>? PresetOpenClicked;
        public event Action? PresetListRefreshClicked;
        public event Action? RunClicked;
        public event Action<string>? BinaryFileBrowse;
        public event Action<string>? RequestLoadProfileEvent;

        private ProfileListController profileListController;
        private readonly Main guiHolder;
        private List<ErrorPresetControl> presets;
        private List<string> loadedProfileMapNames = new();

        public EraserGUI(Main guiHolder)
        {
            this.guiHolder = guiHolder;
            profileListController = ServiceContainer.GetService<ProfileListController>();

            profileListController.SubscribeControls(guiHolder.MainTextboxProfileFilter, guiHolder.MainListProfiles, OnProfileSelectionChanged);

            AddGUIListeners();
        }

        private void OnProfileSelectionChanged()
        {
            RequestLoadProfileEvent?.Invoke(profileListController.SelectedProfileID);
        }

        private void AddGUIListeners()
        {
            guiHolder.EraserButtonRefreshPresetList.Click += OnRefreshPresetListClick;
            guiHolder.EraserButtonRun.Click += OnRunClick;
            guiHolder.MainButtonFileBrowse.Click += OnBrowseClick;
        }

        private void OnBrowseClick(object? sender, EventArgs e) // todo tie to a binary file browse controller thing
        {
            var filePath = AppFileHelper.OpenFileFromDialog(AppFileExtension.bin);
            BinaryFileBrowse?.Invoke(filePath);
        }

        private void OnRunClick(object? sender, EventArgs e)
        {
            RunClicked?.Invoke();
        }

        private void OnRefreshPresetListClick(object? sender, EventArgs e)
        {
            PresetListRefreshClicked?.Invoke();
        }

        public void PopulateErrorPresetList(List<string> names)
        {
            var layout = guiHolder.EraserTableLayoutErrorPresets;

            foreach (ErrorPresetControl control in layout.Controls)
            {
                control.OpenClicked -= OnErrorPresetOpenClicked;
                control.DeleteClicked -= OnErrorPresetDeleteClicked;
            }

            layout.Controls.Clear();
            layout.RowStyles.Clear();
            
            layout.RowCount = names.Count;

            presets = new List<ErrorPresetControl>();

            for (int i = 0; i < names.Count; ++i)
            {
                var control = new ErrorPresetControl(names[i], i);

                layout.Controls.Add(control);
                layout.SetRow(control, i);
                layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                control.OpenClicked += OnErrorPresetOpenClicked;
                control.DeleteClicked += OnErrorPresetDeleteClicked;

                presets.Add(control);
            }
        }

        private void OnErrorPresetDeleteClicked(ErrorPresetControl control)
        {
            var confirmResult = MessageBox.Show("This will delete the preset file! No undo! Are you sure?", "Confirm error preset delete.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                guiHolder.EraserTableLayoutErrorPresets.Controls.Remove(control);

                PresetDeleteRequested?.Invoke(control.ID);
            }
        }

        private void OnErrorPresetOpenClicked(int id)
        {
            PresetOpenClicked?.Invoke(id);
        }

        internal void OnCurrentBinaryFileChanged(string path)
        {
            guiHolder.MainLabelBinaryFilename.Text = path;
        }

        internal List<int> GetSelectedPresetIDs()
        {
            var result = new List<int>();

            foreach (ErrorPresetControl control in guiHolder.EraserTableLayoutErrorPresets.Controls)
            {
                if (control.Checkbox.Checked)
                    result.Add(control.ID);
            }

            return result;
        }

        internal string GetTextboxErrorList()
        {
            return guiHolder.EraserTextboxErrorList.Text;
        }

        internal void OnProcessComplete(int totalErased, int count)
        {
            guiHolder.EraserLabelErrorCounter.Text = string.Format(PROCESS_RESULT_DISPLAY, totalErased, count);
        }

        internal void OnInvalidErasingAttempt()
        {
            MessageBox.Show("Cannot process!\rCheck that you loaded a file, selected a profile, and have errors you want to erase!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal void OnSubprofileUpdate(BinaryFile? currentFile, SubprofileData? subprofile)
        {
            if (currentFile == null || subprofile == null)
                return;

            loadedProfileMapNames.Clear();

            foreach (var map in subprofile.Maps)
            {
                loadedProfileMapNames.Add(map.Name);
            }

            UpdateMapSelector();

            // todo tie to file preview controller

            // get this out of here
            var displayMapLocation = currentFile.FindValue(subprofile.Maps[0].SearchWord, 0, currentFile.Length);
            var displayBytes = currentFile.ReadValue(displayMapLocation, FILE_PREVIEW_LENGTH);

            AppHelper.PreviewFile(guiHolder.MainDataGridErrorPreview, displayMapLocation, displayBytes);
        }

        private void UpdateMapSelector()
        {
            // todo implement
        }

        internal List<int> GetMapIndices()
        {
            var result = new List<int>();
            // todo implement

            return result;
        }
    }
}