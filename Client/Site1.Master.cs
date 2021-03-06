using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie user = Request.Cookies["username"];
            if (user == null)
            {
                Logout.Visible = false;
                SignIn.Visible = true;
            }
            else
            {
                SignIn.Visible = false;
                Logout.Visible = true;
            }
        }
    }
}