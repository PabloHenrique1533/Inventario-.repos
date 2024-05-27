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
            dados.insert_dados("INSERT INTO Produto (nome, descricao, preço_compra, qnt_estoque, qnt_min, categoria) VALUES(@nome, @descricao, @preço_compra, @qnt_estoque, @qnt_min, @categoria");
            dados.InserirNoBanco("@nome", produto1.nome);
            dados.InserirNoBanco("@descricao", produto1.descricao);
            dados.InserirNoBanco("@preço_compra", produto1.preco_compra);
            dados.InserirNoBanco("@qnt_estoque", produto1.qnt_estoque);
            dados.InserirNoBanco("@qnt_min", produto1.qnt_min);
            dados.InserirNoBanco("@categoria", produto1.categoria);



            dados.verificar_linhas();
            Console.ReadKey();
        }
    }
}
