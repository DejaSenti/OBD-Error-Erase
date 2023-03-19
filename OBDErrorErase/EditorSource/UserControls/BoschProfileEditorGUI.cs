using OBDErrorErase.EditorSource.Maps;
using OBDErrorErase.EditorSource.ProfileManagement.ProfileEditors;
using OBDErrorErase.EditorSource.Utils;
using static OBDErrorErase.EditorSource.Utils.AppHelper;

namespace OBDErrorErase
{
    public partial class BoschProfileEditorGUI : UserControl, IProfileEditorGUI
    {
        public event Action? RequestAddMap;
        public event Action<string>? RequestLengthChangeEvent;
        public event Action? RequestChangeLengthAlgorithm;

        public event Action<int, string>? RequestMapNameChangeEvent;
        public event Action<int, int>? RequestWidthChangeEvent;
        public event Action<int, string>? RequestNewValueChangeEvent;
        public event Action<int, string>? RequestAddressChangeEvent;
        public event Action<int>? RequestMapRemoveEvent;

        private List<BoschMapEditorControl> controls;

        public UserControl UserControl => this;

        public BoschProfileEditorGUI()
        {
            InitializeComponent();

            AddGUIListeners();

            ComboBoxMapLengthAlgorithm.Items.AddRange(Enum.GetNames<BoschLengthAlgorithm>());
            ComboBoxMapLengthAlgorithm.SelectedIndex = 0;

            controls = new();

            EnforceValidations(new List<TextBox>() { TextBoxMapLength }, new List<Validation>() { char.IsNumber, char.IsControl });
        }

        private void AddGUIListeners()
        {
            ButtonAddMap.Click += OnAddMapClick;
            TextBoxMapLength.Validated += OnMapLengthChange;
            TextBoxMapLength.Leave += OnMapLengthChange;
            TextBoxMapLength.KeyUp += OnMapLengthKeyUp;
            ComboBoxMapLengthAlgorithm.SelectionChangeCommitted += OnAlgorithmSelectionChanged;
        }

        private void RemoveGUIListeners()
        {
            ButtonAddMap.Click -= OnAddMapClick;
            TextBoxMapLength.Validated -= OnMapLengthChange;
            ComboBoxMapLengthAlgorithm.SelectionChangeCommitted -= OnAlgorithmSelectionChanged;
        }

        private void AddControlListeners(BoschMapEditorControl control)
        {
            control.RequestAddressChangeEvent += OnAddressChangeRequest;
            control.RequestMapNameChangeEvent += OnMapNameChangeRequest;
            control.RequestMapRemoveEvent += OnMapRemoveRequest;
            control.RequestNewValueChangeEvent += OnNewValueChangeRequest;
            control.RequestWidthChangeEvent += OnWidthChangeRequest;
        }

        private void RemoveControlListeners(BoschMapEditorControl control)
        {
            control.RequestAddressChangeEvent -= OnAddressChangeRequest;
            control.RequestMapNameChangeEvent -= OnMapNameChangeRequest;
            control.RequestMapRemoveEvent -= OnMapRemoveRequest;
            control.RequestNewValueChangeEvent -= OnNewValueChangeRequest;
            control.RequestWidthChangeEvent -= OnWidthChangeRequest;
        }

        #region Event Listeners

        private void OnAddMapClick(object? sender, EventArgs e)
        {
            RequestAddMap?.Invoke();
        }

        private void OnMapLengthChange(object? sender, EventArgs e)
        {
            RequestLengthChangeEvent?.Invoke(TextBoxMapLength.Text);
        }

        private void OnMapLengthKeyUp(object? sender, KeyEventArgs e)
        {
            RunIfEnterKey(e.KeyCode, () => RequestLengthChangeEvent?.Invoke(TextBoxMapLength.Text));
        }

        private void OnAlgorithmSelectionChanged(object? sender, EventArgs e)
        {
            UpdateMapLengthTextBoxStatus();
            RequestChangeLengthAlgorithm?.Invoke();
        }

        private void OnWidthChangeRequest(BoschMapEditorControl control, int widthIndex)
        {
            RequestWidthChangeEvent?.Invoke(controls.IndexOf(control), widthIndex);
        }

        private void OnNewValueChangeRequest(BoschMapEditorControl control, string newValue)
        {
            RequestNewValueChangeEvent?.Invoke(controls.IndexOf(control), newValue);
        }

        private void OnMapRemoveRequest(BoschMapEditorControl control)
        {
            RequestMapRemoveEvent?.Invoke(controls.IndexOf(control));
        }

        private void OnMapNameChangeRequest(BoschMapEditorControl control, string newMapName)
        {
            RequestMapNameChangeEvent?.Invoke(controls.IndexOf(control), newMapName);
        }

        private void OnAddressChangeRequest(BoschMapEditorControl control, string newAddress)
        {
            RequestAddressChangeEvent?.Invoke(controls.IndexOf(control), newAddress);
        }

        #endregion

        public void UpdateMapLengthTextBoxStatus()
        {
            TextBoxMapLength.Enabled = ComboBoxMapLengthAlgorithm.SelectedIndex == (int)BoschLengthAlgorithm.MANUAL;
        }

        internal void AddMap(MapBosch map)
        {
            string newValue = Convert.ToHexString(map.NewValue.ToArray());

            var control = new BoschMapEditorControl(map.Name, map.RawLocation, map.RawWidth, newValue);
            control.Address.Enabled = controls.Count > 0 ? controls[0].Address.Enabled : false;

            AddControlListeners(control);

            TableLayoutMaps.Controls.Add(control);
            TableLayoutMaps.SetRow(control, TableLayoutMaps.Controls.Count - 1);
            ResetRowStyles();

            controls.Add(control);
        }

        public void RemoveMap(int index)
        {
            var control = controls[index];
            controls.RemoveAt(index);

            RemoveRow(control);
        }

        private void RemoveRow(BoschMapEditorControl control)
        {
            RemoveControlListeners(control);

            TableLayoutMaps.Controls.Remove(control);
            ResetRowStyles();

            control.Dispose();
        }

        private void ResetRowStyles()
        {
            TableLayoutMaps.RowStyles.Clear();

            for (int i = 0; i < controls.Count; ++i)
            {
                TableLayoutMaps.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
        }

        internal int GetMapLocation(string mapName)
        {
            var map = controls.FirstOrDefault(x => x.MapName.Text.ToLower() == mapName.ToLower());

            return (map == null || string.IsNullOrEmpty(map.Address.Text)) ? -1 : Convert.ToInt32(map.Address.Text, 16);
        }

        public void Clear()
        {
            foreach (var control in controls)
            {
                RemoveRow(control);
            }

            controls.Clear();
        }

        public new void Dispose()
        {
            Clear();
            RemoveGUIListeners();

            base.Dispose();
        }

        internal BoschLengthAlgorithm GetLengthAlgorithm()
        {
            return (BoschLengthAlgorithm)ComboBoxMapLengthAlgorithm.SelectedIndex;
        }

        internal void SetNewValueField(int mapIndex, string value)
        {
            var control = controls[mapIndex];

            control.NewValue.Text = value;
        }

        public void EnableAddressFields()
        {
            foreach (var control in controls)
            {
                control.Address.Enabled = true;
            }
        }
    }
}