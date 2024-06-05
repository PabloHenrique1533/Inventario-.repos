using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassEstoques;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GF_Materiais
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
            produto1.cadastrarproduto();

            DAO dados = new DAO();
            dados.bd();

            string comando = "INSERT INTO Produto (nome, descricao, preco_compra, qnt_estoque, qnt_min, categoria) VALUES (@nome, @descricao, @preco_compra, @qnt_estoque, @qnt_min, @categoria)";

            dados.InserirNoBanco(comando,
                new MySqlParameter("@nome", produto1.nome),
                new MySqlParameter("@descricao", produto1.descricao),
                new MySqlParameter("@preco_compra", produto1.preco_compra),
                new MySqlParameter("@qnt_estoque", produto1.qnt_estoque),
                new MySqlParameter("@qnt_min", produto1.qnt_min),
                new MySqlParameter("@categoria", produto1.categoria));

            Console.ReadKey();
        }
    }
}
