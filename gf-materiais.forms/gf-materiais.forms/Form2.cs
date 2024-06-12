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
    public partial class LoginForm : Form
    {
        internal Action<object, object> FormShown;
       
        public LoginForm()
        {
            InitializeComponent();
            DAO conexao = new DAO();
            try
            {
                conexao.abrirConexao();
               
            }catch (Exception ex)
            {
                MessageBox.Show("Falha Na Conexao!"+ ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Cadastro forms3 = new Cadastro();
            this.Hide();
            forms3.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DAO acessarDados = new DAO();         
           
            string usuario = usuariologin_txt.Text;
            string senha = senhalogin_txt.Text;

            if(string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por Favor, Insira o nome de usuatio e senha.");
                return;
            }

            bool loginvalido = acessarDados.Login(usuario, senha);
            if (loginvalido)
            {
                MessageBox.Show("Login Bem-Sucedido!");

                Form4 forms4 = new Form4();
                this.Hide();
                forms4.Show();
            }
            else
            {
                MessageBox.Show("Credenciais Invalidas. Por Favor, tente novamente");
            }

        }
    }
}
