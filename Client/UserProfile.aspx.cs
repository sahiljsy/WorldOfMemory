using Client.UserServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class UserProfile : System.Web.UI.Page
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
                    displayUsername.Text = response.user.username;
                    friends.Text =  "Friends: " + response.user.freinds;
                    UserPic.ImageUrl = response.user.profile_pic;
                    username.Text = response.user.username;
                    email.Text = response.user.email;
                    name.Text = response.user.name;
                    UserPic.ImageUrl = response.user.profile_pic;

                    friendList.DataSource = client.GetFriends(user.Value);
                    friendList.DataBind();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }

            }
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            HttpCookie user = Request.Cookies["username"];
            User updated_user = new User();
            updated_user.username = user.Value;
            if (email.Text == "")
            {
                emailerror.Text = "Please Eneter Email";
            }
            else
            {
                updated_user.name = name.Text; 
                updated_user.email = email.Text;
            }
            if(ProfilePic.PostedFile != null && ProfilePic.FileName != null)
            {
                updated_user.profile_pic = "Profile_pic/" + ProfilePic.FileName;
                ProfilePic.SaveAs(Server.MapPath("Profile_pic/" + ProfilePic.FileName));
            }
            else
            {
                updated_user.profile_pic = "Profile_pic/defualt_user.png";
            }
            try
            {
                UserServiceReference.IUser client = new UserServiceReference.UserClient("WSHttpBinding_IUser");
                RequestUSer request = new RequestUSer();
                request.user = updated_user;
                UserMessage response = client.UpdateUser(request);
                displayUsername.Text = response.user.username;
                friends.Text = "Friends: " +response.user.freinds;
                UserPic.ImageUrl = response.user.profile_pic;
                username.Text = response.user.username;
                email.Text = response.user.email;
                name.Text = response.user.name;
                UserPic.ImageUrl = response.user.profile_pic;
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}