using loja_Guinevere;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Loja_Guinevere
{
    public class CRUD_Desconto : Promocoes // tipo_pagamento
    {
        public CRUD_Desconto()
        {

        }
        
        
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public void Cadastrar_Desconto()
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "INSERT INTO tipo_pagamento (desc_valor)VALUES(@Valor)";
                cmd.Connection = banco;
                try
                {

                    cmd.Parameters.AddWithValue("@Valor", desc_valor);
                    cmd.ExecuteNonQuery();
                    mensagem = "Desconto Cadastrado.";

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

        public List<CRUD_Desconto> Ver_Desconto()
        {
            List<CRUD_Desconto> Secoes = new List<CRUD_Desconto>();

            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "SELECT * FROM Tipo_pagamento WHERE id_tipo_pag = @Id";
                cmd.Connection = banco;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CRUD_Desconto Desconto = new CRUD_Desconto() 
                        {
                            Id = reader.GetInt32(0),                           
                            desc_valor = reader.GetFloat(1),
                        };
                        Secoes.Add(Desconto);
                    }
                }
            }

            return Secoes;
        }


        public void Alterar_Desconto(CRUD_Desconto Desconto)
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "UPDATE tipo_pagamento SET desc_valor = @Valor WHERE id_tipo_pag = @Id";
                cmd.Connection = banco;

                try
                {
                    
                    cmd.Parameters.AddWithValue("@Valor", desc_valor);
                    cmd.ExecuteNonQuery();
                    mensagem = "desconto Alterado";

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

        public void Excluir_Desconto(int id)
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "DELETE FROM tipo_pagamento WHERE id_tipo_pag = @Id";
                cmd.Connection = banco;

                try
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    mensagem = "desconto Deletado";

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


