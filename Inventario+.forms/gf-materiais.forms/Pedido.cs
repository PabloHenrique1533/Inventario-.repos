using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace gf_materiais.forms
{
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            telainico voltar = new telainico();
            this.Hide();
            voltar.Show();
        }

        private void registrarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                DAO conexao = new DAO();
                DAO dados = new DAO();
                try
                {
                    conexao.abrirConexao();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na conexao!", ex.Message);
                }
                int qnt = int.Parse(quantidadePedidoTxt.Text);
                double preco = double.Parse(precounitario_txt.Text);
                double PrecoTotal = qnt * preco;
                if (GerarNotaFiscal(out string caminhoNotaFiscal))
                {
                    MessageBox.Show("Nota fiscal gerada com sucesso: " + caminhoNotaFiscal);

                    string comando = "INSERT INTO Pedido (data_pedido, data_entrega, quantidade, preco_unitario, pedido, valor_total, forma_pagamento) " +
                                     "VALUES (@data_pedido, @data_entrega, @quantidade, @preco_unitario, @pedido, @valor_total, @forma_pagamento)";

                    var parametros = new Dictionary<string, object>
                    {
                        {"@data_pedido", DateTime.Parse(calendarioPedido.Text)},
                        {"@data_entrega", DateTime.Parse(dtEntregaPedido.Text)},
                        {"@quantidade", quantidadePedidoTxt.Text},
                        {"@preco_unitario", precounitario_txt.Text},
                        {"@pedido", pedidoTxt.Text },
                        {"@valor_total", PrecoTotal },
                        {"@forma_pagamento", pagamentoTxt.Text }
                    };

                    // Preencher os campos
                    if (string.IsNullOrWhiteSpace(precounitario_txt.Text) ||
                        string.IsNullOrWhiteSpace(quantidadePedidoTxt.Text) || string.IsNullOrWhiteSpace(pedidoTxt.Text))
                    {
                        MessageBox.Show("Faltam campos para preencher");
                        return;
                    }

                    
                    MessageBox.Show("O Valor Total do seu pedido: " + PrecoTotal);

                    dados.InserirNoBanco(comando, parametros);
                    conexao.fecharconexao();
                }
                else
                {
                    MessageBox.Show("Erro ao gerar a nota fiscal. Pedido não registrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir dados! " + ex.Message);
            }
        }

        private void pedidoTxt_TextChanged(object sender, EventArgs e)
        {
            string searchText = pedidoTxt.Text;
            DAO dados = new DAO();
            DataTable produtos = dados.ProcurarProdutoPorNome(searchText);
           
        }

        private bool GerarNotaFiscal(out string caminhoNotaFiscal)
        {
            caminhoNotaFiscal = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NotaFiscal.pdf");
            Document doc = new Document();
            try
            {
                PdfWriter.GetInstance(doc, new FileStream(caminhoNotaFiscal, FileMode.Create));
                doc.Open();

                doc.Add(new Paragraph("Nota Fiscal"));
                doc.Add(new Paragraph("Data do Pedido: " + DateTime.Parse(calendarioPedido.Text).ToString("dd/MM/yyyy")));
                doc.Add(new Paragraph("Data de Entrega: " + DateTime.Parse(dtEntregaPedido.Text).ToString("dd/MM/yyyy")));
                doc.Add(new Paragraph("Produto: " + pedidoTxt.Text));
                doc.Add(new Paragraph("Quantidade: " + quantidadePedidoTxt.Text));
                doc.Add(new Paragraph("Preço Unitário: " + precounitario_txt.Text));

                int qnt = int.Parse(quantidadePedidoTxt.Text);
                double preco = double.Parse(precounitario_txt.Text);
                double PrecoTotal = qnt * preco;
                doc.Add(new Paragraph("Valor Total: " + PrecoTotal.ToString("C")));

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar a nota fiscal: " + ex.Message);
                caminhoNotaFiscal = string.Empty;
                return false;
            }
            finally
            {
                doc.Close();
            }
        }
    }
}
