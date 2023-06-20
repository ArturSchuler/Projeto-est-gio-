using loja_Guinevere;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Guinevere
{
    public class Venda : Carrinho
    {
        public Venda()
        {

        }

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public void AplicarDesconto(CRUD_Desconto desconto)
        {
            if (Tipo_pag == "PIX" && desconto != null)
            {
                float desc_valor = desconto.desc_valor;

                if (desc_valor != 0.0f)
                {
                    Valor_total = Valor_total - desc_valor;
                }
            }
        }

        public void Gerar_Venda()
        {
            CRUD_Desconto desconto = new CRUD_Desconto();

            AplicarDesconto(desconto);

            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "INSERT INTO venda (Data, Valor_total, Tipo_pag, Id_cliente, Id_desconto) VALUES (@Data, @Valor_total, @Tipo_pag, @Id_cliente, @Id_desconto)";
                cmd.Connection = banco;

                try
                {
                    cmd.Parameters.AddWithValue("@Data", Data);
                    cmd.Parameters.AddWithValue("@Valor_total", Valor_total);
                    cmd.Parameters.AddWithValue("@Tipo_pag", Tipo_pag);
                    cmd.Parameters.AddWithValue("@Id_cliente", Id_cliente);
                    cmd.Parameters.AddWithValue("@Id_desconto", Id_desconto);
                    cmd.ExecuteNonQuery();
                    mensagem = "Venda";
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


        public List<Venda> Ver_Venda()
        {
            List<Venda> Secoes = new List<Venda>();

            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "SELECT * FROM venda WHERE Id_venda = @Id";
                cmd.Connection = banco;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Venda Venda = new Venda() // Passando os parâmetros corretos para o construtor
                        {
                            Id = reader.GetInt32(0),
                            Data = reader.GetDateTime(1),
                            Valor_total = reader.GetFloat(2),
                            Tipo_pag = reader.GetString(3),
                            Id_cliente = reader.GetInt32(4),
                            Id_desconto = reader.GetInt32(5),
                            
                        };
                        Secoes.Add(Venda);
                    }
                }
            }

            return Secoes;
        }


       

        public void Excluir_Venda(int id)
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "DELETE FROM Venda WHERE id_venda = @Id";
                cmd.Connection = banco;

                try
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    mensagem = "Venda Deletada";

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


