namespace OBDErrorErase
{
    public partial class MapSelectControl : UserControl, ICheckboxControl
    {
        public bool IsChecked => Checkbox.Checked;

        public int ID { get; }

        public CheckBox CheckBox => Checkbox;

        public MapSelectControl(string name, int id)
        {
            ID = id;
            InitializeComponent();

            Checkbox.Text = name;
            Checkbox.Checked = true;
        }
    }
}
