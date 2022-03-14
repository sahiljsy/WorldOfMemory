using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class DeleteAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie user = Request.Cookies["username"];
            if (user == null)
            {
                Response.Redirect("SignIn.aspx");
            }
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserProfile.aspx");
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                HttpCookie user = Request.Cookies["username"];
                UserServiceReference.IUser client = new UserServiceReference.UserClient("WSHttpBinding_IUser");
                string msg = client.DeleteAccount(user.Value);
                if(msg == "Account Deleted !")
                {
                    Response.Cookies["username"].Expires = DateTime.Now.AddDays(-1);
                    Response.Redirect("SignIn.aspx");
                }
                else
                {
                    error.Text = msg;
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}