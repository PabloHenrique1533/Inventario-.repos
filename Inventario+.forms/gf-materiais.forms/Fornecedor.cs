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

                string cpf = cpfFornecdorTxt.Text;
                string cnpj = cnpjFornecedorTxt.Text;
                string telefone = telfornecedorTxt.Text;

                if (dados.FornecedorExiste(cpf, cnpj, telefone))
                {
                    MessageBox.Show("Já existe um fornecedor com este CPF, CNPJ ou telefone.");
                    return;
                }

                string comando = "INSERT INTO PessoaFornecedor (nome, email, cpf, data_nascimento, endereco, cnpj, telefone) VALUES (@nome, @email, @cpf, @data_nascimento, @endereco, @cnpj, @telefone)";

                var parametros = new Dictionary<string, object>
                {
                    //tabela pessoa
                    {"@nome", nomefornecedorTxt.Text },
                    {"@email", emailFornecedorTxt.Text},
                    {"@cpf", cpfFornecdorTxt.Text},
                    {"data_nascimento", DateTime.Parse(calendarioNascimento.Text)},
                    {"endereco", enderecoFornecedorTxt.Text },
                    {"@cnpj", cnpjFornecedorTxt.Text},
                    {"@telefone", telfornecedorTxt.Text}
                };

                //Preencher os campos
                if (string.IsNullOrWhiteSpace(nomefornecedorTxt.Text) || string.IsNullOrWhiteSpace(cpfFornecdorTxt.Text) ||
                        string.IsNullOrWhiteSpace(emailFornecedorTxt.Text) || string.IsNullOrWhiteSpace(cnpjFornecedorTxt.Text) ||
                        string.IsNullOrWhiteSpace(telfornecedorTxt.Text) || string.IsNullOrWhiteSpace(enderecoFornecedorTxt.Text))
                {
                    MessageBox.Show("Falto campos para preencher");
                    return;
                }


                //
                if(telfornecedorTxt.Text.Length < 11 || cnpjFornecedorTxt.Text.Length < 14 || cpfFornecdorTxt.Text.Length < 11)
                {
                    MessageBox.Show("Digitos invalidos Porfavor Digite Quantidade Certa!!");
                    return;
                }

               

                dados.InserirNoBanco(comando, parametros);
                MessageBox.Show("Dados Inseridos Com Sucesso!");

                DAO objeto = new DAO();
                DataTable fornecedor = objeto.tabelaFornecedor();
                TabelasFornecedor.DataSource = fornecedor;

                conexao.fecharconexao();

            }catch(Exception ex) 
            {
                MessageBox.Show("Erro ao Inserir dados" + ex.Message);
            }     
        }

        private void voltarbotao_Click(object sender, EventArgs e)
        {
            telainico voltar = new telainico();
            this.Hide();
            voltar.Show();
        }

        private void Fornecedor_Load(object sender, EventArgs e)
        {
            DAO objeto = new DAO();
            DataTable fornecedor = objeto.tabelaFornecedor();
            TabelasFornecedor.DataSource = fornecedor;
        }

        private void TabelasFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void remover_Click(object sender, EventArgs e)
        {
            try
            {
                if (TabelasFornecedor.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = TabelasFornecedor.SelectedRows[0];
                    string nomeFornecedor = selectedRow.Cells["nome"].Value.ToString();

                    DAO dados = new DAO();
                    string comando = "DELETE FROM PessoaFornecedor WHERE nome = @nome";
                    var parametros = new Dictionary<string, object>
                    {
                        {"@nome", nomeFornecedor}
                    };

                    dados.RemoverDoBanco(comando, parametros);
                    MessageBox.Show("Fornecedor removido com sucesso!");

                    // Atualiza a tabela
                    DataTable fornecedor = dados.tabelaFornecedor();
                    TabelasFornecedor.DataSource = fornecedor;
                }
                else
                {
                    MessageBox.Show("Selecione um fornecedor para remover.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover o fornecedor: " + ex.Message);
            }
        }
    }
    
}
