using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace gf_materiais.forms
{
    internal class DAO
    {
        string conexaoString = "server=localhost;port=3306;Database=estoque;uid=root;pwd=''";
        MySqlConnection conexao;
        MySqlCommand cmd;

        public void bd()
        {
            try
            {
                conexao = new MySqlConnection(conexaoString);
                conexao.Open();
                Console.WriteLine("Conexão estabelecida com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao estabelecer conexão: " + ex.Message);
            }
        }

        public void insert_dados(string comando)
        {
            try
            {
                cmd = new MySqlCommand(comando, conexao);

                int linhasAfetadas = cmd.ExecuteNonQuery();
                if (linhasAfetadas == 0)
                {
                    Console.WriteLine("Nenhuma linha foi afetada.");
                }
                else
                {
                    Console.WriteLine("Número de linhas afetadas: {0}", linhasAfetadas);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao executar o comando SQL: " + ex.Message);
            }
        }

        public void InserirNoBanco(string query, object value)
        {
            try
            {
                cmd.Parameters.AddWithValue(query, value);
                int linhasAfetadas = cmd.ExecuteNonQuery();
                if (linhasAfetadas == 0)
                {
                    Console.WriteLine("Nenhuma linha foi afetada.");
                }
                else
                {
                    Console.WriteLine("Número de linhas afetadas: {0}", linhasAfetadas);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao executar o comando SQL: " + ex.Message);
            }
        }
            
    }
}
    

