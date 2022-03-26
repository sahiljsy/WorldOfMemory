using Client.UserServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class Home : Page
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
                        UserServiceReference.IUser client = new UserServiceReference.UserClient("WSHttpBinding_IUser");
                        RequestUSer request = new RequestUSer();
                        Services.User u = new Services.User();
                        u.username = user.Value;
                        request.user = u;
                        UserMessage response = client.GetUser(request);
                        myusername.Text = response.user.username;
                        Repeater1.DataSource = client.ViewPosts(user.Value);
                        Repeater1.DataBind();
                        //Repeater1.DataSource = client.ViewPosts(user.Value);
                        //Repeater1.DataBind();

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

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            HttpCookie user = Request.Cookies["username"];
            UserServiceReference.IUser client = new UserServiceReference.UserClient("WSHttpBinding_IUser");
            ImageButton btn = (ImageButton)sender;
            RepeaterItem row = (RepeaterItem)btn.NamingContainer;
            Label ID = (Label)row.FindControl("lblId");
            string id = ID.Text;
            int intid = int.Parse(id);
            intid = client.LikePost(intid,user.Value);
            Repeater1.DataSource = client.ViewPosts(user.Value);
            Repeater1.DataBind();
        }
    }
}