using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Two
{
    public partial class firstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                ddlSub.Items.Add("Computer Vision");
                ddlSub.Items.Add("Maths");
                ddlSub.Items.Add("DS");

                tbName.Text = "";
                tbRoll.Text = "";
            }
        }

        protected void btnSub1_Click(object sender, EventArgs e)
        {
            Session["Name"] = tbName.Text;
            Session["Roll"] = tbRoll.Text;
            Session["Subject"] = ddlSub.SelectedItem.ToString();

            Response.Redirect("secondPage.aspx");
        }
    }
}