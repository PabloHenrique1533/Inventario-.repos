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
            this.nome = Console.ReadLine();

            Console.WriteLine("Insira a Descrição Do Produto:");
            this.descricao = Console.ReadLine();

            Console.WriteLine("Informe o Preço do Produto:");
            this.preco_compra = decimal.Parse(Console.ReadLine());

            Console.WriteLine("informe a quantidade desse produto no estoque:");
            this.qnt_estoque = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Quantidade Minima desse produto no Estoque:");
            this.qnt_min = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe Sua Categoria: \n" +
                "1.Ferramentas Manuais" +
                "2.Material Eletrico" +
                "3.Pisos" +
                "4.Janelas e Portas");

            int opcao = 0;
            opcao = Console.ReadKey().KeyChar;
            switch (opcao) {

                case '1':
                this.categoria = "Ferramentas Manuais";
                break;

                case '2':
                this.categoria = "Material Eletrico";
                break;

                case '3':
                this.categoria = "Pisos";
                break;

                case '4':
                this.categoria = "Janelas e Portas";
                break;
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

        public class Fornecedor : Pessoa
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

        public class Cliente : Pessoa
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

        public class Funcionario : Pessoa
        {
            public string nome_completo;
            private string senha;
            public string cargo;
            public string tipo;
            public string permissoes_acesso;

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

