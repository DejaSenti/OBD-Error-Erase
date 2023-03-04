using OBDErrorErase.EditorSource.GUI;

namespace OBDErrorErase
{
    public partial class ErrorPresetControl : UserControl, ICheckboxControl
    {
        public event Action<ErrorPresetControl>? DeleteClicked;
        public event Action<int>? OpenClicked;

        public int ID { get; private set; }

        public CheckBox CheckBox => Checkbox;

        public ErrorPresetControl(string name, int id)
        {
            InitializeComponent();

            ID = id;

            Checkbox.Text = name;
            Checkbox.Checked = true;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this);
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            OpenClicked?.Invoke(ID);
        }
    }
}
