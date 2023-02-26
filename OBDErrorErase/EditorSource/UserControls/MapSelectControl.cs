namespace OBDErrorErase
{
    public partial class MapSelectControl : UserControl
    {
        public bool IsChecked => Checkbox.Checked;

        public int ID { get; }

        public MapSelectControl(string name, int id)
        {
            ID = id;
            InitializeComponent();

            Checkbox.Text = name;
            Checkbox.Checked = true;
        }
    }
}
