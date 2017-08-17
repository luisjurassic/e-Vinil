using e_Vinil.Entidades;
using e_Vinil.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace e_Vinil.DAL
{
    public class EnderecosDAL : IEntityEndereco<Enderecos>
    {
        DBConnection conn = new DBConnection();
        public void Inserir(Enderecos item)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO ENDERECOS VALUES(@CEP, @TIPO_RESIDENCIA, @RUA, @NUMERO,
                                       @COMPLEMENTO, @BAIRRO, @CIDADE, @ESTADO, @CLIENTE_ID)";
            cmd.Parameters.AddWithValue("@CEP", item.CEP);
            cmd.Parameters.AddWithValue("@TIPO_RESIDENCIA", item.Tipo_Residencia);
            cmd.Parameters.AddWithValue("@RUA", item.Rua);
            cmd.Parameters.AddWithValue("@NUMERO", item.Numero);
            cmd.Parameters.AddWithValue("@COMPLEMENTO", item.Complemento);
            cmd.Parameters.AddWithValue("@BAIRRO", item.Bairro);
            cmd.Parameters.AddWithValue("@CIDADE", item.Cidade);
            cmd.Parameters.AddWithValue("@ESTADO", item.Estado);
            cmd.Parameters.AddWithValue("@CLIENTE_ID", item.Cliente_id);
            conn.Execute(cmd);
        }

        public void Atualizar(Enderecos item)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE ENDERECOS SET CEP = @CEP, TIPO_RESIDENCIA = @TIPO_RESIDENCIA, RUA = @RUA, NUMERO = @NUMERO,
                                  COMPLEMENTO = @COMPLEMENTO, BAIRRO = @BAIRRO, CIDADE = @CIDADE, ESTADO = @ESTADO WHERE ENDERECOSID = @ENDERECOSID";
            cmd.Parameters.AddWithValue("@ENDERECOSID", item.EnderecosID);
            cmd.Parameters.AddWithValue("@CEP", item.CEP);
            cmd.Parameters.AddWithValue("@TIPO_RESIDENCIA", item.Tipo_Residencia);
            cmd.Parameters.AddWithValue("@RUA", item.Rua);
            cmd.Parameters.AddWithValue("@NUMERO", item.Numero);
            cmd.Parameters.AddWithValue("@COMPLEMENTO", item.Complemento);
            cmd.Parameters.AddWithValue("@BAIRRO", item.Bairro);
            cmd.Parameters.AddWithValue("@CIDADE", item.Cidade);
            cmd.Parameters.AddWithValue("@ESTADO", item.Estado);
            conn.Execute(cmd);
        }

        public List<Enderecos> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Enderecos BuscarEndereco(int item)
        {
            Enderecos endereco = new Enderecos();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT *FROM ENDERECOS WHERE CLIENTE_ID = @CLIENTE_ID";
            cmd.Parameters.AddWithValue("@CLIENTE_ID", item);

            conn.AttachCommand(cmd);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco.CEP = dr["CEP"].ToString();
                endereco.Tipo_Residencia = dr["TIPO_RESIDENCIA"].ToString();
                endereco.Rua = dr["RUA"].ToString();
                endereco.Numero = (int)dr["NUMERO"];
                endereco.Complemento = dr["COMPLEMENTO"].ToString();
                endereco.Bairro = dr["BAIRRO"].ToString();
                endereco.Cidade = dr["CIDADE"].ToString();
                endereco.Estado = dr["ESTADO"].ToString();
            }
            return endereco;
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }
    }
}