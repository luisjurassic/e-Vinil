using e_Vinil.DAL;
using e_Vinil.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Transactions;

namespace e_Vinil.Presentation
{
    public partial class CadastroProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USER"] == null)
            {
                Response.Redirect("Login.aspx");
            }

        }

        protected void btnConcluir_Click(object sender, EventArgs e)
        {
            Produtos produto = new Produtos();
            ProdutosDAL produtodal = new ProdutosDAL();
            using (TransactionScope scope = new TransactionScope())
            {

                produto.Codigo_Produto = txtCodProduto.Text;
                produto.Capa = file.FileName;
                produto.Artista = txtArtista.Text;
                produto.Album = txtAlbum.Text;
                produto.Ano = Convert.ToInt32(ddlAno.Text);
                produto.Genero = ddlGenero.Text;
                produto.Gravadora = txtGravadora.Text;
                produto.Informacoes = txtInfor.Text;
                produto.Preco = Convert.ToDouble(txtPreco.Text);
                int idproduto = produtodal.Inserir(produto);

                #region Funções salvar imagem
                try
                {
                    if (file.HasFile)
                    {
                        if (file.PostedFile.ContentLength < 2097152)
                        {
                            Boolean fileOK = false;
                            if (file.HasFile)
                            {
                                String fileExtension = System.IO.Path.GetExtension(file.FileName).ToLower();
                                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };

                                for (int i = 0; i < allowedExtensions.Length; i++)
                                {
                                    if (fileExtension == allowedExtensions[i])
                                    {
                                        fileOK = true;
                                    }
                                }
                            }

                            if (fileOK)
                            {
                                try
                                {
                                    string localImg = "/css/img/product/" + idproduto + System.IO.Path.GetExtension(file.FileName).ToLower();
                                    produtodal.AtualizarCapa(localImg, idproduto);
                                    file.SaveAs(Server.MapPath(localImg));
                                }
                                catch (Exception ex)
                                {
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "init", "<script>alert('" + ex.Message + ".');</script>");

                                }
                            }
                            else
                            {
                                string msg = "Só poderá carregar imagens neste campo.";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "init", "<script>alert('" + msg + ".');</script>");
                            }
                        }
                        else
                        {
                            string msg = "Limite máximo para a imagem é de 2MB.";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "init", "<script>alert('" + msg + ".');</script>");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                scope.Complete();
            }
                #endregion
            string msgSucesso = "Produto cadastrado com sucesso.";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "init", "<script>alert('" + msgSucesso + ".');</script>");
            Response.Redirect("Main.aspx");
        }
    }
}