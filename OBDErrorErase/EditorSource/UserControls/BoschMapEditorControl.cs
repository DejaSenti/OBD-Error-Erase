using OBDErrorErase.EditorSource.Configs;
using OBDErrorErase.EditorSource.Maps;
using OBDErrorErase.EditorSource.Utils;
using static OBDErrorErase.EditorSource.Utils.AppHelper;

namespace OBDErrorErase
{
    public partial class BoschMapEditorControl : UserControl
    {
        public event Action<BoschMapEditorControl>? RequestMapRemoveEvent;
        public event Action<BoschMapEditorControl, string>? RequestMapNameChangeEvent;
        public event Action<BoschMapEditorControl, int>? RequestWidthChangeEvent;
        public event Action<BoschMapEditorControl, string>? RequestNewValueChangeEvent;
        public event Action<BoschMapEditorControl, string>? RequestAddressChangeEvent;

        public BoschMapEditorControl(string name, int rawLocation, int rawWidth, string newValue)
        {
            InitializeComponent();
            MapName.Text = name;
            NewValue.Text = newValue;
            Address.Text = rawLocation.ToString();

            Width.Items.AddRange(ValueWidth.WIDTH.ToArray());
            Width.SelectedIndex = rawWidth;

            if (MapName.Text == MapBosch.DTC)
            {
                MapName.Enabled = false;
                Remove.Enabled = false;
            }

            AddGUIListeners();

            EnforceValidations(new List<TextBox>() { Address }, new List<Validation>() { char.IsNumber, char.IsControl });
            EnforceValidations(new List<TextBox>() { NewValue }, new List<Validation>() { char.IsAsciiHexDigit, char.IsControl });
        }

        private void AddGUIListeners()
        {
            Address.Validated += OnAddressChanged;
            Address.Leave += OnAddressChanged;
            Address.KeyUp += OnAddressKeyUp;
            NewValue.Validated += OnNewValueChanged;
            NewValue.Leave += OnNewValueChanged;
            NewValue.KeyUp += OnNewValueKeyUp;
            Width.SelectionChangeCommitted += OnWidthChanged;

            if (MapName.Text != MapBosch.DTC)
            {
                MapName.Validated += OnMapNameChanged;
                MapName.Leave += OnMapNameChanged;
                MapName.KeyUp += OnMapNameKeyUp;
                Remove.Click += OnRemoveClicked;
            }
        }

        private void OnAddressKeyUp(object? sender, KeyEventArgs e)
        {
            AppHelper.RunIfEnterKey(e.KeyCode, () => RequestAddressChangeEvent?.Invoke(this, Address.Text));
        }

        private void OnMapNameKeyUp(object? sender, KeyEventArgs e)
        {
            AppHelper.RunIfEnterKey(e.KeyCode, () => RequestMapNameChangeEvent?.Invoke(this, MapName.Text));
        }

        private void OnNewValueKeyUp(object? sender, KeyEventArgs e)
        {
            AppHelper.RunIfEnterKey(e.KeyCode, () => RequestNewValueChangeEvent?.Invoke(this, NewValue.Text));
        }

        private void OnRemoveClicked(object? sender, EventArgs e)
        {
            RequestMapRemoveEvent?.Invoke(this);
        }

        private void OnMapNameChanged(object? sender, EventArgs e)
        {
            RequestMapNameChangeEvent?.Invoke(this, MapName.Text);
        }

        private void OnWidthChanged(object? sender, EventArgs e)
        {
            RequestWidthChangeEvent?.Invoke(this, Width.SelectedIndex);
        }

        private void OnNewValueChanged(object? sender, EventArgs e)
        {
            RequestNewValueChangeEvent?.Invoke(this, NewValue.Text);
        }

        private void OnAddressChanged(object? sender, EventArgs e)
        {
            RequestAddressChangeEvent?.Invoke(this, Address.Text);
        }

        private void RemoveGUIListeners()
        {
            Address.Validated -= OnAddressChanged;
            Address.Leave -= OnAddressChanged;
            NewValue.Validated -= OnNewValueChanged;
            NewValue.Leave -= OnNewValueChanged;
            Width.SelectionChangeCommitted -= OnWidthChanged;
            MapName.Validated -= OnMapNameChanged;
            MapName.Leave -= OnMapNameChanged;
            Remove.Click -= OnRemoveClicked;
        }

        public new void Dispose()
        {
            RemoveGUIListeners();
            base.Dispose();
        }
    }
}
