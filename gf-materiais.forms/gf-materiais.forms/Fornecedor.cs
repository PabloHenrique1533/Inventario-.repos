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
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void RegistrarForncedor_Click(object sender, EventArgs e)
        {
            DAO conexao = new DAO();
            DAO dados = new DAO();

            try
            {
                try
                {
                    conexao.abrirConexao();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na conexao com o MYSQL:" + ex.Message);
                }

                string comando = "INSERT INTO Pessoa (nome, email, cpf, data_nascimento, endereco) VALUES (@nome, @email, @cpf, @data_nascimento, @endereco)";
                string comando2 = "INSERT INTO Fornecedor (cnpj, telefone) VALUES (@cnpj, @telefone)";

                var parametros = new Dictionary<string, object>
                {
                    //tabela pessoa
                    {"@nome", nomefornecedorTxt.Text },
                    {"@email", emailFornecedorTxt.Text},
                    {"@cpf", cpfFornecdorTxt.Text},
                    {"data_nascimento", DateTime.Parse(calendarioNascimento.Text)},
                    {"endereco", enderecoFornecedorTxt.Text },
                    //tabela fornecedor
                    {"@cnpj", cnpjFornecedorTxt.Text},
                    {"@telefone", telfornecedorTxt.Text}
                };

                if (string.IsNullOrWhiteSpace(nomefornecedorTxt.Text) || string.IsNullOrWhiteSpace(cpfFornecdorTxt.Text) ||
                        string.IsNullOrWhiteSpace(emailFornecedorTxt.Text) || string.IsNullOrWhiteSpace(cnpjFornecedorTxt.Text) ||
                        string.IsNullOrWhiteSpace(telfornecedorTxt.Text))
                {
                    MessageBox.Show("Falto campos para preencher");
                    return;
                }

                dados.InserirNoBanco(comando, parametros);
                dados.InserirNoBanco(comando2, parametros);
                MessageBox.Show("Dados Inseridos Com Sucesso!");
                conexao.fecharconexao();

            }catch(Exception ex) 
            {
                MessageBox.Show("Erro ao Inserir dados" + ex.Message);
            }     
        }
    }
}
