using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gf_materiais.forms
{
    public partial class Configurações : Form
    {
        public Configurações()
        {
            InitializeComponent();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            LoginForm sair = new LoginForm();
            this.Hide();
            sair.Show();
            MessageBox.Show("Você saiu do Sistema!");
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            telainico voltar = new telainico();
            this.Hide();
            voltar.Show();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
        }

        private void configuraçoes_load(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            int idUsuario = 1; 

            try
            {
                dao.abrirConexao(); 

                MySqlDataReader reader = dao.ObterDadosUsuario(idUsuario);

                if (reader.Read())
                {
                  
                    string usuario = reader["usuario"].ToString();
                    string nomeCompleto = reader["nome_completo"].ToString();
                    string email = reader["email"].ToString();

                   
                    usuariotxt.Text = usuario;
                    nomecompletotxt.Text = nomeCompleto;
                    emailtxt.Text = email;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do usuário: " + ex.Message);
            }
            finally
            {
                dao.fecharconexao(); 
            }
        }
    }       
}
