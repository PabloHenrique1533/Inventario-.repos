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

        public string comando;
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

                
                comando = "INSERT INTO Produto (nome, qnt_estoque, qnt_min, qnt_atual, categoria) VALUES (@nome, @qnt_estoque, @qnt_min, @qnt_atual, @categoria) "; 
                var parametros = new Dictionary<string, object>
                {
                    {"@nome", produtoTxt.Text },
                    {"@qnt_estoque", qntmaxTxt.Text },
                    {"@qnt_min", qntminTxt.Text },
                    {"@qnt_atual", qntatualTxt.Text }
                };

                if (string.IsNullOrWhiteSpace(produtoTxt.Text) || string.IsNullOrWhiteSpace(qntmaxTxt.Text) ||
                    string.IsNullOrWhiteSpace(qntminTxt.Text) || string.IsNullOrWhiteSpace(qntatualTxt.Text))
                {
                    MessageBox.Show("Falto campos para preencher");
                    return;
                }

                dados.InserirNoBanco(comando, parametros);
                MessageBox.Show("Produto cadastrado com sucesso!");

                conexao.fecharconexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Inserir dados" + ex.Message);
            }     
        }
    }
}
