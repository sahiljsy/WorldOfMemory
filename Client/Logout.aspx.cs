using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie user = Request.Cookies["username"];
            if (user != null)
            {
                Response.Cookies["username"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect("SignIn.aspx");
            }
        }
    }
}