using Client.UserServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class Home : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie user = Request.Cookies["username"];
            if (user == null)
            {
                Response.Redirect("SignIn.aspx");
            }
            else
            {
                try
                {
                    UserServiceReference.IUser client = new UserServiceReference.UserClient("WSHttpBinding_IUser");
                    RequestUSer request = new RequestUSer();
                    User u = new User();
                    u.username = user.Value;
                    request.user = u;
                    UserMessage response = client.GetUser(request);
                    myusername.Text = response.user.username;
                    Repeater2.DataSource = client.GetSuggestedUser(user.Value);
                    Repeater2.DataBind();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
                
            }
        }
    }
}