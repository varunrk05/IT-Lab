using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace question1
{
    public partial class Manufacturer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ddlManuf.Items.Add("Toyota");
                ddlManuf.Items.Add("Honda");
                ddlManuf.Items.Add("Tata");

                tbModel.Text = "";
            }
        }

        protected void ddlManuf_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbModel.Text = "";
        }

        protected void submitData(object sender, EventArgs e)
        {
            if(ddlManuf.SelectedIndex != -1)
            {
                string url = "Details.aspx?";
                url += "Manufac=" + Server.UrlEncode(ddlManuf.SelectedValue) + "&";
                url += "Model=" + tbModel.Text;
                Response.Redirect(url);
            }
        }
    }
}