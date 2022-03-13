using Client.UserServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_Click(object sender, EventArgs e)
        {
            RequestUSer request = new RequestUSer();
            UserServiceReference.IUser client = new UserServiceReference.UserClient();
            if(password.Text == "" || username.Text == "" || email.Text=="")
            {
                error.Text = "All Feilds are required!";
            }
            else if(password.Text != confpassword.Text)
            {
                confpassworderror.Text = "*Password didn't match";
            }
            else
            {
                User user = new User();
                user.username = username.Text;
                user.password = password.Text;
                user.email = email.Text;
                request.user = user;
                UserMessage response = client.register(request);
                if (response.StatusCode == 200)
                {
                    Response.Redirect("SignIn.aspx");
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
    }
}