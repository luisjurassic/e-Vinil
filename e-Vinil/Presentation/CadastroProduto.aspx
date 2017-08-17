<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/e-Vinil.Master" AutoEventWireup="true" CodeBehind="CadastroProduto.aspx.cs" Inherits="e_Vinil.Presentation.CadastroProduto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="produto">
        <h1>Dados Do Produto</h1>
        <p>
            <asp:Label Text="Imagem da Capa:" runat="server" />
            <asp:Image class="imgdisco" ID="imgCapa" runat="server"  ImageUrl="~/css/img/disco_default.png"/>
        </p>
        <asp:FileUpload runat="server" ID="file" />
        <p>
            <asp:Label Text="Código Produto:" runat="server" />
            <asp:TextBox runat="server" ID="txtCodProduto" />
        </p>
        <p>
            <asp:Label Text="Artista:" runat="server" />
            <asp:TextBox runat="server" ID="txtArtista" />
        </p>
        <p>
            <asp:Label Text="Albúm:" runat="server" />
            <asp:TextBox runat="server" ID="txtAlbum" />
        </p>
        <p>
            <asp:Label Text="Ano:" runat="server" />
            <asp:DropDownList runat="server" ID="ddlAno">
                <asp:ListItem Text="2015" />
                <asp:ListItem Text="2014" />
                <asp:ListItem Text="2013" />
                <asp:ListItem Text="2012" />
                <asp:ListItem Text="2011" />
                <asp:ListItem Text="2010" />
                <asp:ListItem Text="2009" />
                <asp:ListItem Text="2008" />
                <asp:ListItem Text="2000" />
                <asp:ListItem Text="1999" />
                <asp:ListItem Text="1998" />
                <asp:ListItem Text="1997" />
                <asp:ListItem Text="1996" />
                <asp:ListItem Text="1995" />
                <asp:ListItem Text="1994" />
                <asp:ListItem Text="1993" />
                <asp:ListItem Text="1992" />
                <asp:ListItem Text="1991" />
                <asp:ListItem Text="1990" />
                <asp:ListItem Text="1989" />
                <asp:ListItem Text="1988" />
                <asp:ListItem Text="1987" />
                <asp:ListItem Text="1986" />
                <asp:ListItem Text="1985" />
                <asp:ListItem Text="1984" />
                <asp:ListItem Text="1983" />
                <asp:ListItem Text="1982" />
                <asp:ListItem Text="1981" />
                <asp:ListItem Text="1980" />
                <asp:ListItem Text="1979" />
                <asp:ListItem Text="1978" />
                <asp:ListItem Text="1977" />
                <asp:ListItem Text="1976" />
                <asp:ListItem Text="1975" />
                <asp:ListItem Text="1974" />
                <asp:ListItem Text="1973" />
                <asp:ListItem Text="1972" />
                <asp:ListItem Text="1971" />
                <asp:ListItem Text="1970" />
                <asp:ListItem Text="1969" />
                <asp:ListItem Text="1968" />
                <asp:ListItem Text="1967" />
                <asp:ListItem Text="1966" />
                <asp:ListItem Text="1965" />
                <asp:ListItem Text="1964" />
                <asp:ListItem Text="1963" />
                <asp:ListItem Text="1962" />
                <asp:ListItem Text="1961" />
                <asp:ListItem Text="1960" />
                <asp:ListItem Text="1959" />
                <asp:ListItem Text="1958" />
                <asp:ListItem Text="1957" />
                <asp:ListItem Text="1956" />
                <asp:ListItem Text="1955" />
                <asp:ListItem Text="1954" />
                <asp:ListItem Text="1953" />
                <asp:ListItem Text="1952" />
                <asp:ListItem Text="1951" />
                <asp:ListItem Text="1950" />
                <asp:ListItem Text="1949" />
                <asp:ListItem Text="1948" />
                <asp:ListItem Text="1947" />
                <asp:ListItem Text="1946" />
                <asp:ListItem Text="1945" />
                <asp:ListItem Text="1944" />
                <asp:ListItem Text="1943" />
                <asp:ListItem Text="1942" />
                <asp:ListItem Text="1941" />
                <asp:ListItem Text="1940" />
                <asp:ListItem Text="1939" />
                <asp:ListItem Text="1938" />
                <asp:ListItem Text="1937" />
                <asp:ListItem Text="1936" />
                <asp:ListItem Text="1935" />
                <asp:ListItem Text="1934" />
                <asp:ListItem Text="1933" />
                <asp:ListItem Text="1932" />
                <asp:ListItem Text="1931" />
                <asp:ListItem Text="1930" />
                <asp:ListItem Text="1929" />
                <asp:ListItem Text="1928" />
                <asp:ListItem Text="1927" />
                <asp:ListItem Text="1926" />
                <asp:ListItem Text="1925" />
                <asp:ListItem Text="1924" />
                <asp:ListItem Text="1923" />
                <asp:ListItem Text="1922" />
                <asp:ListItem Text="1921" />
                <asp:ListItem Text="1920" />
                <asp:ListItem Text="1919" />
                <asp:ListItem Text="1918" />
                <asp:ListItem Text="1917" />
                <asp:ListItem Text="1916" />
                <asp:ListItem Text="1915" />
                <asp:ListItem Text="1914" />
                <asp:ListItem Text="1913" />
                <asp:ListItem Text="1912" />
                <asp:ListItem Text="1911" />
                <asp:ListItem Text="1910" />
                <asp:ListItem Text="1909" />
                <asp:ListItem Text="1908" />
                <asp:ListItem Text="1907" />
                <asp:ListItem Text="1906" />
                <asp:ListItem Text="1905" />
                <asp:ListItem Text="1904" />
                <asp:ListItem Text="1903" />
                <asp:ListItem Text="1902" />
                <asp:ListItem Text="1901" />
                <asp:ListItem Text="1900" />
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label Text="Gênero:" runat="server" />
            <asp:DropDownList runat="server" ID="ddlGenero">
                <asp:ListItem Text="Heavy Metal" />
                <asp:ListItem Text="Indie" />
                <asp:ListItem Text="New Wave" />
                <asp:ListItem Text="Punk" />
                <asp:ListItem Text="Rock" />
                <asp:ListItem Text="Rock Alternativo" />
                <asp:ListItem Text="Rock Nascional" />
                <asp:ListItem Text="Rock Internacional" />
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label Text="Gravadora:" runat="server" />
            <asp:TextBox runat="server" ID="txtGravadora" />
        </p>
        <p>
            <asp:Label Text="Informacôes Adicionais:" runat="server" />
            <asp:TextBox runat="server" ID="txtInfor" />
        </p>
        <p>
            <asp:Label Text="Preço:" runat="server" />
            <asp:TextBox runat="server" ID="txtPreco" />
        </p>
        <p>
            <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" />
            <asp:Button OnClick="btnConcluir_Click" ID="btnConcluir" Text="Salvar" runat="server" />
        </p>
    </div>
</asp:Content>

<asp:Content runat="server" ID="mimimi" ContentPlaceHolderID="contentScript">
    <script type="text/javascript">
        function readURL(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();

                reader.onload = function (e) {
                    $('#ContentPlaceHolder_imgCapa').attr('src', e.target.result);
                }

                reader.readAsDataURL(input.files[0]);
            }
        }

        $("#ContentPlaceHolder_file").change(function () {
            readURL(this);
        });
    </script>
</asp:Content>
