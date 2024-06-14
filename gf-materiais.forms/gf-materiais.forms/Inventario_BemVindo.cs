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
    public partial class Inventario_BemVindo : Form
    {
        public Inventario_BemVindo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm forms2 = new LoginForm();
                this.Hide(); // Fecha o Form2 quando o Form3 é mostrado
            forms2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
