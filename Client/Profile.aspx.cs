using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Client.UserServiceReference;

namespace Client
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
                        Label2.Visible = false;
                        UserServiceReference.IUser client = new UserServiceReference.UserClient("WSHttpBinding_IUser");
                        RequestUSer request = new RequestUSer();
                        Services.User u = new Services.User();
                        u.username = user.Value;
                        request.user = u;
                        UserMessage response = client.GetUser(request);
                        displayUsername.Text = response.user.username;
                        friends.Text = "Friends: " + response.user.friends;
                        UserPic.ImageUrl = response.user.profile_pic;
                        username.Text = response.user.username;
                        email.Text = response.user.email;
                        name.Text = response.user.name;
                        UserPic.ImageUrl = response.user.profile_pic;


                        friendList.DataSource = client.GetFriends(user.Value);
                        friendList.DataBind();
                        Services.post[] pstlist = client.ViewMyPosts(user.Value);
                        if(pstlist.Length == 0)
                        {
                            Repeater2.Visible = false;
                            Label2.Text = "No Post Available.";
                            Label2.Visible = true;
                        }
                        else
                        {
                            Repeater2.DataSource = pstlist;
                            Repeater2.DataBind();
                        }
                        
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }

                }
            }
                
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            HttpCookie user = Request.Cookies["username"];
            Services.User updated_user = new Services.User();
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
            if (ProfilePic.PostedFile != null && ProfilePic.FileName != null)
            {
                updated_user.profile_pic = "../Profile_pic/" + ProfilePic.FileName;
                ProfilePic.SaveAs(Server.MapPath("Profile_pic/" + ProfilePic.FileName));
            }
            else
            {
                updated_user.profile_pic = "../Profile_pic/defualt_user.png";
            }
            try
            {
                UserServiceReference.IUser client = new UserServiceReference.UserClient("WSHttpBinding_IUser");
                RequestUSer request = new RequestUSer();
                request.user = updated_user;
                UserMessage response = client.UpdateUser(request);
                displayUsername.Text = response.user.username;
                friends.Text = "Friends: " + response.user.friends;
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

        protected void Delete_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteAccount.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            HttpCookie user = Request.Cookies["username"];
            UserServiceReference.IUser client = new UserServiceReference.UserClient("WSHttpBinding_IUser");
            ImageButton btn = (ImageButton)sender;
            RepeaterItem row = (RepeaterItem)btn.NamingContainer;
            Label ID = (Label)row.FindControl("lblId");
            string id = ID.Text;
            int intid = int.Parse(id);         
            string path = client.DeletePost(intid);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "msg", "alert('Post Deleted Successfully')", true);
            Services.post[] pstlist = client.ViewMyPosts(user.Value);
            if (pstlist.Length == 0)
            {
                Repeater2.Visible = false;
                Label2.Text = "No Post Available.";
                Label2.Visible = true;
            }
            else
            {
                Repeater2.DataSource = pstlist;
                Repeater2.DataBind();
            }
        }
    }
}