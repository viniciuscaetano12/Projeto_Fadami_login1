using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Fadami_login1.DAL
{
    internal class LoginDalComandosBase1
    {
    }

    internal class LoginDalComandos
    {
        public bool tem = false;
        public String mensagem = ""; // Tudo OK
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;


        public bool verificarLogin(String login, String senha)
        {
            // Neste método vms colocar os comandos SQL para verificar se tem no banco
            cmd.CommandText = "select * from logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) // se foi encontrado a informação de login no banco de dados
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com banco de dados!";
            }
            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            tem = false;
            //comandos para inserir
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "insert into logins values (@e,@s);";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                      cmd.Connection = con.Conectar();
                      cmd.ExecuteNonQuery();
                      con.desconectar();
                      this.mensagem = "Cadastrado com sucesso!";
                      tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com Banco de Dados";
                }
            }else
            { 
                   this.mensagem = "Senhas não correspondem!";
            }
               return mensagem;  
        }  
    }
}

  




            
        
        
    
