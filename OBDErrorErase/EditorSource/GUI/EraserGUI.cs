namespace OBDErrorErase.EditorSource.GUI
{
    public class EraserGUI
    {
        private readonly string PROCESS_RESULT_DISPLAY = "Deleted: {0} / {1}";
        .
        public event Action<int>? PresetDeleteClicked;
        public event Action<int>? PresetOpenClicked;
        public event Action? PresetListRefreshClicked;
        public event Action? RunClicked;

        private readonly Main guiHolder;

        private List<ErrorPresetControl> presets;

        public EraserGUI(Main guiHolder)
        {
            this.guiHolder = guiHolder;

            AddGUIListeners();
        }

        private void AddGUIListeners()
        {
            guiHolder.EraserButtonRefreshPresetList.Click += OnRefreshPresetListClick;
            guiHolder.EraserButtonRun.Click += OnRunClick;
        }

        private void OnRunClick(object? sender, EventArgs e)
        {
            RunClicked?.Invoke();
        }

        private void OnRefreshPresetListClick(object? sender, EventArgs e)
        {
            PresetListRefreshClicked?.Invoke();
        }

        // listen to GUI events
        // dispatch app events
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

                PresetDeleteClicked?.Invoke(control.ID);
            }
        }

        private void OnErrorPresetOpenClicked(int id)
        {
            PresetOpenClicked?.Invoke(id);
        }

        internal void OnCurrentBinaryFileChanged(string path)
        {
            throw new NotImplementedException();
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
            // todo: make it public and set it up properly
            guiHolder.EraserLabelErrorCounter.Text = string.Format(PROCESS_RESULT_DISPLAY, totalErased, count);
        }
    }
}