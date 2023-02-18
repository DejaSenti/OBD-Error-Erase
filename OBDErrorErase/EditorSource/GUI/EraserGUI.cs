using System.Resources.Extensions;
using System.Windows.Forms.Layout;

namespace OBDErrorErase.EditorSource.GUI
{
    public class EraserGUI
    {
        public event Action<int>? PresetDeleteClicked;
        public event Action<int>? PresetOpenClicked;
        public event Action PresetListRefreshClicked;

        private readonly Main guiHolder;

        private List<ErrorPresetControl> presets;

        public EraserGUI(Main guiHolder)
        {
            this.guiHolder = guiHolder;

            guiHolder.EraserButtonRefreshPresetList.Click += OnRefreshPresetListClick;
        }

        private void OnRefreshPresetListClick(object? sender, EventArgs e)
        {
            PresetListRefreshClicked.Invoke();
        }

        // listen to GUI events
        // dispatch app events
        public void PopulateErrorPresetList(List<string> names)
        {
            guiHolder.EraserTableLayoutErrorPresets.Controls.Clear();
            guiHolder.EraserTableLayoutErrorPresets.RowStyles.Clear()
                ;
            guiHolder.EraserTableLayoutErrorPresets.RowCount = names.Count;

            presets = new List<ErrorPresetControl>();

            for (int i = 0; i < names.Count; ++i)
            {
                var control = new ErrorPresetControl(names[i], i);

                guiHolder.EraserTableLayoutErrorPresets.Controls.Add(control);
                guiHolder.EraserTableLayoutErrorPresets.SetRow(control, i);
                guiHolder.EraserTableLayoutErrorPresets.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                control.OpenClicked += OnErrorPresetOpenClicked;
                control.DeleteClicked += OnErrorPresetDeleteClicked;

                presets.Add(control);
            }
        }

        private void OnErrorPresetDeleteClicked(ErrorPresetControl control)
        {
            guiHolder.EraserTableLayoutErrorPresets.Controls.Remove(control);

            PresetDeleteClicked?.Invoke(control.ID);
        }

        private void OnErrorPresetOpenClicked(int id)
        {
            PresetOpenClicked?.Invoke(id);
        }

        internal void OnCurrentBinaryFileChanged(string path)
        {
            throw new NotImplementedException();
        }

        internal List<string> GetPresetPathList()
        {
            return new List<string> { "C:\\Work\\Binary Files\\preset1.txt", "C:\\Work\\Binary Files\\preset2.txt", "C:\\Work\\Binary Files\\preset3.txt" };
        }

        internal string GetTextboxErrorList()
        {
            return "5000, 1000, 9080";
        }
    }
}