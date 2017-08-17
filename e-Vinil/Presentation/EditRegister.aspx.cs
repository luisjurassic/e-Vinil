using e_Vinil.DAL;
using e_Vinil.Entidades;
using e_Vinil.Model;
using System;

namespace e_Vinil.Presentation
{
    public partial class EditRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            UsuariosDAL usuariosdal = new UsuariosDAL();

            Cliente cliente = new Cliente();
            ClientesDAL clientedal = new ClientesDAL();

            Enderecos endereco = new Enderecos();
            EnderecosDAL enderecodal = new EnderecosDAL();

            cliente = clientedal.BuscarCliente(ParametrosUsuario.UsuariosID);
            usuario = usuariosdal.BuscarUsuario(cliente.Usuario_id);
            endereco = enderecodal.BuscarEndereco(cliente.ClientesID);

            txtUsuario.Text = usuario.Usuario.Trim();
            txtEmail.Text = usuario.Email.Trim();
            txtSenha.Text = usuario.Senha;
            txtConfirmeSenha.Text = usuario.Senha;
            imgPerfil.ImageUrl = usuario.Imagem_perfil.Trim();

            txtNome.Text = cliente.Nome.Trim();
            txtSobrenome.Text = cliente.Sobrenome.Trim();
            txtCPF.Text = cliente.CPF.Trim();
            txtDataN.Text = cliente.Data_Nascimento.Date.ToShortDateString();
            ddlSexo.Text = cliente.Sexo;
            txtContato.Text = cliente.Telefone.Trim();
            txtCelular.Text = cliente.Celular.Trim();

            txtCep.Text = endereco.CEP.Trim();
            ddlTipoEndereco.Text = endereco.Tipo_Residencia;
            txtRua.Text = endereco.Rua.Trim();
            txtNumero.Text = endereco.Numero.ToString().Trim();
            txtComplemento.Text = endereco.Complemento.Trim();
            txtBairro.Text = endereco.Bairro.Trim();
            txtCidade.Text = endereco.Cidade.Trim();
            ddlEstado.Text = endereco.Estado;
        }
    }
}