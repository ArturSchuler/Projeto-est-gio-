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
    public class CRUD_Produto: Produto
    {
        

        public CRUD_Produto()
        {
        }

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public void Cadastrar_Produto()
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "INSERT INTO produto (id_secao, nome_produto, valor_produto, marca, resumo, detalhe, servico, valor_original, foto) VALUES (@SecaoId, @Nome, @Valor, @Marca, @Resumo, @Detalhe, @Servico, @valor_original, @Foto)";
                cmd.Connection = banco;

                try
                {

                    cmd.Parameters.AddWithValue("@SecaoId", SecId);
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@Valor", Valor);
                    cmd.Parameters.AddWithValue("@Marca", Marca);
                    cmd.Parameters.AddWithValue("@Resumo", Resumo);
                    cmd.Parameters.AddWithValue("@Detalhe", Detalhe);
                    cmd.Parameters.AddWithValue("@Servico", Servico);
                    cmd.Parameters.AddWithValue("@valor_original", Valor_original);
                    cmd.Parameters.AddWithValue("@Foto", (object)Foto);                   
                    cmd.ExecuteNonQuery();
                    mensagem = "Produto Cadastrado.";

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

        public List<Produto> Ver_Produto()
        {
            List<Produto> produtos = new List<Produto>();
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "SELECT id_produto, id_secao, nome_produto, valor_produto, marca, resumo, detalhe, servico, valor_original, foto FROM produto";
                cmd.Connection = banco;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Produto Produto = new Produto()
                        {
                            Id = reader.GetInt32(0),
                            SecId = reader.GetInt32(1),
                            Nome = reader.GetString(2),
                            Valor = reader.GetDouble(3),
                            Marca = reader.GetString(4),
                            Resumo = reader.GetString(5),
                            Detalhe = reader.GetString(6),
                            Servico = reader.GetInt32(7) == 1,
                            Valor_original = reader.GetDouble(8),
                            Foto = reader["foto"] == DBNull.Value ? null : (byte[])reader["foto"] //ESSE DEU TRABALHO ATE PARA O GPT



                    };
                        produtos.Add(Produto);
                    }
                }
            }

            return produtos;
        }



        public void Alterar_Produto(CRUD_Produto Produto)
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "UPDATE produto SET id_secao = @SecId, nome_produto = @Nome, valor_produto = @Valor, marca = @Marca, resumo = @Resumo, detalhe = @Detalhe, servico = @Servico, valor_original = @preco_original, foto = @Foto WHERE id_produto = @Id";
                cmd.Connection = banco;

                try
                {
                    cmd.Parameters.AddWithValue("@Id", Produto.Id);
                    cmd.Parameters.AddWithValue("@SecId", Produto.SecId);
                    cmd.Parameters.AddWithValue("@Nome", Produto.Nome);
                    cmd.Parameters.AddWithValue("@Valor", Produto.Valor);
                    cmd.Parameters.AddWithValue("@Marca", Produto.Marca);
                    cmd.Parameters.AddWithValue("@Resumo", Produto.Resumo);
                    cmd.Parameters.AddWithValue("@Detalhe", Produto.Detalhe);
                    cmd.Parameters.AddWithValue("@Servico", Produto.Servico);
                    cmd.Parameters.AddWithValue("@preco_original", Produto.Valor_original);
                    cmd.Parameters.AddWithValue("@Foto", (object)Produto.Foto ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                    mensagem = "Produto Alterado";

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

        public void Excluir_Produto(int id)
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "DELETE FROM produto WHERE id_produto = @Id";
                cmd.Connection = banco;

                try
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    mensagem = "Produto Deletado";

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
