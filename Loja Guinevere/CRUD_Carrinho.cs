using loja_Guinevere;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Guinevere
{
    public class CRUD_Carrinho : Carrinho
    {
        public CRUD_Carrinho()
        {

        }
      
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public void Cadastrar_Carrinho()
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "INSERT INTO carrinho (id_cliente) VALUES (@IdCliente)";
                cmd.Connection = banco;
                cmd.Parameters.AddWithValue("@IdCliente", Cliente);

                try
                {
                    cmd.CommandText = "INSERT INTO produto_carrinho (id_produto, id_carrinho, quantidade_prod) VALUES (@prod, @IdCarrinho, @QuantidadeProd)";
                    cmd.Connection = banco;
                    cmd.Parameters.AddWithValue("@prod", produtos);
                    cmd.Parameters.AddWithValue("@IdCarrinho", Id);
                    cmd.Parameters.AddWithValue("@QuantidaProd", quantidade_prod);
                    
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

        public List<CRUD_Carrinho> Ver_Carrinho()
        {
            List<CRUD_Carrinho> produtos_carrinhos = new List<CRUD_Carrinho>();

            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "SELECT * FROM produto_carrinho";
                cmd.Connection = banco;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CRUD_Carrinho Carrinho = new CRUD_Carrinho() 
                        {
                            produtos = (List<Produto>)reader.GetSqlValue(0),
                            Id = reader.GetInt32(1),
                            quantidade_prod = reader.GetInt32(2),
                        };
                        produtos_carrinhos.Add(Carrinho);
                    }
                }
            }

            return produtos_carrinhos;
        }


        
        

        public void Excluir_Carrinho(int id)
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "DELETE FROM carrinho WHERE id_Carrinho = @Id";
                cmd.Connection = banco;

                try
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    mensagem = "Carrinho Deletada";

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
        public void IncluirProduto(Produto produto)
        {
            produtos.Add(produto);
            quantidade_prod++;
        }

        public void ExcluirProduto(Produto produto)
        {
            produtos.Remove(produto);
            quantidade_prod--;
        }

        public List<Produto> VerLista()
        {
            return produtos;
        }

        public float ValorTotal()
        {
            Valor_total = 0;

            foreach (Produto produto in produtos)
            {
                Valor_total = (float)produto.Valor;
            }

            return Valor_total;
        }



    }




}


