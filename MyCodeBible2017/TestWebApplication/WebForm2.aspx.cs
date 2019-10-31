// <copyright file="AssemblyInfo.cs" company="company">
// Copyright (c) company. All rights reserved.
// File WebForm2.aspx.cs
// </copyright>
// <author>me</author>
// <email>me@me.com</email>
// <date>2010-03-04</date>
// <summary>blah blah.</summary>
namespace TestWebApplication
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    /// <summary>
    /// The class that is being used
    /// </summary>
    public partial class WebForm2 : System.Web.UI.Page
    {
        /// <summary>
        /// This page gets loaded
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">The event</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = 0;
            if (x == 0)
            {
                Response.Write("0");
            }

            PrintFirstName();

            PrintSecondName();

            PrintThirdName();

            Person person1 = new Person();
            person1.MyProperty = 1;
       }

        private void PrintFirstName()
        {
            string name = string.Empty;
#if DEBUG
            name = "Fred";
#endif
            Response.Write(name);

        }

        [Conditional("DEBUG")]
        private void PrintSecondName()
        {
            string name = "Steve";
            Response.Write(name);
        }

        [Conditional("RELEASE")]
        private void PrintThirdName()
        {
            string name = "Smith";
            Response.Write(name);
        }

        
        
    }

    public class Person
    {
        private int myProperty;
        public int MyProperty { get ; set; }
    }
}