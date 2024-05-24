using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine("Digite o Nome do Produto:");
                nome = Console.ReadLine();

                Console.WriteLine("Descreve Ele:");
                descricao = Console.ReadLine();

                Console.WriteLine("Informe o Preco:");
                preco_compra = decimal.Parse(Console.ReadLine());

                Console.WriteLine("informe a quantidade do estoque:");
                qnt_estoque = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a Quantidade Minima do Estoque:");
                qnt_min = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe Sua Categoria:");
                categoria = Console.ReadLine();

                Console.WriteLine("Informe a Data que Chegou a Ultima Remessa de Estoque:");
                dt_entrada_estoque = DateTime.Parse(Console.ReadLine());

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
            string nome;
            int cnpj;
            string endereco;
            int telefone;
            string enmail;  
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
            int cpf;  
        
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

        public class Funcionario
        {
            string nome_completo;
            string senha;
            string cargo;
            string tipo;
            string permissoes_acesso;

            public void CadastrarFuncionario()
            {

            }

            public void Login()
            {

            }

            public void RemoverFuncionario()
            {

            }

            public void AtualizarFuncionario()
            {

            }

        }

        public class Pedido
        {
            DateTime data_pedido;
            DateTime data_entrega;
            string status_pedido;
            decimal valor_total;

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

        public class ItemPedido
        {
            int quantidade;
            double preco_unitario;
            double subtotal;

            public void CalcularSubtotal()
            {

            }
        }
        
        public class Relatorio
        {
             string tipo;
            DateTime data_geracao;

            public void GerarRelatorio()
            {

            }

            public void ObterRelatorio()
            {

            }
        }
    
        public class Pessoa
        {
            string nome;
              string email;
           public string endereco;
        }
}
