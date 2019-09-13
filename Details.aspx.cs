using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace question1
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblManuf.Text = "";
                lblModel.Text = "";
            }

            string manuf = Request.QueryString["Manufac"];//Server.UrlDecode("Manufac");
            string model = Request.QueryString["Model"];//Server.UrlDecode("Model");
            lblManuf.Text = "The manufacturer is: " + manuf;
            lblModel.Text = "The model is: " + model;
        }
    }
}