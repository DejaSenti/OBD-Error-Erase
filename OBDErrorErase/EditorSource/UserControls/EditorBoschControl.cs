using OBDErrorErase.EditorSource.Configs;
using OBDErrorErase.EditorSource.Maps;

namespace OBDErrorErase
{
    public partial class EditorBoschControl : UserControl
    {
        private const string MANUAL = "Manual";
        private readonly List<string> LENGTH_ALGORITHMS = new List<string> { MANUAL, "BMW" };

        public event Action<int>? MapRemoved;
        public event Action<int, BoschMapEditorContent>? ContentChanged;

        private List<(Button button, BoschMapEditorControl control)> controls;

        public EditorBoschControl()
        {
            InitializeComponent();

            controls = new();

            ComboBoxMapLengthAlgorithm.Items.AddRange(LENGTH_ALGORITHMS.ToArray());
            ComboBoxMapLengthAlgorithm.SelectedIndex = 0;

            ComboBoxMapLengthAlgorithm.SelectionChangeCommitted += OnLengthAlgorithmChangeCommitted;
        }

        private void OnLengthAlgorithmChangeCommitted(object? sender, EventArgs e)
        {
            TextBoxMapLength.Enabled = (ComboBoxMapLengthAlgorithm.SelectedIndex == LENGTH_ALGORITHMS.IndexOf(MANUAL));
        }

        public void AddRow(string name, string newValue)
        {
            var control = new BoschMapEditorControl(name, newValue);

            TableLayoutMaps.Controls.Add(control);
            TableLayoutMaps.SetRow(control, TableLayoutMaps.Controls.Count - 1);
            ResetRowStyles();

            control.Width.Items.AddRange(ValueWidth.WIDTH.ToArray());

            control.Address.Validated += OnContentChanged;
            control.Address.Leave += OnContentChanged;
            control.NewValue.Validated += OnContentChanged;
            control.NewValue.Leave += OnContentChanged;
            control.Width.SelectionChangeCommitted += OnContentChanged;

            if (control.MapName.Text != MapBosch.ERROR_LIST)
            {
                control.MapName.Validated += OnContentChanged;
                control.MapName.Leave += OnContentChanged;
                control.Remove.Click += OnRemoveClicked;
            }
            else
            {
                control.MapName.Enabled = false;
                control.Remove.Enabled = false;
            }

            controls.Add(new(control.Remove, control));
        }

        internal void RemoveRow(int index)
        {
            var control = controls[index].control;

            RemoveRow(control);
        }

        private void RemoveRow(BoschMapEditorControl control)
        {
            control.MapName.Validated -= OnContentChanged;
            control.MapName.Leave -= OnContentChanged;
            control.Address.Validated -= OnContentChanged;
            control.Address.Leave -= OnContentChanged;
            control.NewValue.Validated -= OnContentChanged;
            control.NewValue.Leave -= OnContentChanged;
            control.Width.SelectionChangeCommitted -= OnContentChanged;
            control.Remove.Click -= OnRemoveClicked;

            TableLayoutMaps.Controls.Remove(control);
            ResetRowStyles();

            control.Dispose();
        }

        private void ResetRowStyles()
        {
            TableLayoutMaps.RowStyles.Clear();

            foreach (var control in controls)
            {
                TableLayoutMaps.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
        }

        public void Clear()
        {
            foreach (var control in controls)
            {
                RemoveRow(control.control);
            }

            controls.Clear();
        }

        private void OnRemoveClicked(object? sender, EventArgs e)
        {
            if (sender == null)
                return;

            Button button = (Button)sender;
            var control = controls.FirstOrDefault(x => x.button == button);

            MapRemoved?.Invoke(controls.IndexOf(control));
        }

        private void OnContentChanged(object? sender, EventArgs e)
        {
            if (sender == null)
                return;

            BoschMapEditorControl? control = (BoschMapEditorControl?)((((Control?)sender)?.Parent)?.Parent);

            if (control == null)
                return;

            var index = controls.IndexOf(controls.FirstOrDefault(x => x.control == control));

            ContentChanged?.Invoke(index, new BoschMapEditorContent(control.MapName.Text, control.Address.Text, control.Width.SelectedIndex, control.NewValue.Text));
        }
    }
}