using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace gf_materiais.forms
{
    internal class DAO
    {
        string conexaoString = "server=localhost;port=3307;Database=estoque;uid=root;pwd=''";
        MySqlConnection conexao;
        

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

        public DataTable tabelaEstoque()
        {
            DataTable tabela = new DataTable();
            
            try
            {
                abrirConexao();
                string comandosql = "SELECT Produto.nome, Produto.qnt_estoque, Produto.qnt_min, Produto.qnt_atual FROM Produto";
                MySqlDataAdapter adaptar = new MySqlDataAdapter(comandosql, conexao);
                adaptar.Fill(tabela);
            }
            catch (Exception ex)
            {
                Console.WriteLine("erro", ex.Message);
            }
            return tabela;
        }

        public DataTable tabelaFornecedor()
        {
            DataTable tabela = new DataTable();

            try
            {
                abrirConexao();
                string comandosql = "SELECT PessoaFornecedor.nome, PessoaFornecedor.email, PessoaFornecedor.cpf,  PessoaFornecedor.endereco, PessoaFornecedor.cnpj, PessoaFornecedor.telefone FROM PessoaFornecedor";
                MySqlDataAdapter adaptar = new MySqlDataAdapter(comandosql, conexao);
                adaptar.Fill(tabela);
            }
            catch (Exception ex)
            {
                Console.WriteLine("erro", ex.Message);
            }
            return tabela;
        }

        public void RemoverDoBanco(string comando, Dictionary<string, object> parametros)
        {
            try
            {
                abrirConexao();
                MySqlCommand cmd = new MySqlCommand(comando, conexao);
                foreach (var parametro in parametros)
                {
                    cmd.Parameters.AddWithValue(parametro.Key, parametro.Value);
                }
                cmd.ExecuteNonQuery();
                fecharconexao();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao remover do banco de dados: " + ex.Message);
            }
        }

        public bool ProdutoExiste(string nome)
        {
            bool comparar = false;
            try
            {
                abrirConexao();
                string comando = "SELECT COUNT(*) FROM Produto WHERE nome = @nome";
                MySqlCommand cmd = new MySqlCommand(comando, conexao);
                cmd.Parameters.AddWithValue("@nome", nome);
                int count = Convert.ToInt32(cmd.ExecuteScalar());


                if (count == 1)
                {
                    comparar = true;
                }
                else
                {
                    comparar = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar a existência do produto no banco de dados: " + ex.Message);
            }
            finally
            {
                fecharconexao();
            }
            return comparar;
        }

        public bool FornecedorExiste(string cpf, string cnpj, string telefone)
        {
            bool comparar = false;
            try
            {
                abrirConexao();
                string comando = "SELECT COUNT(*) FROM PessoaFornecedor WHERE cpf = @cpf OR cnpj = @cnpj OR telefone = @telefone";
                MySqlCommand cmd = new MySqlCommand(comando, conexao);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                
                if(count == 1)
                {
                    comparar = true;
                }
                else
                {
                    comparar = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao verificar a existência do fornecedor no banco de dados: " + ex.Message);
            }
            finally
            {
                fecharconexao();
            }
            return comparar;
        }

        public DataTable ProcurarProdutoPorNome(string nome)
        {
            DataTable dt = new DataTable();
            try
            {
                abrirConexao();
                string comando = "SELECT * FROM Produto WHERE nome LIKE @nome";
                MySqlCommand cmd = new MySqlCommand(comando, conexao);
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                fecharconexao();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao procurar produtos por nome: " + ex.Message);
            }
            return dt;
        }

        public int PegarUltimoID()
        {
            try
            {
                abrirConexao();
                MySqlCommand comandoSql = new MySqlCommand("SELECT LAST_INSERT_ID()", conexao);
                object resultadosDoID = comandoSql.ExecuteScalar();

                int IdObtido = Convert.ToInt32(resultadosDoID);

                return IdObtido;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter o último ID inserido: " + ex.Message);
                return -1;
            }
            finally
            {
                fecharconexao();
            }
        }

        
        public MySqlDataReader ObterDadosUsuario(int idUsuario)
        {
            string query = "SELECT usuario, nome_completo, email FROM Usuario WHERE idUsuario = @id";

            MySqlCommand command = new MySqlCommand(query, conexao);
            command.Parameters.AddWithValue("@id", idUsuario);

            return command.ExecuteReader();
        }

    }
}

    

    

