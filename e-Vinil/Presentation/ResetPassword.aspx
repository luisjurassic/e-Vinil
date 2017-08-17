<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/e-Vinil.Master" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="e_Vinil.Presentation.ResetPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="ResetPass">
        <div id="titulo">
            <h1>Redefinição de senha</h1>
        </div>
        <p id="descricao">
            Certifique-se de informar o e-mail
            que consta em nosso cadastro.Sua senha será enviada para este endereço.
        </p>
        <div id="recuperar" style="margin-top: 0px">
            <asp:Label runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" />
            <asp:Button Text="Enviar" runat="server" ID="btnEnviar" OnClick="btnEnviar_Click" />
        </div>
    </div>
</asp:Content>
