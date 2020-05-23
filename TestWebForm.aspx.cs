using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetCoreCsharpWebApp
{
    public partial class TestWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("C# Tutorial Samples<br><br>");

            Response.Write("Partial Class<br>");
            Response.Write("-----------------------------------------<br>");

            PartialClassCustomer obj = new PartialClassCustomer();
            Response.Write(obj.Print());

            Response.Write(MyFormPrint());
        }
    }
}