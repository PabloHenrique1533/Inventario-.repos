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
        string conexaoString = "server=localhost;port=3306;Database=estoque;uid=root;pwd=''";
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
            szint linha = cmd.ExecuteNonQuery();
            try
            {
                if (linha == 0)
                {
                    Console.WriteLine("erro");
                }
                else
                {
                    Console.WriteLine("linhas {0}", linha);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao executar o comando SQL:" + ex.Message);
            }
            finally
            {
                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        public void InserirNoBanco(string comando, object value)
        {
            cmd.Parameters.AddWithValue(comando, value);
        }
    }
}
