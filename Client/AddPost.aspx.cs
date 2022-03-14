using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using Client.UserServiceReference;
using Services;

namespace Client
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        HttpCookie user;
        protected void Page_Load(object sender, EventArgs e)
        {
            user = Request.Cookies["username"];
            if (user == null)
            {
                Response.Redirect("SignIn.aspx");
            }
        }

        protected void addpst_Click(object sender, EventArgs e)
        {
            UserServiceReference.IUser client = new UserServiceReference.UserClient("WSHttpBinding_IUser");
            post p = new post();
            p.username = user.Value;

            p.post_path = "../posts/" + FileUpload1.PostedFile.FileName;

            string strFileName;
            string strFilePath;
            string strFolder;
            strFolder = Server.MapPath("~/posts/");
            strFileName = FileUpload1.PostedFile.FileName;
            strFileName = Path.GetFileName(strFileName);

            if(FileUpload1.HasFile)
            {
                if(!Directory.Exists(strFolder))
                {
                        Directory.CreateDirectory(strFolder);
                }
                strFilePath = strFolder + strFileName;

                if(File.Exists(strFilePath))
                {
                    error.Text = strFileName + " already exists on the server.";
                }
                else
                {
                    FileUpload1.PostedFile.SaveAs(strFilePath);
                    error.Text = strFileName + client.AddPost(p);
                }
            }
            else{
                error.Text = "File not found.";
            }
        }
    }
}