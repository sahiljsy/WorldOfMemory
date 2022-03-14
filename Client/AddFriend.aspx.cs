using Client.UserServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class AddFriend : System.Web.UI.Page
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
                User u = new User();
                u.username = friend;
                request.user = u;
                UserMessage response = client.GetUser(request);
                displayUsername.Text = response.user.username;
                friends.Text = "Friends: "+ response.user.freinds;
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        protected void Follow_Click(object sender, EventArgs e)
        {
            try
            {
                UserServiceReference.IUser client = new UserServiceReference.UserClient("WSHttpBinding_IUser");
                HttpCookie user = Request.Cookies["username"];
                
                if (Follow.Text == "Follow")
                {
                    string msg = client.AddFreind(user.Value, friend);
                    Follow.Text = "Remove";
                    status.Text = msg;
                }
                else if(Follow.Text == "Remove")
                {
                    string msg = client.RemoveFriend(user.Value, friend);
                    Follow.Text = "Follow";
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