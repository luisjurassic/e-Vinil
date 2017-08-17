using e_Vinil.DAL;
using e_Vinil.Entidades;
using e_Vinil.Model;
using System;
using System.Web.UI;

namespace e_Vinil.Presentation
{
    public partial class e_Vinil : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USER"] != null)
            {
                UsuariosDAL user = new UsuariosDAL();

                user.ConvertToModel((Usuarios)Session["USER"]);
                image_perfil.ImageUrl = ParametrosUsuario.Imagem_perfil;
                lblUser.Text = ParametrosUsuario.Usuario;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }

        protected void Unnamed_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("EditRegister.aspx");
        }
    }
}