using loja_Guinevere;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Loja_Guinevere
{
    public class CRUD_Dep : Departamento
    {    
        public CRUD_Dep()
        {
            
            
        }

       

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;
        public string e = "";

        public void Cadastrar_dep()
        {
            using (SqlConnection banco = conexao.conectar())
            {

                cmd.CommandText = "INSERT INTO departamento (nome_dep) VALUES (@Nome)";
                cmd.Connection = banco;

                try
                {
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.ExecuteNonQuery();
                    mensagem = "Cadastrado!!";
                    
                }
                catch (SqlException e)
                {
                    mensagem = "Erro!";

                    throw;
                }
                finally
                {
                    conexao.desconectar();
                }
            }


        }

        public List<CRUD_Dep> Ver_dep()
        {
            List<CRUD_Dep> departamentos = new List<CRUD_Dep>();

            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "SELECT id_departamento, nome_dep FROM departamento";
                cmd.Connection = banco;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CRUD_Dep departamento = new CRUD_Dep()
                        {
                            Id = reader.GetInt32(0),
                            Nome = reader.GetString(1)
                        };
                        departamentos.Add(departamento);
                    }
                }
            }

            return departamentos;
        }


        public void Alterar_dep(Departamento departamento)
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "UPDATE departamento SET nome_dep = @Nome WHERE id_departamento = @Id";
                cmd.Connection = banco;

                try
                {
                    cmd.Parameters.AddWithValue("@Id", departamento.Id);
                    cmd.Parameters.AddWithValue("@Nome", departamento.Nome);
                    cmd.ExecuteNonQuery();
                    mensagem = "Departamento Alterado.";
                    
                }
                catch (SqlException e)
                {
                    mensagem = "Erro ao atualizar o registro!";
                    throw;
                }
                finally
                {
                    conexao.desconectar();
                }
            }
        }

        public void Excluir_dep(int id)
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "DELETE FROM departamento WHERE id_departamento = @Id";
                cmd.Connection = banco;

                try
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    mensagem = "Departamento deletado.";
                    
                }
                catch (SqlException e)
                {
                    mensagem = "Erro ao excluir o registro!";
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