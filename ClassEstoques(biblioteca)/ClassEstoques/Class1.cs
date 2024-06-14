using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ClassEstoques
{

    public class Produto
    {

        public string nome;
        public string descricao;
        public decimal preco_compra;
        public int qnt_estoque;
        public int qnt_min;
        public string categoria;

       
        public void cadastrarproduto()
        {
            string comando = "INSERT INTO Produto (@nome, @descricao, @preco_compra, @qnt_estoque, @qnt_min, @categoria) VALUES (nome, descricao, preco_compra, qnt_min, categoria)";
             
            try
            {

                using(MySqlCommand cmd = new MySqlCommand(comando, conexao))
                {
                    cmd.add
                }
            }
        }

            public void ProcuraProduto()
            {

            }

            public void RemoverProduto()
            {

            }

            public void AtualizarPreco()
            {

            }

            public void AtualizarEstoque()
            {

            }
            public void RegistrarEntradaProduto()
            {

            }
            public void RegistrarSaidaProduto()
            {

            }
        }

        public class Fornecedor 
        {
            private int cnpj;
            private int telefone;
            public void CadastrarFornecedor()
            {

            }

            public void RemoverFuncionario()
            {

            }
            public void AtualizarFornecedor()
            {

            }
        }

        public class Cliente 
        {
            private int cpf;

            public void CadastroCliente()
            {

            }
            public void RemoverCliente()
            {

            }
            public void AtualizarCliente()
            {

            }
        }

        public class Pedido : ItemPedido
        {
            public DateTime data_pedido;
            public DateTime data_entrega;
            public string status_pedido;
            public decimal valor_total;

            public void FzrPedido()
            {

            }

            public void AtualizarPedido()
            {

            }

            public void RegistrarentradaPedido()
            {

            }
        }

        public class ItemPedido : Produto
        {
            public int quantidade;
            public double preco_unitario;
            public double subtotal;

            public void CalcularSubtotal()
            {

            }
        }

        public class Relatorio
        {
            public string tipo;
            public DateTime data_geracao;

            public void GerarRelatorio()
            {

            }

            public void ObterRelatorio()
            {

            }
        }

        public class Pessoa
        {
            public string nome;
            public string email;
            public string endereco;
        }


    }

