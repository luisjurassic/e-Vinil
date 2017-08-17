<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/e-Vinil.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="e_Vinil.Presentation.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="Login">
        <div id="titulo">
            <h1>Login e-Vinil</h1>
        </div>
        <div class="descricaoLogin">
            Acesse agora para ter todas as vantagem que so um cliente e-Vinil tem.
            Ou&nbsp; <asp:LinkButton Text="  Registrar-se  " runat="server"  OnClick="Unnamed_Click"/>  &nbsp;caso não tenha um registro.
            <br />
            <br />
        </div>
        <div class="divlogin">
            <asp:Label runat="server" Text="Usuário"></asp:Label>
            <asp:TextBox ID="txtLogin" runat="server"/>

            <asp:Label runat="server" Text="Senha"></asp:Label>
            <asp:TextBox ID="txtSenha" TextMode="Password" runat="server"/>
            <p>
                <asp:LinkButton ID="linkSenha" OnClick="linkSenha_Click" Text="Esqueceu sua senha?" runat="server" />
                <asp:Button Text="Entrar" OnClick="btnEntrar_Click" runat="server" ID="btnEntrar" />
            </p>
        </div>
    </div>
</asp:Content>
