using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBDErrorErase
{
    public partial class ErrorPresetControl : UserControl
    {
        public event Action<ErrorPresetControl>? DeleteClicked;
        public event Action<int>? OpenClicked;

        public int ID { get; private set; }

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
