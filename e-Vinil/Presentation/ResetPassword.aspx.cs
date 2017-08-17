using e_Vinil.DAL;
using e_Vinil.Entidades;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace e_Vinil.Presentation
{
    public partial class ResetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            UsuariosDAL usuariodal = new UsuariosDAL();
            SmtpClient enviarsenha = new SmtpClient();
            MailMessage mensagem = new MailMessage();

            mensagem.From = new MailAddress("luisjunior744@gmail.com");
            mensagem.To.Add(txtEmail.Text);
            mensagem.Priority = MailPriority.Normal;
            mensagem.IsBodyHtml = true;
            mensagem.Subject = "Recuperação de senha e-Vinil";
            mensagem.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");
            mensagem.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");
            usuario = usuariodal.EnviarSenhaEmail(txtEmail.Text);
            mensagem.Body = "Usuário: "+usuario.Usuario + "\r\n" +"Senha: " + usuario.Senha;
            enviarsenha.Host = "smtp.gmail.com";
            enviarsenha.Credentials = new NetworkCredential("luisjunior744", "revymetal");
            enviarsenha.Send(mensagem);

            Response.Redirect("Login.aspx");
        }
    }
}