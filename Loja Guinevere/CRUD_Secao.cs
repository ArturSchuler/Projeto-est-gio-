using loja_Guinevere;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Guinevere
{
    public class CRUD_Secao: Secao
    {
        public CRUD_Secao()
        {

        }

        
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public void Cadastrar_Secao()
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "INSERT INTO secao (id_setor, nome_secao) VALUES (@SetorId, @Nome)";
                cmd.Connection = banco;

                try
                {

                    cmd.Parameters.AddWithValue("@SetorId", SetId);
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.ExecuteNonQuery();
                    mensagem = "Seção Cadastrada.";

                }
                catch (SqlException e)
                {
                    mensagem = "Erro ao cadastrar!";
                    throw;
                }
                finally
                {
                    conexao.desconectar();
                }
            }
        }

        public List<Secao> Ver_Secao()
        {
            List<Secao> Secoes = new List<Secao>();

            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "SELECT id_secao, id_setor, nome_secao FROM secao";
                cmd.Connection = banco;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Secao Secao = new Secao() // Passando os parâmetros corretos para o construtor
                        {
                            Id = reader.GetInt32(0),
                            SetId = reader.GetInt32(1),
                            Nome = reader.GetString(2),
                        };
                        Secoes.Add(Secao);
                    }
                }
            }

            return Secoes;
        }


        public void Alterar_Secao(Secao Secao)
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "UPDATE Secao SET id_setor = @SetorId, nome_secao = @Nome WHERE id_secao = @Id";
                cmd.Connection = banco;

                try
                {
                    cmd.Parameters.AddWithValue("@Id", Secao.Id);
                    cmd.Parameters.AddWithValue("@SetorId", Secao.SetId);
                    cmd.Parameters.AddWithValue("@Nome", Secao.Nome);
                    cmd.ExecuteNonQuery();
                    mensagem = "Seção Alterada";

                }
                catch (SqlException e)
                {
                    mensagem = "Erro ao atualizar!";
                    throw;
                }
                finally
                {
                    conexao.desconectar();
                }
            }

        }

        public void Excluir_Secao(int id)
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "DELETE FROM secao WHERE id_secao = @Id";
                cmd.Connection = banco;

                try
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    mensagem = "Seção Deletada";

                }
                catch (SqlException e)
                {
                    mensagem = "Erro ao excluir!";
                    throw;
                }
                finally
                {
                    conexao.desconectar();
                }
            }
        }
    }




}
    

