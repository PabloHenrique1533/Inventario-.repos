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

        public DAO()
        {
            conexao = new MySqlConnection(conexaoString);
        }
        public void abrirConexao()
        {
            try
            {
                if(conexao.State == System.Data.ConnectionState.Closed)
                {
                    conexao.Open();
                    Console.WriteLine("Conexão estabelecida com sucesso.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao estabelecer conexão: " + ex.Message);
            }
        }

        public void fecharconexao()
        {
            try
            {
                if(conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                    Console.WriteLine("Conexao fechada Com Sucesso!");
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Erro ao Fechar Conexao: " + ex.Message);
            }
        }

       /* public void insert_dados(string comando)
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
        }*/


        public void InserirNoBanco(string comando, Dictionary<string, object> parametros)
        {
            try
            {
                abrirConexao();
                using (MySqlCommand cmd = new MySqlCommand(comando, conexao))
                {
                    foreach (var parametro in parametros)
                    {
                        cmd.Parameters.AddWithValue(parametro.Key, parametro.Value ?? DBNull.Value);
                    }

                    Console.WriteLine("Comando: " + comando);
                    foreach (var parametro in parametros)
                    {
                        Console.WriteLine($"Parâmetro: {parametro.Key} = {parametro.Value}");
                    }

                    int linhasAfetadas = cmd.ExecuteNonQuery();
                    if (linhasAfetadas == 0)
                    {
                        Console.WriteLine("Nenhuma linha foi afetada.");
                    }
                    else
                    {
                        Console.WriteLine("Número de linhas afetadas: {0}", linhasAfetadas);
                    }
                    cmd.Parameters.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao executar o comando SQL: " + ex.Message);
            }
            finally
            {
                fecharconexao();
            }
            
        }

        public bool Login(string usuario, string senha)
        {
            bool loginvalido = true;
            try
            {
                abrirConexao();
                string query = "SELECT COUNT(1) FROM Usuario WHERE usuario = @usuario AND senha = @senha";
                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    loginvalido = count > 0;
                } 
            }catch(Exception ex)
            {
                Console.WriteLine("Erro ao executar Comando SQL: " + ex.Message);
            }
            finally
            {
                fecharconexao();
            }
            return loginvalido;
        }

        public bool comparar(string usuario, string email)
        {
          bool comparado = false;
            try
            {
                abrirConexao();
                string queryusuario = "SELECT COUNT(*) FROM Usuario WHERE usuario = @usuario";
                //string queryemail = "SELECT COUNT(*) FROM Ususario WHERE email = @email";

                //comparação com o usuario;
                using (MySqlCommand cmd = new MySqlCommand(queryusuario, conexao)) 
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        comparado = true;
                    }
                    else
                    {
                        comparado = false;
                    }
                }
                //comparação com o email;
                /*using (MySqlCommand cmd = new MySqlCommand(queryemail, conexao))
                {
                    cmd.Parameters.AddWithValue("@email", email);
              

                    int count1 = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count1 == 1)
                    {
                        comparado = true;
                    }
                    else 
                    {
                        comparado = false;
                    }
                }*/

            }catch(Exception ex)
            {
                Console.WriteLine("Erro ao executar comando SQL: " + ex.Message);
            }
            finally
            {
                fecharconexao();
            }
            return comparado;
        }

    }
}
    

