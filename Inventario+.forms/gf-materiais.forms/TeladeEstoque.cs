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
    public partial class TeladeEstoque : Form
    {
        public TeladeEstoque()
        {
            InitializeComponent();
        }

       
        private void registrotxt_Click(object sender, EventArgs e)
        {
           try 
              { 

                DAO dados = new DAO();
                DAO conexao = new DAO();
                try
                {
                    conexao.abrirConexao();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na conexao com o MYSQL:" + ex.Message);
                }

                string nomeProduto = produtoTxt.Text;
                if (dados.ProdutoExiste(nomeProduto))
                {
                    MessageBox.Show("Já existe um produto com este nome.");
                    return;
                }


                string comando = "INSERT INTO Produto (nome, qnt_estoque, qnt_min, qnt_atual) VALUES (@nome, @qnt_estoque, @qnt_min, @qnt_atual) "; 
                var parametros = new Dictionary<string, object>
                {
                    {"@nome", produtoTxt.Text },
                    {"@qnt_estoque", qntmaxTxt.Text },
                    {"@qnt_min", qntminTxt.Text },
                    {"@qnt_atual", qntatualTxt.Text }
                };

                if (string.IsNullOrWhiteSpace(qntminTxt.Text) || string.IsNullOrWhiteSpace(produtoTxt.Text) ||
                    string.IsNullOrWhiteSpace(qntmaxTxt.Text) || string.IsNullOrWhiteSpace(qntatualTxt.Text))
                {
                    MessageBox.Show("Falto campos para preencher");
                    return;
                }
               
                int min = int.Parse(qntminTxt.Text);
                int atual = int.Parse(qntatualTxt.Text);
                int max = int.Parse(qntmaxTxt.Text);

                if(atual < min || atual > max)
                {
                    MessageBox.Show("Quantidade Invalida!!");
                    return;
                }


                dados.InserirNoBanco(comando, parametros);
                MessageBox.Show("Produto cadastrado com sucesso!");

                DAO objeto = new DAO();
                DataTable produto = objeto.tabelaEstoque();
                TabelaProdutos.DataSource = produto;

                conexao.fecharconexao();
            }
            catch (Exception ex)
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

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tela_load(object sender, EventArgs e)
        {
            DAO objeto = new DAO();
            DataTable produto = objeto.tabelaEstoque();
            TabelaProdutos.DataSource = produto;
        }

        private void remover_Click(object sender, EventArgs e)
        {
            try
            {
                if (TabelaProdutos.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = TabelaProdutos.SelectedRows[0];
                    string nomeProduto = selectedRow.Cells["nome"].Value.ToString();

                    DAO dados = new DAO();
                    string comando = "DELETE FROM Produto WHERE nome = @nome";
                    var parametros = new Dictionary<string, object>
                    {
                        {"@nome", nomeProduto}
                    };

                    dados.RemoverDoBanco(comando, parametros);
                    MessageBox.Show("Produto removido com sucesso!");

                    // Atualiza a tabela
                    DataTable produto = dados.tabelaEstoque();
                    TabelaProdutos.DataSource = produto;
                }
                else
                {
                    MessageBox.Show("Selecione um produto para remover.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover o produto: " + ex.Message);
            }
        }
    }
}
