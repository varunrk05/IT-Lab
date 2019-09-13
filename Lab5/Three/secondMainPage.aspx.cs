using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Three
{
    public partial class secondMainPage : System.Web.UI.Page
    {
        HttpCookie cookie;
        protected void Page_Load(object sender, EventArgs e)
        {
            cookie = Request.Cookies["User"];
            lblInfo.Text += "Hi " + cookie["name"] + "!";
            lblInfo.Text += "\nYour Cart contains: " + cookie["cart"];
            cookie.Expires = DateTime.Now.AddDays(10);
            Response.Cookies.Add(cookie);
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            Response.Redirect("addToCart.aspx");
        }
    }
}