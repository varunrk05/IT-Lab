using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Three
{
    public partial class mainPage : System.Web.UI.Page
    {
        HttpCookie cookie, cookieNew;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                cookie = Request.Cookies["User"];
                if(cookie != null)
                {
                    Response.Cookies.Add(cookie);
                    Response.Redirect("secondMainPage.aspx");
                }
            }
            cookieNew = Response.Cookies["User"];
        }

        protected void btnMain_Click(object sender, EventArgs e)
        {
            //if(cookieNew != null)
            //{
            cookieNew["name"] = tbName.Text;
            cookieNew["cart"] = "";
            cookieNew.Expires = DateTime.Now.AddDays(10);
            Response.Cookies.Add(cookieNew);
            Response.Redirect("secondMainPage.aspx");
            //}
        }
    }
}