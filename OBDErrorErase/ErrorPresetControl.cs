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
        public event Action<int>? DeleteClicked;
        public event Action<int>? OpenClicked;

        private int id;

        public ErrorPresetControl(string name, int id)
        {
            InitializeComponent();

            this.id = id;

            Checkbox.Text = name;
            Checkbox.Checked = true;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(id);
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            OpenClicked?.Invoke(id);
        }
    }
}
