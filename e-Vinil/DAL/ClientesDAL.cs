using e_Vinil.Entidades;
using e_Vinil.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace e_Vinil.DAL
{
    public class ClientesDAL : IEntityCliente<Cliente>
    {
        DBConnection conn = new DBConnection();
        public int Inserir(Cliente item)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO CLIENTES VALUES(@NOME, @SOBRENOME, @CPF, @DATA_NASCIMENTO,
                                       @SEXO, @TELEFONE, @CELULAR, @USUARIO_ID); SELECT SCOPE_IDENTITY()";
            cmd.Parameters.AddWithValue("@NOME", item.Nome);
            cmd.Parameters.AddWithValue("@SOBRENOME", item.Sobrenome);
            cmd.Parameters.AddWithValue("@CPF", item.CPF);
            cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", item.Data_Nascimento);
            cmd.Parameters.AddWithValue("@SEXO", item.Sexo);
            cmd.Parameters.AddWithValue("@TELEFONE", item.Telefone);
            cmd.Parameters.AddWithValue("@CELULAR", item.Celular);
            cmd.Parameters.AddWithValue("@USUARIO_ID", item.Usuario_id);
            try
            {
                return conn.ExecuteOnIdentity(cmd);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UKCPF"))
                {
                    throw new Exception("CPF já cadastrado.");
                }
                throw new Exception("Erro no banco de dados.");
            }
        }

        public void Atualizar(Cliente item)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE CLIENTES SET NOME = @NOME, SOBRENOME = @SOBRENOME, DATA_NASCIMENTO = @DATA_NASCIMENTO,
                            SEXO = @SEXO, TELEFONE = @TELEFONE, CELULAR = @CELULAR WHERE CLIENTESID = @CLIENTESID";
            cmd.Parameters.AddWithValue("@CLIENTESID", item.ClientesID);
            cmd.Parameters.AddWithValue("@NOME", item.Nome);
            cmd.Parameters.AddWithValue("@SOBRENOME", item.Sobrenome);
            cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", item.Data_Nascimento);
            cmd.Parameters.AddWithValue("@SEXO", item.Sexo);
            cmd.Parameters.AddWithValue("@TELEFONE", item.Telefone);
            cmd.Parameters.AddWithValue("@CELULAR", item.Celular);
            conn.Execute(cmd);
        }

        public List<Cliente> BuscarTodos()
        {
            List<Cliente> list = new List<Cliente>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT *FROM CLIENTES";

            conn.AttachCommand(cmd);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cliente clientes = new Cliente();
                clientes.Nome = dr["NOME"].ToString().Trim();
                clientes.Sobrenome = dr["SOBRENOME"].ToString().Trim();
                clientes.Data_Nascimento = Convert.ToDateTime(dr["DATA_NASCIMENTO"]);
                clientes.Sexo = dr["SEXO"].ToString().Trim();
                clientes.Telefone = dr["TELEFONE"].ToString().Trim();
                clientes.Celular = dr["CELULAR"].ToString().Trim();
                list.Add(clientes);
            }
            return list;
        }

        public Cliente BuscarCliente(int id)
        {
            Cliente clientes = new Cliente();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT *FROM CLIENTES WHERE USUARIO_ID = @USUARIO_ID";
            cmd.Parameters.AddWithValue("@USUARIO_ID", id);

            conn.AttachCommand(cmd);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clientes.ClientesID = (int)dr["CLIENTESID"];
                clientes.Nome = dr["NOME"].ToString().Trim();
                clientes.Sobrenome = dr["SOBRENOME"].ToString().Trim();
                clientes.Data_Nascimento = Convert.ToDateTime(dr["DATA_NASCIMENTO"]);
                clientes.CPF = dr["CPF"].ToString().Trim();
                clientes.Sexo = dr["SEXO"].ToString().Trim();
                clientes.Telefone = dr["TELEFONE"].ToString().Trim();
                clientes.Celular = dr["CELULAR"].ToString().Trim();
                clientes.Usuario_id = (int)dr["USUARIO_ID"];
            }
            return clientes;
        }

        public void Excluir(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"DELETE CLIENTES WHERE CPF = @CPF";
            cmd.Parameters.AddWithValue("@CPF", id);
            conn.Execute(cmd);
        }
    }
}

/*
SELECT ENDERECOS.CEP,
       ENDERECOS.TIPO_RESIDENCIA,
       ENDERECOS.RUA, 
       ENDERECOS.NUMERO,
       ENDERECOS.COMPLEMENTO,
       ENDERECOS.BAIRRO, 
       ENDERECOS.CIDADE,
       ENDERECOS.ESTADO, 
       CLIENTES.NOME,
       CLIENTES.SOBRENOME, CLIENTES.CPF,
       CLIENTES.DATA_NASCIMENTO,
       CLIENTES.SEXO, 
       CLIENTES.TELEFONE,
       CLIENTES.CELULAR, 
       USUARIOS.USUARIO,
       USUARIOS.EMAIL,
       USUARIOS.SENHA,
       USUARIOS.Image
  FROM ENDERECOS
  INNER JOIN  CLIENTES ON CLIENTES.CLIENTESID = ENDERECOS.CLIENTE_ID
  INNER JOIN USUARIOS ON USUARIOS.USUARIOSID = CLIENTES.USUARIO_ID WHERE USUARIOS.USUARIOSID = @USUARIOSID
 */