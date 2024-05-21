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
            public DateTime dt_entrada_estoque; 

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
        }

        public class Fornecedor
        {
            string nome;
            int cnpj;
            string endereco;
            int telefone;
            string enmail;  
        }

        public class Cliente
        {
            string nome;
            int cpf;
            string endereco;
            string email;      
        }

        public class Usuario
        {
            string nome;
            int senha;
            string nome_completo;
            string cargo;
            string permissoes_acesso;
        }

        public class Pedido
        {
            string data_pedido;
            string data_entrega;
            string status;
            int valor_total;
        }

        public class ItemPedido
        {
            int quantidade;
            double preco_unitario;
            double subtotal;
        }
    
}
