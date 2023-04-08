using OBDErrorErase.EditorSource.Configs;
using OBDErrorErase.EditorSource.Maps;
using static OBDErrorErase.EditorSource.Utils.AppHelper;

namespace OBDErrorErase
{
    public partial class BoschMapEditorControl : UserControl
    {
        public event Action<BoschMapEditorControl>? RequestMapRemoveEvent;
        public event Action<BoschMapEditorControl, string>? RequestMapNameChangeEvent;
        public event Action<BoschMapEditorControl, string>? RequestWidthChangeEvent;
        public event Action<BoschMapEditorControl, string>? RequestNewValueChangeEvent;
        public event Action<BoschMapEditorControl, string>? RequestAddressChangeEvent;

        public BoschMapEditorControl(string name, int rawLocation, string rawWidth, string newValue)
        {
            InitializeComponent();
            MapName.Text = name;
            NewValue.Text = newValue;
            Address.Text = rawLocation.ToString("X");
            MapWidth.Text = rawWidth;

            if (MapName.Text.ToLower() == MapBosch.DTC.ToLower())
            {
                MapName.Enabled = false;
                Remove.Enabled = false;
            }

            AddGUIListeners();

            EnforceValidations(new List<TextBox>() { NewValue, Address }, new List<Validation>() { char.IsAsciiHexDigit, char.IsControl });
            EnforceValidations(new List<TextBox>() { MapWidth }, new List<Validation>() { char.IsNumber, char.IsControl });
        }

        private void AddGUIListeners()
        {
            Address.Validated += OnAddressChanged;
            Address.Leave += OnAddressChanged;
            Address.KeyUp += OnAddressKeyUp;
            NewValue.Validated += OnNewValueChanged;
            NewValue.Leave += OnNewValueChanged;
            NewValue.KeyUp += OnNewValueKeyUp;
            MapWidth.Validated += OnWidthChanged;
            MapWidth.Leave += OnWidthChanged;
            MapWidth.KeyUp += OnWidthKeyUp;

            if (MapName.Text != MapBosch.DTC)
            {
                MapName.Validated += OnMapNameChanged;
                MapName.Leave += OnMapNameChanged;
                MapName.KeyUp += OnMapNameKeyUp;
                Remove.Click += OnRemoveClicked;
            }
        }

        private void OnWidthKeyUp(object? sender, KeyEventArgs e)
        {
            RunIfEnterKey(e.KeyCode, () => RequestWidthChangeEvent?.Invoke(this, MapWidth.Text));
        }

        private void OnAddressKeyUp(object? sender, KeyEventArgs e)
        {
            RunIfEnterKey(e.KeyCode, () => RequestAddressChangeEvent?.Invoke(this, Address.Text));
        }

        private void OnMapNameKeyUp(object? sender, KeyEventArgs e)
        {
            RunIfEnterKey(e.KeyCode, () => RequestMapNameChangeEvent?.Invoke(this, MapName.Text));
        }

        private void OnNewValueKeyUp(object? sender, KeyEventArgs e)
        {
            RunIfEnterKey(e.KeyCode, () => RequestNewValueChangeEvent?.Invoke(this, NewValue.Text));
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
            RequestWidthChangeEvent?.Invoke(this, MapWidth.Text);
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
            Address.KeyUp -= OnAddressKeyUp;
            NewValue.Validated -= OnNewValueChanged;
            NewValue.Leave -= OnNewValueChanged;
            NewValue.KeyUp -= OnNewValueKeyUp;
            MapWidth.Validated -= OnWidthChanged;
            MapWidth.Leave -= OnWidthChanged;
            MapWidth.KeyUp -= OnWidthKeyUp;

            if (MapName.Text != MapBosch.DTC)
            {
                MapName.Validated -= OnMapNameChanged;
                MapName.Leave -= OnMapNameChanged;
                MapName.KeyUp -= OnMapNameKeyUp;
                Remove.Click -= OnRemoveClicked;
            }
        }

        public new void Dispose()
        {
            RemoveGUIListeners();
            base.Dispose();
        }
    }
}
