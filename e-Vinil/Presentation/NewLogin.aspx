<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewLogin.aspx.cs" Inherits="e_Vinil.Presentation.NewLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="../css/StyleMain.css" runat="server" />
    <script src="../JScript/jquery-2.1.3.min.js" type="text/javascript">
       $(document).ready(function () {
           $("a[rel=modal]").click(function (ev) {
               ev.preventDefault();

               //alterado
               var id = '.window';

               var alturaTela = $(document).height();
               var larguraTela = $(window).width();

               //colocando o fundo preto
               $('#mascara').css({ 'width': larguraTela, 'height': alturaTela });
               $('#mascara').fadeIn(1000);
               $('#mascara').fadeTo("slow", 0.8);

               var left = ($(window).width() / 2) - ($(id).width() / 2);
               var top = ($(window).height() / 2) - ($(id).height() / 2);

               $(id).css({ 'top': top, 'left': left });

               //inserido 
               href = $(this).attr("href");
               $('.window').load(href);


               $(id).show();
           });

           $("#mascara").click(function () {
               $(this).hide();
               $(".window").hide();
           });

           $('.fechar').click(function (ev) {
               ev.preventDefault();
               $("#mascara").hide();
               $(".window").hide();
           });
       });
		</script>
</head>
<body>
    <div class="window">
            <h1>Login e-Vinil</h1>
            Acesse agora para ter todas as vantagem que so um cliente e-Vinil tem.
            Ou&nbsp;
            &nbsp;caso não tenha um registro.
            <br />
            <br />
    </div>
    <div id="mascara"></div>
</body>
</html>
