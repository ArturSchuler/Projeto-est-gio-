using loja_Guinevere;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;



namespace Loja_Guinevere
{
    public class CRUD_Vitrine : Vitrine
    {
        public CRUD_Vitrine()
        {

        }

        
       
        
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public void Cadastrar_Vitrine()
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "INSERT INTO vitrine (id_produto) VALUES (@ProdId)";
                cmd.Connection = banco;

                try
                {

                    cmd.Parameters.AddWithValue("@ProdId", Prod_Id);
                    
                    cmd.ExecuteNonQuery();
                    mensagem = "Produto Cadastrado na Vitrine.";

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

        public List<CRUD_Vitrine> Ver_Vitrine()
        {
            List<CRUD_Vitrine> Vitrines = new List<CRUD_Vitrine>();
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "SELECT id_vitrine, id_produto FROM vitrine";
                cmd.Connection = banco;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CRUD_Vitrine Vitrine = new CRUD_Vitrine()
                        {
                            Id = reader.GetInt32(0),
                            Prod_Id = reader.GetInt32(1),
                            



                        };
                        Vitrines.Add(Vitrine);
                    }
                }
            }

            return Vitrines;
        }



        public void Alterar_Vitrine(Vitrine Vitrine)
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "UPDATE vitrine SET id_produto = @Prod_Id, WHERE id_vitrine = @Id";
                cmd.Connection = banco;

                try
                {
                    cmd.Parameters.AddWithValue("@Id", Vitrine.Id);
                    cmd.Parameters.AddWithValue("@Prod_Id", Vitrine.Prod_Id); 
                    
                    cmd.ExecuteNonQuery();
                    mensagem = "Vitrine Alterada";

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

        public void Excluir_Vitrine(int id)
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "DELETE FROM vitrine WHERE id_vitrine = @Id";
                cmd.Connection = banco;

                try
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    mensagem = "Vitrine Deletado";

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
