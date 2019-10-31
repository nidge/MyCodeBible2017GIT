using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqToSQLWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var CustomersQuery = from customers in dc.Customers
                                 select customers;

            GridView1.DataSource = CustomersQuery;
            GridView1.DataBind();


        }
    }
}