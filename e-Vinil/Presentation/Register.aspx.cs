using e_Vinil.DAL;
using e_Vinil.Entidades;
using e_Vinil.Interface;
using System;
using System.Transactions;

namespace e_Vinil.Presentation
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }

        protected void btnConcluir_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Cliente cliente = new Cliente();
                ClientesDAL clientedal = new ClientesDAL();
                Usuarios usuario = new Usuarios();
                UsuariosDAL usuariodal = new UsuariosDAL();
                Enderecos endereco = new Enderecos();
                EnderecosDAL enderecodal = new EnderecosDAL();

                usuario.Usuario = txtUsuario.Text;
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;
                usuario.ConfirmaSenha(txtSenha.Text, txtConfirmeSenha.Text);
                usuario.Acesso = Acesso.Cliente;


                cliente.Nome = txtNome.Text;
                cliente.Sobrenome = txtSobrenome.Text;
                cliente.CPF = txtCPF.Text;
                cliente.Data_Nascimento = Convert.ToDateTime(txtDataN.Text);
                cliente.Sexo = ddlSexo.Text;
                cliente.Telefone = txtContato.Text;
                cliente.Celular = txtCelular.Text;
                cliente.Usuario_id = usuariodal.Inserir(usuario);
                #region Funções salvar imagem
                if (file_import.HasFile)
                {
                    if (file_import.PostedFile.ContentLength < 2097152)
                    {
                        Boolean fileOK = false;
                        if (file_import.HasFile)
                        {
                            String fileExtension = System.IO.Path.GetExtension(file_import.FileName).ToLower();
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
                                string localImg = "/css/img/account/" + txtUsuario.Text + System.IO.Path.GetExtension(file_import.FileName).ToLower();
                                usuario.Imagem_perfil = localImg;
                                file_import.SaveAs(Server.MapPath(localImg));
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

                    scope.Complete();
                }
                #endregion

                endereco.CEP = txtCep.Text;
                endereco.Tipo_Residencia = ddlTipoEndereco.Text;
                endereco.Rua = txtRua.Text;
                endereco.Numero = Convert.ToInt32(txtNumero.Text);
                endereco.Complemento = txtComplemento.Text;
                endereco.Bairro = txtBairro.Text;
                endereco.Cidade = txtCidade.Text;
                endereco.Estado = ddlEstado.Text;
                endereco.Cliente_id = clientedal.Inserir(cliente);
                enderecodal.Inserir(endereco);

                scope.Complete();
            }
            Response.Redirect("Main.aspx");
        }
    }
}