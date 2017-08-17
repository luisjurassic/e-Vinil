using e_Vinil.Entidades;
using e_Vinil.Interface;
using e_Vinil.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;

namespace e_Vinil.DAL
{
    public class UsuariosDAL : IEntityUsuario<Usuarios>
    {
        DBConnection conn = new DBConnection();
        public int Inserir(Usuarios item)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO USUARIOS VALUES(@USUARIO, @EMAIL, @SENHA, @ACESSO); SELECT SCOPE_IDENTITY()");
            cmd.Parameters.AddWithValue("@USUARIO", item.Usuario);
            cmd.Parameters.AddWithValue("@EMAIL", item.Email);
            cmd.Parameters.AddWithValue("@SENHA", item.Senha);
            cmd.Parameters.AddWithValue("@ACESSO", item.Acesso);
            try
            {
                return conn.ExecuteOnIdentity(cmd);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UKUSUARIO"))
                {
                    throw new Exception("Nome de usuário já cadastrado.");
                }
                if (ex.Message.Contains("UKEMAIL"))
                {
                    throw new Exception("EMAIL já cadastrado.");
                }
                throw new Exception("Erro no banco de dados.");
            }
        }

        public void Atualizar(Usuarios item)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE USUARIOS SET USUARIO = @USUARIO, EMAIL = @EMAIL, SENHA = @SENHA, ACESSO = @ACESSO WHERE USUARIOSID = @USUARIOSID";
            cmd.Parameters.AddWithValue("@USUARIOSID", item.UsuariosID);
            cmd.Parameters.AddWithValue("@USUARIO", item.Usuario);
            cmd.Parameters.AddWithValue("@EMAIL", item.Email);
            cmd.Parameters.AddWithValue("@SENHA", item.Senha);
            cmd.Parameters.AddWithValue("@ACESSO", item.Acesso);
            conn.Execute(cmd);
        }

        public Usuarios EnviarSenhaEmail(string item)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT *FROM USUARIOS WHERE EMAIL = @EMAIL");
            cmd.Parameters.AddWithValue("@EMAIL", item);
            try
            {
                conn.AttachCommand(cmd);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Usuarios usuario = new Usuarios();
                    usuario.Usuario = (string)reader["Usuario"];
                    usuario.Senha = (string)reader["Senha"];
                    return usuario;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Autenticar(Usuarios item)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT *FROM USUARIOS WHERE USUARIO = @USUARIO AND SENHA = @SENHA");
            cmd.Parameters.AddWithValue("@USUARIO", item.Usuario);
            cmd.Parameters.AddWithValue("@SENHA", item.Senha);
            try
            {
                conn.AttachCommand(cmd);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Usuarios usuario = new Usuarios();
                    usuario.UsuariosID = (int)reader["UsuariosID"];
                    usuario.Usuario = (string)reader["Usuario"];
                    usuario.Senha = (string)reader["Senha"];
                    usuario.Email = (string)reader["Email"];
                    usuario.Acesso = (Acesso)reader["Acesso"];
                    usuario.Imagem_perfil = (string)reader["Image"];
                    HttpContext.Current.Session["USER"] = usuario;
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("SQL"))
                {
                    throw new Exception("Erro no banco de dados.");
                }
                return false;
            }
        }

        public List<Usuarios> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Usuarios BuscarUsuario(int item)
        {
            Usuarios usuario = new Usuarios();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT *FROM USUARIOS WHERE USUARIOSID = @USUARIO_ID";
            cmd.Parameters.AddWithValue("@USUARIO_ID", item);

            conn.AttachCommand(cmd);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario.Usuario = dr["USUARIO"].ToString().Trim();
                usuario.Email = dr["EmAIL"].ToString().Trim();
                usuario.Senha = dr["SENHA"].ToString().Trim();
                usuario.Imagem_perfil = dr["IMAGE"].ToString().Trim();
            }
            return usuario;
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void ConvertToModel(Usuarios user)
        {
            ParametrosUsuario.UsuariosID = user.UsuariosID;
            ParametrosUsuario.Usuario = user.Usuario;
            ParametrosUsuario.Email = user.Email;
            ParametrosUsuario.Senha = user.Senha;
            ParametrosUsuario.Imagem_perfil = user.Imagem_perfil;
            ParametrosUsuario.Acesso = user.Acesso;
        }

    }
}