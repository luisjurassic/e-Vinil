<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/e-Vinil.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="e_Vinil.Presentation.Main" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="pageProduto">
        <asp:ListView ID="ListViewProducts" runat="server" ItemPlaceholderID="ProductItem">
            <ItemTemplate>
                <div class="panelProduto">
                    <img id="imgProduto" src="..<%#Eval("Capa")%>" />
                    <div class="descricao_produto">
                        <asp:Label ID="lblArtista" runat="server" ForeColor="#0066ff" Font-Size="30px" Text='<%#Eval("Artista")%>'></asp:Label><br />
                        <asp:Label ID="lblAlbum" ForeColor="Silver" runat="server" Width="350px" Font-Size="16px" Text='<%#"Album: " + Eval("Album")%>'></asp:Label>
                        <asp:Label ID="lblAno" ForeColor="#666666" runat="server" Width="350px" Font-Size="12px" Text='<%# "Ano: " + Eval("Ano")%>'></asp:Label>
                        <br />
                        <br />
                        <br />
                        <asp:Label runat="server" ID="lblPreco" Font-Bold="true" ForeColor="greenyellow" Font-Size="X-Large"  Text='<%# "Preço: R$ " + string.Format("{0:0.00}",Eval("Preco"))%>'></asp:Label><br />
                    </div>
                    <div class="btnCarrinho">
                        <asp:ImageButton ImageUrl="~/css/img/carinho.png" runat="server" ID="btnCarrinho" Text="" CommandArgument='<%#Eval("ProdutosId")%>' />
                    </div>
                </div>
            </ItemTemplate>
            <LayoutTemplate>
                <asp:PlaceHolder runat="server" ID="ProductItem"></asp:PlaceHolder>
            </LayoutTemplate>
            <ItemSeparatorTemplate>
            </ItemSeparatorTemplate>
        </asp:ListView>
        <br />
        <div class="panelProdutoPage">
            <asp:DataPager ID="DataPagerProducts" runat="server" PagedControlID="ListViewProducts"
                PageSize="10" OnPreRender="DataPagerProducts_PreRender">
                <Fields>
                    <asp:NumericPagerField ButtonType="Button" />
                </Fields>
            </asp:DataPager>
        </div>
    </div>
</asp:Content>
