using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
            //Response.Write(MyFormPrint());
            Response.Write("<br><br>");

            Response.Write("Dictionary<br>");
            Response.Write("-----------------------------------------<br>");

            if (Session["sDictCountries"]  == null)
            {
                Country country1 = new Country() { Code = "IND", Name = "India", Capital = "New Delhi" };
                Country country2 = new Country() { Code = "USA", Name = "United States", Capital = "New York" };
                Country country3 = new Country() { Code = "CAN", Name = "Canada", Capital = "Ottawa" };

                Dictionary<string, Country> dictcountry = new Dictionary<string, Country>();
                dictcountry.Add(country1.Code, country1);
                dictcountry.Add(country2.Code, country2);
                dictcountry.Add(country3.Code, country3);

                Session["sDictCountries"] = dictcountry;
            }
        }

        protected void txtCode_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, Country> sdictCtry = (Dictionary<string, Country>)Session["sDictCountries"];

            Country resultCountry = sdictCtry.ContainsKey(txtCode.Text.ToUpper()) ? sdictCtry[txtCode.Text.ToUpper()] : null;

            if (resultCountry != null)
            {
                txtName.Text = resultCountry.Name;
                txtCapital.Text = resultCountry.Capital;
                lblMsg.Text = "";
            }
            else
            {
                txtName.Text = "";
                txtCapital.Text = "";
                lblMsg.Text = "Invalid Code";
            }
        }
    }

    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string  Capital { get; set; }
    }
}