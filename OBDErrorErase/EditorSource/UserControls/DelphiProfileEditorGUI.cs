using OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors;
using static OBDErrorErase.EditorSource.Utils.AppHelper;

namespace OBDErrorErase
{
    public partial class DelphiProfileEditorGUI : UserControl, IProfileEditorGUI
    {
        public event Action<string>? RequestAddressChangeEvent;
        public event Action<string>? RequestLengthChangeEvent;
        public event Action<string>? RequestNewValueChangeEvent;
        public event Action<string>? RequestErrorColumnChangeEvent;

        public UserControl UserControl => this;

        public DelphiProfileEditorGUI()
        {
            InitializeComponent();

            AddGUIListeners();

            EnforceValidations(new List<TextBox>() { Length, ErrorColumn }, new List<Validation>() { char.IsNumber, char.IsControl });
            EnforceValidations(new List<TextBox>() { Address, NewValue }, new List<Validation>() { char.IsAsciiHexDigit, char.IsControl });
        }

        private void AddGUIListeners()
        {
            Address.Validated += OnAddressChanged;
            Address.Leave += OnAddressChanged;
            Address.KeyUp += OnAddressKeyUp;
            Length.Validated += OnLengthChanged;
            Length.Leave += OnLengthChanged;
            Length.KeyUp += OnLengthKeyUp;
            NewValue.Validated += OnNewValueChanged;
            NewValue.Leave += OnNewValueChanged;
            NewValue.KeyUp += OnNewValueKeyUp;
            ErrorColumn.Validated += OnErrorColumnChanged;
            ErrorColumn.Leave += OnErrorColumnChanged;
            ErrorColumn.KeyUp += OnErrorColumnKeyUp;
        }

        #region Event Listeners

        private void OnErrorColumnKeyUp(object? sender, KeyEventArgs e)
        {
            RunIfEnterKey(e.KeyCode, () => RequestErrorColumnChangeEvent?.Invoke(ErrorColumn.Text));
        }

        private void OnErrorColumnChanged(object? sender, EventArgs e)
        {
            RequestErrorColumnChangeEvent?.Invoke(ErrorColumn.Text);
        }

        private void OnNewValueKeyUp(object? sender, KeyEventArgs e)
        {
            RunIfEnterKey(e.KeyCode, () => RequestNewValueChangeEvent?.Invoke(NewValue.Text));
        }

        private void OnNewValueChanged(object? sender, EventArgs e)
        {
            RequestNewValueChangeEvent?.Invoke(NewValue.Text);
        }

        private void OnLengthKeyUp(object? sender, KeyEventArgs e)
        {
            RunIfEnterKey(e.KeyCode, () => RequestLengthChangeEvent?.Invoke(Length.Text));
        }

        private void OnLengthChanged(object? sender, EventArgs e)
        {
            RequestLengthChangeEvent?.Invoke(Length.Text);
        }

        private void OnAddressKeyUp(object? sender, KeyEventArgs e)
        {
            RunIfEnterKey(e.KeyCode, () => RequestAddressChangeEvent?.Invoke(Address.Text));
        }

        private void OnAddressChanged(object? sender, EventArgs e)
        {
            RequestAddressChangeEvent?.Invoke(Address.Text);
        }

        #endregion

        private void RemoveGUIListeners()
        {
            Address.Validated -= OnAddressChanged;
            Address.Leave -= OnAddressChanged;
            Address.KeyUp -= OnAddressKeyUp;
            Length.Validated -= OnLengthChanged;
            Length.Leave -= OnLengthChanged;
            Length.KeyUp -= OnLengthKeyUp;
            NewValue.Validated -= OnNewValueChanged;
            NewValue.Leave -= OnNewValueChanged;
            NewValue.KeyUp -= OnNewValueKeyUp;
            ErrorColumn.Validated -= OnErrorColumnChanged;
            ErrorColumn.Leave -= OnErrorColumnChanged;
            ErrorColumn.KeyUp -= OnErrorColumnKeyUp;
        }

        public new void Dispose()
        {
            RemoveGUIListeners();
            base.Dispose();
        }

        internal void Clear()
        {
            Address.Text = string.Empty;
            ErrorColumn.Text = string.Empty;
            Length.Text = string.Empty;
            NewValue.Text = string.Empty;
        }

        internal void SetFields(int rawLocation, string errorColumn, int mapLength, string newValue)
        {
            Address.Text = rawLocation.ToString("X");
            ErrorColumn.Text = errorColumn;
            Length.Text = mapLength.ToString();
            NewValue.Text = newValue;
        }
    }
}