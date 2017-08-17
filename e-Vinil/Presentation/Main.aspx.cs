using e_Vinil.DAL;
using System;

namespace e_Vinil.Presentation
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DataPagerProducts_PreRender(object sender, EventArgs e)
        {
            this.ListViewProducts.DataSource = new ProdutosDAL().BuscarTodosColuna();
            this.ListViewProducts.DataBind();
        }
    }
}