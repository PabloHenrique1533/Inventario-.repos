using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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
                "\n 1.Ferramentas Manuais" +
                "\n 2.Material Eletrico" +
                "\n 3.Pisos" +
                "\n 4.Janelas e Portas");

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
        public string usuario;

            public void CadastrarFuncionario()
            {
            Console.WriteLine("Chegou Funcionario Novo? Então Cadastre ele Aqui! " + "\n 1.Cadstrar" + "\n 2.Login" + "3.Sair");
            var opcao = Console.ReadLine();
            switch (opcao)
            {
                case '1':
                    
                        Console.Clear();
                    Console.WriteLine("====Cadastro=====");
                    Console.WriteLine("Insira Seu Nome Completo!");
                    nome_completo = Console.ReadLine();
                    Console.WriteLine("Insira o Cargo Dele(a)");
                    cargo = Console.ReadLine();
                    Console.WriteLine("Insira o Tipo do Cargo!");
                    tipo = Console.ReadLine();
                    Console.WriteLine("De Um Nome de Usuario a Ele(a)");
                    usuario = Console.ReadLine;
                    Console.WriteLine("Crie Sua Senha!");
                    senha = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(nome_completo) || string.IsNullOrWhiteSpace(cargo) || string.IsNullOrWhiteSpace(tipo) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(usuario))
                    {
                        Console.WriteLine("Os Campos Estão Vazios Por Favor Preencher Eles!!");
                        Console.ReadLine();
                        return;
                    }

                    string verificar = $"{usuario};{senha}";
                    if (File.Exists("users.txt") && File.ReadLines("users.txt").Any(line => line.Split(;)[0] == usuario) || File.Exists("users.txt") && File.ReadLines("users.txt").Any(line => line.Split(;)[0] == senha) ){
                        Console.WriteLine("Nome Ususario e Senha Ja Em Uso, PorFavor Tente Outro");
                        usuario = Console.ReadLine();
                        return;
                    }

                    File.AppendAllText("users.txt", verificar + Environment.NewLine);
                    Console.WriteLine("Usuario Registrado Com Sucesso!");
                    
                break;

                case '2':
                    Console.Clear();
                    Console.WriteLine("===Login===");
                    Console.WriteLine("Usuario");
                    usuario = Console.ReadLine();
                    Console.WriteLine("Insira Sua Senha");

                break;

                case '3':
                    sair();
                break;

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

