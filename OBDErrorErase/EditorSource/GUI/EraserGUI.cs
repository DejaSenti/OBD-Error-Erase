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

            mapControls = new List<MapSelectControl>();
            presetControls = new List<ErrorPresetControl>();

            AddGUIListeners();

            SetEraseButtonEnabled(false);
        }

        private void AddGUIListeners()
        {
            guiHolder.EraserButtonRefreshPresetList.Click += OnRefreshPresetListClick;
            guiHolder.EraserButtonRun.Click += OnRunClick;
            guiHolder.EraserCheckBoxSelectAllMaps.CheckedChanged += OnSelectAllMapsToggle;
        }

#region Event Notifications

        private void OnSelectAllMapsToggle(object? sender, EventArgs e)
        {
            SetAllCheckboxes(mapControls, guiHolder.EraserCheckBoxSelectAllMaps);
        }

        private void OnRunClick(object? sender, EventArgs e)
        {
            RunClicked?.Invoke();
        }

        private void OnRefreshPresetListClick(object? sender, EventArgs e)
        {
            PresetListRefreshClicked?.Invoke();
        }

        private void OnMapCheckboxChanged(object? sender, EventArgs e)
        {
            SetSelectAllCheckboxState(mapControls, guiHolder.EraserCheckBoxSelectAllMaps);
        }

        #endregion

        private void SetAllCheckboxes<T>(List<T> controlList, CheckBox selectAll) where T : ICheckboxControl
        {
            bool value = false;
            switch (selectAll.CheckState)
            {
                case CheckState.Unchecked:
                    break;
                case CheckState.Indeterminate:
                    return;
                case CheckState.Checked:
                default:
                    value = true;
                    break;
            }

            foreach (T control in controlList)
            {
                control.CheckBox.Checked = value;
            }
        }

        public void PopulateMapList(List<string> names)
        {
            ClearMapControls();

            var layout = guiHolder.EraserTableLayoutMapSelector;

            layout.RowCount = names.Count;

            for (int i = 0; i < names.Count; ++i)
            {
                var control = new MapSelectControl(names[i], i);

                layout.Controls.Add(control);
                layout.SetRow(control, i);
                layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                mapControls.Add(control);
                control.Checkbox.CheckedChanged += OnMapCheckboxChanged;
            }

            guiHolder.EraserCheckBoxSelectAllMaps.Checked = true;
        }

        public void PopulateErrorPresetList(List<string> names)
        {
            ClearPresetControls();

            var layout = guiHolder.EraserTableLayoutErrorPresets;
            
            layout.RowCount = names.Count;

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

        public List<int> GetSelectedPresetIDs()
        {
            var result = new List<int>();

            foreach (ErrorPresetControl control in guiHolder.EraserTableLayoutErrorPresets.Controls)
            {
                if (control.Checkbox.Checked)
                    result.Add(control.ID);
            }

            return result;
        }

        public List<int> GetMapIndices()
        {
            var result = new List<int>();

            foreach (var mapControl in mapControls)
            {
                if (mapControl.Checkbox.Checked)
                    result.Add(mapControl.ID);
            }

            return result;
        }

        public string GetTextboxErrorList()
        {
            return guiHolder.EraserTextboxErrorList.Text;
        }

        public void OnProcessComplete(int totalErased, int count)
        {
            guiHolder.EraserLabelErrorCounter.Text = string.Format(PROCESS_RESULT_DISPLAY, totalErased, count);
        }

        public void OnInvalidErasingAttempt()
        {
            MessageBox.Show("Cannot process!\rCheck that you loaded a file, selected a profile, and have errors you want to erase!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClearPresetControls()
        {
            foreach (var control in presetControls)
            {
                control.OpenClicked -= OnErrorPresetOpenClicked;
                control.DeleteClicked -= OnErrorPresetDeleteClicked;
            }

            guiHolder.EraserTableLayoutErrorPresets.Controls.Clear();
            guiHolder.EraserTableLayoutErrorPresets.RowStyles.Clear();

            presetControls.Clear();
        }

        public void ClearMapControls()
        {
            foreach (var control in mapControls)
            {
                control.Checkbox.CheckedChanged -= OnMapCheckboxChanged;
            }

            guiHolder.EraserTableLayoutMapSelector.Controls.Clear();
            guiHolder.EraserTableLayoutMapSelector.RowStyles.Clear();

            guiHolder.EraserCheckBoxSelectAllMaps.Checked = false;

            mapControls.Clear();
        }

        private void SetSelectAllCheckboxState<T>(List<T> controls, CheckBox checkbox) where T : ICheckboxControl
        {
            bool allTrue = true;
            bool allFalse = true;

            foreach (var control in controls)
            {
                if (control.CheckBox.Checked && allFalse)
                {
                    allFalse = false;
                }
                else if (!control.CheckBox.Checked && allTrue)
                {
                    allTrue = false;
                }

                if (!allTrue && !allFalse)
                {
                    checkbox.CheckState = CheckState.Indeterminate;
                    return;
                }
            }

            if (allTrue)
            {
                checkbox.CheckState = CheckState.Checked;
            }
            else if (allFalse)
            {
                checkbox.CheckState = CheckState.Unchecked;
            }
            else
            {
                checkbox.CheckState = CheckState.Indeterminate;
            }
        }

        public void SetEraseButtonEnabled(bool value)
        {
            guiHolder.EraserButtonRun.Enabled = value;
        }

        public void UpdateMapSelectorStatus(bool value)
        {
            guiHolder.EraserTableLayoutMapSelector.Enabled = value;
            guiHolder.EraserCheckBoxSelectAllMaps.Enabled = value;
        }
    }
}