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
            dados.insert_dados("INSERT INTO Produto (nome, descricao, preço_compra, qnt_estoque, qnt_min, categoria, dt_entrada_estoque) VALUES(@nome, @descricao, @preço_compra, @qnt_estoque, @qnt_min, @categoria, @dt_entrada_estoque");
            dados.cmd.Parameters.AddWithValue("@nome", produto1.nome);
            dados.cmd.Parameters.AddWithValue("@descricao", produto1.descricao);
            dados.cmd.Parameters.AddWithValue("@preço_compra", produto1.preco_compra);
            dados.cmd.Parameters.AddWithValue("@qnt_estoque", produto1.qnt_estoque);
            dados.cmd.Parameters.AddWithValue("@qnt_min", produto1.qnt_min);
            dados.cmd.Parameters.AddWithValue("@categoria", produto1.categoria);
            dados.cmd.Parameters.AddWithValue("@dt_entrada_estoque", produto1.data_estoque);

            dados.verificar_linhas();
            Console.ReadKey();
        }
    }
}
