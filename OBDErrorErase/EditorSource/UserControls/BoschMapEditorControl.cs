namespace OBDErrorErase
{
    public partial class BoschMapEditorControl : UserControl
    {
        public BoschMapEditorControl(string name, string newValue)
        {
            InitializeComponent();

            MapName.Text = name;
            NewValue.Text = newValue;
        }
    }
}
