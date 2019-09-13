using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage
{
    public partial class Login : System.Web.UI.Page
    {
        static int logCount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                tbPass.Enabled = true;
                tbUserID.Enabled = true;
                tbPass.Text = "";
                tbUserID.Text = "";
                //Application["count"] = 0;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbUserID.Text == "user" && tbPass.Text == "pass")
            {
                logCount = 0;
                int count = (int)Application["count"];
                count += 1;
                Application["count"] = count;
                Response.Redirect("Display.aspx");
            } else
            {
                logCount += 1;
                if(logCount == 3)
                {
                    tbUserID.Enabled = false;
                    tbPass.Enabled = false;
                }
            }
        }
    }
}