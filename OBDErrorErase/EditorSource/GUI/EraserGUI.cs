namespace OBDErrorErase.EditorSource.GUI
{
    public class EraserGUI
    {
        private readonly string PROCESS_RESULT_DISPLAY = "Deleted: {0} / {1}";
        
        public event Action<int>? PresetDeleteRequested;
        public event Action<int>? PresetOpenClicked;
        public event Action? PresetListRefreshClicked;
        public event Action? RunClicked;

        private readonly Main guiHolder;
        private List<ErrorPresetControl> presetControls;
        private List<MapSelectControl> mapControls;

        public EraserGUI(Main guiHolder)
        {
            this.guiHolder = guiHolder;

            AddGUIListeners();
        }

        private void AddGUIListeners()
        {
            guiHolder.EraserButtonRefreshPresetList.Click += OnRefreshPresetListClick;
            guiHolder.EraserButtonRun.Click += OnRunClick;
            guiHolder.EraserCheckBoxSelectAllMaps.CheckedChanged += OnSelectAllMapsToggle;
            guiHolder.EraserCheckBoxSelectAllPresets.CheckedChanged += OnSelectAllPresetsToggle;
        }

#region Event Notifications

        private void OnSelectAllPresetsToggle(object? sender, EventArgs e)
        {
            bool value = guiHolder.EraserCheckBoxSelectAllPresets.Checked;

            foreach (var presetControl in presetControls)
            {
                presetControl.Checkbox.Checked = value;
            }
        }

        private void OnSelectAllMapsToggle(object? sender, EventArgs e)
        {
            bool value = guiHolder.EraserCheckBoxSelectAllMaps.Checked;

            foreach (var mapControl in mapControls)
            {
                mapControl.Checkbox.Checked = value;
            }
        }

        private void OnRunClick(object? sender, EventArgs e)
        {
            RunClicked?.Invoke();
        }

        private void OnRefreshPresetListClick(object? sender, EventArgs e)
        {
            PresetListRefreshClicked?.Invoke();
        }

#endregion

        public void PopulateMapList(List<string> names)
        {
            var layout = guiHolder.EraserTableLayoutMapSelector;

            layout.Controls.Clear();
            layout.RowStyles.Clear();

            layout.RowCount = names.Count;

            mapControls = new List<MapSelectControl>();

            for (int i = 0; i < names.Count; ++i)
            {
                var control = new MapSelectControl(names[i], i);

                layout.Controls.Add(control);
                layout.SetRow(control, i);
                layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                mapControls.Add(control);
            }
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

            presetControls = new List<ErrorPresetControl>();

            for (int i = 0; i < names.Count; ++i)
            {
                var control = new ErrorPresetControl(names[i], i);

                layout.Controls.Add(control);
                layout.SetRow(control, i);
                layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                control.OpenClicked += OnErrorPresetOpenClicked;
                control.DeleteClicked += OnErrorPresetDeleteClicked;

                presetControls.Add(control);
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

        internal List<int> GetMapIndices()
        {
            var result = new List<int>();

            foreach (var mapControl in mapControls)
            {
                if (mapControl.Checkbox.Checked)
                    result.Add(mapControl.ID);
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
    }
}