using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GF_Materiais
{
    class DAO
    {
        string conexaoString = "server=localhost;port=3307;Database=estoque;uid=root;pwd=''";
        public MySqlCommand cmd;
        MySqlConnection conexao;

        public void bd()
        {
            try
            {
                conexao = new MySqlConnection(conexaoString);
                conexao.Open();

            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
        }
        public void insert_dados(string comando)
        {
            cmd = new MySqlCommand(comando, conexao);
        }

        public void verificar_linhas()
        {
            int linha = cmd.ExecuteNonQuery();
            if(linha == 0)
            {
                Console.WriteLine("erro");
            }
            else
            {
                Console.WriteLine("linhas {0}", linha);
            }
        }
    }
}
