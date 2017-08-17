<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/e-Vinil.Master" AutoEventWireup="true" CodeBehind="EditRegister.aspx.cs" Inherits="e_Vinil.Presentation.EditRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="dados">
        <h1>Editar Registro</h1>
        <div class="dadosAcesso">
            <h3>Dados de Acesso</h3>
            <div class="img_perfil">
                <span>Imagem de Perfil:</span>
                <asp:Image ID="imgPerfil" runat="server" />
                <asp:FileUpload runat="server" ID="file_import" />
            </div>
            <div class="acesso">
                <p>
                    <span>Usuário*:</span>
                    <asp:TextBox runat="server" ID="txtUsuario" />
                </p>
                <p>
                    <asp:Label Text="E-mail*:" runat="server" />
                    <asp:TextBox runat="server" ID="txtEmail" />
                </p>
                <p>
                    <asp:Label Text="Senha*:" runat="server" />
                    <asp:TextBox runat="server" ID="txtSenha" TextMode="Password" Font-Size="16px" max-width="200px" margin-left="5px" margin-bottom="10px" />
                </p>
                <p>
                    <asp:Label Text="Confirme sua senha*:" runat="server" />
                    <asp:TextBox runat="server" ID="txtConfirmeSenha" TextMode="Password" Font-Size="16px" max-width="200px" margin-left="5px" margin-bottom="10px" />
                </p>
            </div>
        </div>
        <div class="dadosPessoais">
            <h3>Dados Pessoais</h3>
            <p>
                <asp:Label Text="Nome*:" runat="server" />
                <asp:TextBox runat="server" ID="txtNome" />
            </p>
            <p>
                <asp:Label Text="Sobrenome*:" runat="server" />
                <asp:TextBox runat="server" ID="txtSobrenome" />
            </p>
            <p>
                <asp:Label Text="CPF*:" runat="server" />
                <asp:TextBox runat="server" ID="txtCPF" />
            </p>
            <p>
                <asp:Label Text="Data de nascimento:" runat="server" />
                <asp:TextBox runat="server" ID="txtDataN" TextMode="Date" />
            </p>
            <p>
                <asp:Label Text="Sexo:" runat="server" />
                <asp:DropDownList ID="ddlSexo" runat="server">
                    <asp:ListItem Text="Masculino" />
                    <asp:ListItem Text="Feminino" />
                </asp:DropDownList>
            </p>
            <p>
                <asp:Label Text="Telefone*:" runat="server" />
                <asp:TextBox runat="server" ID="txtContato" />
            </p>
            <p>
                <asp:Label Text="Celular*:" runat="server" />
                <asp:TextBox runat="server" ID="txtCelular" />
            </p>
        </div>
        <div class="dadosEndereco">
            <h3>Dados De Endereço</h3>
            <p>
                <asp:Label Text="CEP*:" runat="server" />
                <asp:TextBox runat="server" ID="txtCep" />
            </p>
            <p>
                <asp:Label Text="Tipo de endereço:" runat="server" />
                <asp:DropDownList ID="ddlTipoEndereco" runat="server">
                    <asp:ListItem Text="Residêncial" />
                    <asp:ListItem Text="Comercial" />
                </asp:DropDownList>
            </p>
            <p>
                <asp:Label Text="Rua*:" runat="server" />
                <asp:TextBox runat="server" ID="txtRua" />
            </p>
            <p>
                <asp:Label Text="Número:" runat="server" />
                <asp:TextBox runat="server" ID="txtNumero" />
            </p>
            <p>
                <asp:Label Text="Complemento:" runat="server" />
                <asp:TextBox runat="server" ID="txtComplemento" />
            </p>
            <p>
                <asp:Label Text="Bairro*:" runat="server" />
                <asp:TextBox runat="server" ID="txtBairro" />
            </p>
            <p>
                <asp:Label Text="Cidade*:" runat="server" />
                <asp:TextBox runat="server" ID="txtCidade" />
            </p>
            <p>
                <asp:Label Text="Estado*:" runat="server" />
                <asp:DropDownList ID="ddlEstado" runat="server">
                    <asp:ListItem Text="AC" />
                    <asp:ListItem Text="AL" />
                    <asp:ListItem Text="AM" />
                    <asp:ListItem Text="AP" />
                    <asp:ListItem Text="BA" />
                    <asp:ListItem Text="CE" />
                    <asp:ListItem Text="DF" />
                    <asp:ListItem Text="ES" />
                    <asp:ListItem Text="GO" />
                    <asp:ListItem Text="MA" />
                    <asp:ListItem Text="MG" />
                    <asp:ListItem Text="MS" />
                    <asp:ListItem Text="MT" />
                    <asp:ListItem Text="PA" />
                    <asp:ListItem Text="PB" />
                    <asp:ListItem Text="PE" />
                    <asp:ListItem Text="PI" />
                    <asp:ListItem Text="PR" />
                    <asp:ListItem Text="RJ" />
                    <asp:ListItem Text="RN" />
                    <asp:ListItem Text="RO" />
                    <asp:ListItem Text="RR" />
                    <asp:ListItem Text="RS" />
                    <asp:ListItem Text="SC" />
                    <asp:ListItem Text="SE" />
                    <asp:ListItem Text="SP" />
                    <asp:ListItem Text="TO" />
                </asp:DropDownList>
            </p>
        </div>
        <p>
            <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" />
            <asp:Button ID="btnConcluir" Text="Salvar" runat="server" />
        </p>
    </div>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="contentScript">
    <script type="text/javascript">
        function readURL(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();

                reader.onload = function (e) {
                    $('#ContentPlaceHolder_imgPerfil').attr('src', e.target.result);
                }

                reader.readAsDataURL(input.files[0]);
            }
        }

        $("#ContentPlaceHolder_file_import").change(function () {
            readURL(this);
        });
    </script>
</asp:Content>
