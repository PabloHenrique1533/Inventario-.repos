using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gf_materiais.forms
{
    public partial class Form2 : Form
    {
        internal Action<object, object> FormShown;

        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form3 forms3 = new Form3();
            this.Hide();
            forms3.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
