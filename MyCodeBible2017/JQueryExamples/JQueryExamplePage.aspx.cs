using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JQueryExamples
{
    public partial class JQueryExamplePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //string scriptFile = "myscriptFile.js";

            //if (!this.Page.ClientScript.IsClientScriptIncludeRegistered("myScript"))
            //{
            //    this.Page.ClientScript.RegisterClientScriptInclude("myScript", scriptFile);
            //}


            Literal lt = new Literal();
            lt.Text = "<style type='text/css'> body   { background: #b6b7bc; font-size: .80em; } </style>";
            Page.Controls.Add(lt);


            if (checkOwner())
            {
            }
            else
            {
                Literal lt1 = new Literal();
                lt.Text = "<style type='text/css'> #Div1 ul li:first-child  + li  {   display: none !important; } </style>";
                Page.Controls.Add(lt1);
            }


            

        }

        private bool checkOwner()
        {
            return false;
        }
    }
}



        