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
            if(FileUpload1.PostedFile == null)
            {
                error.Text = "No File Uploaded";
            }
            else
            {
                string[] name = FileUpload1.PostedFile.FileName.Split('.');
                string strFileName = name[0] + "_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + "." + name[1];

                p.post_path = "../posts/" + strFileName;
                Console.WriteLine(p.post_path);

                string strFilePath;
                string strFolder;
                strFolder = Server.MapPath("~/posts/");

                if (FileUpload1.HasFile)
                {
                    if (!Directory.Exists(strFolder))
                    {
                        Directory.CreateDirectory(strFolder);
                    }
                    strFilePath = strFolder + strFileName;

                    if (File.Exists(strFilePath))
                    {
                        error.Text = strFileName + " already exists on the server.";
                    }
                    else
                    {
                        FileUpload1.PostedFile.SaveAs(strFilePath);
                        error.Text = client.AddPost(p);
                    }
                }
                else
                {
                    error.Text = "File not found.";
                }
            }
    
        }
    }
}