using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;


namespace Loja_Guinevere
{
    public class Conexao
    {

        SqlConnection con = new SqlConnection();
        public Conexao()
        {
            con.ConnectionString = @"Data Source=WINDOWS10;Initial Catalog=PROJETO_GUINEVERE;Integrated Security=True";
        }
        
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            
            return con;
        }
    
        public void desconectar()
        {

            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

           
        }    
    
    }

}
