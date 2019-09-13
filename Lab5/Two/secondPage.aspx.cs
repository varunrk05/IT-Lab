using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Two
{
    public partial class secondPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Response.Cookies[(string)Session["Name"] + "Counter"];
            cookie["count"] = "0";
            cookie["name"] = (string)Session["Name"];
            cookie["roll"] = (string)Session["Roll"];
            cookie["subject"] = (string)Session["Subject"];
            cookie.Expires = DateTime.Now.AddDays(10);
            Response.Cookies.Add(cookie);
            if (!IsPostBack)
            {
                lblCount.Text = "";
                string info;
                info = (string)Session["Name"];
                info += ", roll number ";
                info += (string)Session["Roll"];
                info += ", selected the subject ";
                info += (string)Session["Subject"];
                lblInfo.Text = info;
            }
        }

        protected void btnInc_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies[(string)Session["Name"] + "Counter"];
            int c;
            if(cookie != null)
            {
                c = Int32.Parse(cookie["count"]);
                c += 1;
                cookie["count"] = c.ToString();
                cookie.Expires = DateTime.Now.AddDays(10);
                Response.Cookies.Add(cookie);
            }
            else
            {
                lblCount.Text = "Cookie not available!";
            }

            lblCount.Text = cookie["count"];
        }
    }
}