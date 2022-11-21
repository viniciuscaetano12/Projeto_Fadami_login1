using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Fadami_login1.DAL
{
    public class Conexao 
    {
        SqlConnection con = new SqlConnection();
        public Conexao()
        {
            con.ConnectionString = "@Data Source=desktop-p92p4ve;Initial Catalog=Projeto_Fadami_Login1.0;Integrated Security=True";
        }

        public SqlConnection Conectar()
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

