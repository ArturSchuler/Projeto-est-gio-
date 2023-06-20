using loja_Guinevere;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;



namespace Loja_Guinevere
{
    public class CRUD_Cliente: Cliente
    {
        public CRUD_Cliente()
        {

        }
        
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public void Cadastrar_Cliente()
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "INSERT INTO cliente (nome, sobrenome, email, fone, user_name, password) VALUES (@Nome, @Sobrenome, @Email, @Fone, @Usuario, @Senha); SELECT SCOPE_IDENTITY()";
                cmd.Connection = banco;

                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Sobrenome", sobrenome);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Fone", fone);
                cmd.Parameters.AddWithValue("@Usuario", user_name);
                cmd.Parameters.AddWithValue("@Senha", password);

                try
                {
                    // Execute the command and get the ID of the newly inserted client.
                    int newId = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd.CommandText = "INSERT INTO endereco (Id_Cliente, endereco, CEP, bairro, cidade, estado) VALUES (@Id_Cliente, @Endereco, @CEP, @Bairro, @Cidade, @UF)";
                    cmd.Parameters.AddWithValue("@Id_Cliente", newId);
                    cmd.Parameters.AddWithValue("@Endereco", endereco);
                    cmd.Parameters.AddWithValue("@CEP", cep);
                    cmd.Parameters.AddWithValue("@Bairro", bairro);
                    cmd.Parameters.AddWithValue("@Cidade", cidade);
                    cmd.Parameters.AddWithValue("@UF", estado);

                    cmd.ExecuteNonQuery();
                    mensagem = "Cliente Cadastrado.";
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


        public List<CRUD_Cliente> Ver_Cliente()
        {
            List<CRUD_Cliente> Clientes = new List<CRUD_Cliente>();

            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "SELECT c.id_cliente, c.nome, c.sobrenome, c.email, c.fone, e.id_endereco, e.endereco, e.CEP, e.bairro, e.cidade, e.estado " +
                                  "FROM cliente c INNER JOIN endereco e ON c.id_cliente = e.Id_Cliente";
                cmd.Connection = banco;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CRUD_Cliente Cliente = new CRUD_Cliente()
                        {
                            Id = reader.GetInt32(0),
                            nome = reader.GetString(1),
                            sobrenome = reader.GetString(2),
                            email = reader.GetString(3),
                            fone = reader.GetString(4),
                            id_endereco = reader.GetInt32(5),
                            endereco = reader.GetString(6),
                            cep = reader.GetString(7),
                            bairro = reader.GetString(8),
                            cidade = reader.GetString(9),
                            estado = reader.GetString(10)
                        };

                        Clientes.Add(Cliente);
                    }
                }
            }

            return Clientes;
        }




        public void Alterar_Cliente(Cliente Cliente)
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "UPDATE cliente SET nome=@Nome, sobrenome=@Sobrenome, email=@Email, fone=@Fone, user_name=@Usuario, password=@Senha WHERE id_cliente = @Id";
                cmd.Connection = banco;

                cmd.Parameters.AddWithValue("@Id", Cliente.Id);
                cmd.Parameters.AddWithValue("@Nome", Cliente.nome);
                cmd.Parameters.AddWithValue("@Sobrenome", Cliente.sobrenome);
                cmd.Parameters.AddWithValue("@Email", Cliente.email);
                cmd.Parameters.AddWithValue("@Fone", Cliente.fone);
                cmd.Parameters.AddWithValue("@Usuario", Cliente.user_name);
                cmd.Parameters.AddWithValue("@Senha", Cliente.password);

                try
                {
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "UPDATE endereco SET endereco=@Endereco, CEP=@CEP, bairro=@Bairro, cidade=@Cidade, estado=@UF WHERE Id_Cliente = @Id";
                    cmd.Parameters.AddWithValue("@Endereco", Cliente.endereco);
                    cmd.Parameters.AddWithValue("@CEP", Cliente.cep);
                    cmd.Parameters.AddWithValue("@Bairro", Cliente.bairro);
                    cmd.Parameters.AddWithValue("@Cidade", Cliente.cidade);
                    cmd.Parameters.AddWithValue("@UF", Cliente.estado);

                    cmd.ExecuteNonQuery();

                    mensagem = "Cliente Alterado";
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


        public void Excluir_Cliente(int id)
        {
            using (SqlConnection banco = conexao.conectar())
            {
                cmd.CommandText = "DELETE FROM cliente WHERE id_cliente = @Id";
                
                cmd.Connection = banco;

                try
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    mensagem = "Cliente Deletado";

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
