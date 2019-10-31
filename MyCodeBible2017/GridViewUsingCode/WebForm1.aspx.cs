using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridViewUsingCode
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView myGrid = new GridView();

            string[] names = { "Tom", "Fred", "Harry" };
            var filteredNames = names.Where(n => n.Length >= 4);

            myGrid.AutoGenerateEditButton = true;
            myGrid.Style.Add("border", "solid 10px black");
            myGrid.Style.Add("border-collapse", "collapse");
            myGrid.Style.Add("width", "auto");

            myGrid.DataSource = filteredNames;
            myGrid.DataBind();

            myPanel.Controls.Add(myGrid);
        }
    }
}