using loja_Guinevere;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Guinevere
{
    public class CRUD_Setor: Setor
    {     
        public CRUD_Setor()
        {
           
        }

        
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public void Cadastrar_setor()
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "INSERT INTO setor (id_departamento, nome_setor) VALUES (@DepartamentoId, @Nome)";
                cmd.Connection = banco;

                try
                {
                    
                    cmd.Parameters.AddWithValue("@DepartamentoId", DepId);
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.ExecuteNonQuery();
                    mensagem = "Setor Cadastrado.";
                    
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

        public List<Setor> Ver_setor()
        {
            List<Setor> setores = new List<Setor>();

            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "SELECT id_setor, id_departamento, nome_setor FROM setor";
                cmd.Connection = banco;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Setor setor = new Setor() // Passando os parâmetros corretos para o construtor
                        {
                            Id = reader.GetInt32(0),
                            DepId = reader.GetInt32(1),
                            Nome = reader.GetString(2),
                        };
                        setores.Add(setor);
                    }
                }
            }

            return setores;
        }


        public void Alterar_setor(Setor setor)
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "UPDATE setor SET id_departamento = @DepartamentoId, nome_setor = @Nome WHERE id_setor = @Id";
                cmd.Connection = banco;

                try
                {
                    cmd.Parameters.AddWithValue("@Id", setor.Id);
                    cmd.Parameters.AddWithValue("@DepartamentoId", setor.DepId);
                    cmd.Parameters.AddWithValue("@Nome", setor.Nome);
                    cmd.ExecuteNonQuery();
                    mensagem = "Setor Alterado";
                    
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

        public void Excluir_setor(int id)
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "DELETE FROM setor WHERE id_setor = @Id";
                cmd.Connection = banco;

                try
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    mensagem = "Setor Deletado";
                    
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

