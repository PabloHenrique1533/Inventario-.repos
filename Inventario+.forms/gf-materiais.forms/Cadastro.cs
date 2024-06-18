using MySql.Data.MySqlClient;
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
    public partial class Cadastro : Form
    {
        internal Action<object, object> FormShown;

        public Cadastro()
        {
            InitializeComponent();
           
        }

        public string comando;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DAO dados = new DAO();
                DAO conexao = new DAO();
                try 
                {
                    conexao.abrirConexao();
                    
                }catch(Exception ex)
                {
                    MessageBox.Show("Erro Na Conexao!"+ ex.Message);
                }
                //dados.insert_dados(comando);
                comando = "INSERT INTO Usuario (nome_completo, usuario,  senha, data_nascimento, email) VALUES (@nome_completo, @usuario, @senha, @data_nascimento, @email)";
                var parametros = new Dictionary<string, object>
            {
                { "@nome_completo", Nome_txt.Text },
                { "@usuario", Usuario_txt.Text },
                { "@senha", Senha_txt.Text },
                { "@data_nascimento", DateTime.Parse(date_txt.Text) },
                { "@email", Email_txt.Text }
            };

                if(string.IsNullOrWhiteSpace(Nome_txt.Text) || string.IsNullOrWhiteSpace(Usuario_txt.Text) || 
                 string.IsNullOrWhiteSpace(Senha_txt.Text) || string.IsNullOrWhiteSpace(date_txt.Text) ||
                 string.IsNullOrWhiteSpace(Email_txt.Text))
                {
                    MessageBox.Show("Falto campos para preencher");
                    return;
                }

                string usuario = Usuario_txt.Text;
                string email = Email_txt.Text;
                bool cadastroinvalido = dados.comparar(usuario,email);
                if (cadastroinvalido)
                {
                    MessageBox.Show("Nome de usuario ou email ja em uso! Por Favor insira Outro Nome ");
                    return;
                }
                else
                {
                    dados.InserirNoBanco(comando, parametros);
                    MessageBox.Show("Dados Inseridos com Sucesso!");

                    LoginForm forms2 = new LoginForm();
                    this.Hide();
                    forms2.Show();

                    conexao.fecharconexao();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir dados: " + ex.Message); 
            }

           
        }

        private void voltarbotao_Click(object sender, EventArgs e)
        {
            LoginForm voltar = new LoginForm();
            this.Hide();
            voltar.Show();
        }
    }
}
