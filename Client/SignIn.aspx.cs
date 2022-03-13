using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using Client.UserServiceReference;

namespace Client
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            //UserMessage response = new UserMessage();
            RequestUSer request = new RequestUSer();
            try
            {
                UserServiceReference.IUser client = new UserServiceReference.UserClient("WSHttpBinding_IUser");
                if (password.Text == "" || username.Text == "")
                {
                    error.Text = "All Feilds are required!";
                }
                else
                {
                    string user_name = username.Text;
                    string pass = password.Text;
                    Console.WriteLine(user_name, pass);
                    User user = new User();
                    user.username = user_name;
                    user.password = pass;
                    request.user = user;
                    UserMessage response = client.login(request);
                    if (response.StatusCode == 200)
                    {
                        HttpCookie usernameCookie = new HttpCookie("username");
                        usernameCookie.Value = response.user.username;
                        Response.Cookies.Add(usernameCookie);
                        Response.Redirect("Home.aspx");
                    }
                    if (response.StatusCode == 500)
                    {
                        error.Text = "Something Went Wrong!!";
                    }
                    else
                    {
                        error.Text = response.Error;
                    }
                }
            }
            catch(Exception err)
            {
                error.Text = "Somthing Went Worng";
                Console.WriteLine(err.Message);
            }
            
               
            //usernameError.Text = Response.Cookies["username"].Value;
            //passwordError.Text = user.password;
        }
    }
}