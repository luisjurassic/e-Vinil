using e_Vinil.Entidades;
using e_Vinil.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace e_Vinil.DAL
{
    public class ProdutosDAL : IEntityProduto<Produtos>
    {
        DBConnection conn = new DBConnection();
        public int Inserir(Produtos item)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO PRODUTOS VALUES(@CODIGO_PRODUTO, @CAPA, @ARTISTA, @ALBUM,
                                       @ANO, @GENERO, @GRAVADORA, @INFORMACOES, @PRECO); SELECT SCOPE_IDENTITY()";
            cmd.Parameters.AddWithValue("@CODIGO_PRODUTO", item.Codigo_Produto);
            cmd.Parameters.AddWithValue("@CAPA", item.Capa);
            cmd.Parameters.AddWithValue("@ARTISTA", item.Artista);
            cmd.Parameters.AddWithValue("@ALBUM", item.Album);
            cmd.Parameters.AddWithValue("@ANO", item.Ano);
            cmd.Parameters.AddWithValue("@GENERO", item.Genero);
            cmd.Parameters.AddWithValue("@GRAVADORA", item.Gravadora);
            cmd.Parameters.AddWithValue("@INFORMACOES", item.Informacoes);
            cmd.Parameters.AddWithValue("@PRECO", item.Preco);
            try
            {
                return conn.ExecuteOnIdentity(cmd);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UKPRODUTO"))
                {
                    throw new Exception("Código do produto já cadastrado.");
                }
                throw new Exception("Erro no banco de dados.");
            }
        }

        public int Atualizar(Produtos item)
        {
            throw new NotImplementedException();
        }

        public void AtualizarCapa(string local, int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE PRODUTOS SET CAPA = @CAPA WHERE PRODUTOSID = @PRODUTOSID";
            cmd.Parameters.AddWithValue("@PRODUTOSID", id);
            cmd.Parameters.AddWithValue("@CAPA", local);
            conn.Execute(cmd);
        }

        public List<Produtos> BuscarTodosColuna()
        {
            List<Produtos> list = new List<Produtos>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT *FROM PRODUTOS";

            conn.AttachCommand(cmd);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Produtos produtos = new Produtos();
                produtos.ProdutosID = (int)dr["PRODUTOSID"];
                produtos.Codigo_Produto = dr["CODIGO_PRODUTO"].ToString();
                produtos.Capa = dr["CAPA"].ToString();
                produtos.Artista = dr["ARTISTA"].ToString();
                produtos.Album = dr["ALBUM"].ToString();
                produtos.Ano = (int)dr["ANO"];
                produtos.Genero = dr["GENERO"].ToString();
                produtos.Gravadora = dr["GRAVADORa"].ToString();
                produtos.Informacoes = dr["INFORMACOES"].ToString();
                produtos.Preco = Convert.ToDouble((Decimal)dr["PRECO"]);
                list.Add(produtos);
            }
            cmd.Connection.Close();
            return list;
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }
    }
}