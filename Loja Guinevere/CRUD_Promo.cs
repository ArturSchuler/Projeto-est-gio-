using loja_Guinevere;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Guinevere
{
    public class CRUD_Promo: Promocoes
    {
        

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public void Cadastrar_promocao(List<Produto> produtos, List<Secao> secoes, List<Setor> setores, List<Departamento> departamentos)
        {
            using (SqlConnection banco = conexao.conectar())
            {
                try
                {
                    cmd.CommandText = "INSERT INTO promocoes (dt_Fim, dt_inicio) VALUES (@Fim, @Inicio)";
                    cmd.Parameters.AddWithValue("@Fim", Dt_fim);
                    cmd.Parameters.AddWithValue("@Inicio", Dt_inicio);
                    cmd.Connection = banco;
                    cmd.ExecuteNonQuery();  

                    switch (Grau)
                    {
                        case 1:
                            cmd.CommandText = "INSERT INTO promo_dep (desconto_perc, desconto_valor) VALUES (@DP, @DV)";
                            cmd.Parameters.AddWithValue("@DP", DescontoPerc);
                            cmd.Parameters.AddWithValue("@DV", DescontoValor);
                            cmd.ExecuteNonQuery();

                            foreach (var DepId in setores)
                            {
                                foreach (var SetId in secoes)
                                {
                                    foreach (var SecId in produtos)
                                    {
                                        foreach (var produto in produtos)
                                        {
                                            produto.Valor = produto.Valor - DescontoValor;
                                            produto.Valor = produto.Valor - (produto.Valor * (DescontoPerc / 100));

                                            cmd.CommandText = "UPDATE produto SET valor_produto = @Preco WHERE id_produto = @Id";
                                            cmd.Parameters.AddWithValue("@Preco", produto.Valor);
                                            cmd.Parameters.AddWithValue("@Id", produto.Id);
                                            cmd.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                            break;


                        case 2:
                            {
                                cmd.CommandText = "INSERT INTO promo_setor (desconto_perc, desconto_valor) VALUES (@DP, @DV)";
                                cmd.Connection = banco;
                                cmd.Parameters.AddWithValue("@DP", DescontoPerc);
                                cmd.Parameters.AddWithValue("@DV", DescontoValor);

                                foreach (var Setid in secoes)
                                {
                                    foreach (var SecId in produtos)
                                    {
                                        foreach (var produto in produtos)
                                        {
                                            produto.Valor = produto.Valor - DescontoValor;
                                            produto.Valor = produto.Valor - (produto.Valor * (DescontoPerc / 100));

                                            cmd.CommandText = "UPDATE produto SET valor_produto = @Preco WHERE id_produto = @Id";
                                            cmd.Connection = banco;
                                            cmd.Parameters.AddWithValue("@Preco", produto.Valor);
                                            cmd.ExecuteNonQuery();
                                        }

                                    }
                                }
                            }
                            break;

                        case 3:
                            {
                                cmd.CommandText = "INSERT INTO promo_secao (desconto_perc, desconto_valor) VALUES (@DP, @DV)";
                                cmd.Connection = banco;
                                cmd.Parameters.AddWithValue("@DP", DescontoPerc);
                                cmd.Parameters.AddWithValue("@DV", DescontoValor);

                                foreach (var SecId in produtos)
                                {
                                    foreach (var produto in produtos)
                                    {
                                        produto.Valor = produto.Valor - DescontoValor;
                                        produto.Valor = produto.Valor - (produto.Valor * (DescontoPerc / 100));

                                        cmd.CommandText = "UPDATE produto SET valor_produto = @Preco WHERE id_produto = @Id";
                                        cmd.Connection = banco;
                                        cmd.Parameters.AddWithValue("@Preco", produto.Valor);
                                        cmd.ExecuteNonQuery();
                                    }

                                }
                            }
                            break;

                        case 4:
                            {
                                foreach (var produto in produtos)
                                {
                                    cmd.CommandText = "INSERT INTO promo_produto (desconto_perc, desconto_valor) VALUES (@DP, @DV)";
                                    cmd.Connection = banco;
                                    cmd.Parameters.AddWithValue("@DP", DescontoPerc);
                                    cmd.Parameters.AddWithValue("@DV", DescontoValor);

                                    produto.Valor = produto.Valor - DescontoValor;
                                    produto.Valor = produto.Valor - (produto.Valor * (DescontoPerc / 100));

                                    cmd.CommandText = "UPDATE produto SET valor_produto = @Preco WHERE id_produto = @Id";
                                    cmd.Connection = banco;
                                    cmd.Parameters.AddWithValue("@Preco", produto.Valor);
                                    cmd.ExecuteNonQuery();
                                }

                            }

                            break;
                    }




                    cmd.ExecuteNonQuery();
                    mensagem = "Promoção Cadastrada.";

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


        public List<CRUD_Promo> Ver_promocao()
        {
            List<CRUD_Promo> promocoes = new List<CRUD_Promo>();
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "SELECT id_promo, dt_Fim, dt_inicio FROM promocoes";
                cmd.Connection = banco;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CRUD_Promo promocao = new CRUD_Promo()
                        {
                            Id = reader.GetInt32(0),
                            Dt_fim = reader.GetDateTime(1),
                            Dt_inicio = reader.GetDateTime(2)
                        };
                        promocoes.Add(promocao);
                    }
                }
            }

            return promocoes;
        }







        public void Alterar_promocao(CRUD_Promo promocao)
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "UPDATE promocoes SET dt_Fim = @Fim, dt_inicio = @Inicio WHERE id_promo = @Id";
                cmd.Connection = banco;

                try
                {
                    cmd.Parameters.AddWithValue("@Id", promocao.Id);
                    cmd.Parameters.AddWithValue("@Fim", promocao.Dt_fim);
                    cmd.Parameters.AddWithValue("@Inicio", promocao.Dt_inicio);
                    cmd.ExecuteNonQuery();
                    mensagem = "Promoção Alterada";

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

        public void Excluir_promocao(int id)
        {
            using (SqlConnection banco = conexao.conectar())
            {
                
                List<Produto> produtosAfetados = ObterProdutosDaPromocao(id);

                
                foreach (var produto in produtosAfetados)
                {
                    cmd.CommandText = "UPDATE produto SET valor_produto = preco_original WHERE id_produto = @Id";
                    cmd.Connection = banco;
                    
                    cmd.Parameters.AddWithValue("@Id", produto.Id);
                    cmd.ExecuteNonQuery();
                }

                cmd.CommandText = "DELETE FROM promocoes WHERE id_promo = @Id";
                cmd.Connection = banco;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();

                mensagem = "Promoção Deletada";
            }
        }

        private List<Produto> ObterProdutosDaPromocao(int id)
        {
            throw new NotImplementedException();
        }
    }
}



















