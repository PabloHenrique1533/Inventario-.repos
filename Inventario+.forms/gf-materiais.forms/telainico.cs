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
    public partial class telainico : Form
    {
        public telainico()
        {
            InitializeComponent();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void estoque_txt_Click(object sender, EventArgs e)
        {
           
        }

        private void telainico_Load(object sender, EventArgs e)
        {

        }

        private void estoquetxt_Click(object sender, EventArgs e)
        {
            TeladeEstoque estoque = new TeladeEstoque();
            this.Hide();
            estoque.Show();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void FornecedorTxt_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            this.Hide();
            fornecedor.Show();
        }

        private void pedidoTxt_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            this.Hide();
            pedido.Show();
        }

        private void configuracoesbutao_Click(object sender, EventArgs e)
        {
            Configurações config = new Configurações();
            this.Hide();
            config.Show();
        }
    }
}
