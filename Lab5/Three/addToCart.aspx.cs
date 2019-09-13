using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Three
{
    public partial class addToCart : System.Web.UI.Page
    {
        HttpCookie cookie;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                tbItem.Text = "";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            cookie = Request.Cookies["User"];
            if(cookie != null)
            {
                string name = cookie["name"];
                string cart = cookie["cart"];
                cart +=  " " + tbItem.Text;
                //cart += " ";
                cookie["cart"] = cart;
                //cookie["name"] = name;
                cookie.Expires = DateTime.Now.AddDays(10);
                Response.Cookies.Add(cookie);
                tbItem.Text = "";
            }
            else
            {
                tbItem.Text = "Cookie is null!";
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("mainPage.aspx");
        }
    }
}