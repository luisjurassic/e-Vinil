using e_Vinil.DAL;
using e_Vinil.Entidades;
using System;
using System.Web.UI;

namespace e_Vinil.Presentation
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void linkSenha_Click(object sender, EventArgs e)
        {
            Response.Redirect("ResetPassword.aspx");
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            UsuariosDAL usuariodal = new UsuariosDAL();
            usuario.Usuario = txtLogin.Text;
            usuario.Senha = txtSenha.Text;

            bool sucess = usuariodal.Autenticar(usuario);
            if (!sucess)
            {
                string msg = "Usuario e/ou senha inválidos.";
                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "error", "alert('" + msg + "')", true);
            }
            Response.Redirect("Main.aspx");
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}