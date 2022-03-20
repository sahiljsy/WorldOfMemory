using Client.UserServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class RemoveFriend : System.Web.UI.Page
    {
        string friend;

        protected void Page_Load(object sender, EventArgs e)
        {
            friend = Request.QueryString["username"];
            HttpCookie user = Request.Cookies["username"];
            if (user == null)
            {
                Response.Redirect("SignIn.aspx");
            }
            try
            {
                UserServiceReference.IUser client = new UserServiceReference.UserClient("WSHttpBinding_IUser");
                RequestUSer request = new RequestUSer();
                Services.User u = new Services.User();
                u.username = friend;
                request.user = u;
                UserMessage response = client.GetUser(request);
                displayUsername.Text = response.user.username;
                friends.Text = "Friends: "+ response.user.friends;
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        protected void Remove_Click(object sender, EventArgs e)
        {
            try
            {
                UserServiceReference.IUser client = new UserServiceReference.UserClient("WSHttpBinding_IUser");
                HttpCookie user = Request.Cookies["username"];
                if (Remove.Text == "Follow")
                {
                    string msg = client.AddFreind(user.Value, friend);
                    Remove.Text = "Remove";
                    status.Text = msg;
                }
                else if (Remove.Text == "Remove")
                {
                    string msg = client.RemoveFriend(user.Value, friend);
                    Remove.Text = "Follow";
                    status.Text = msg;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}