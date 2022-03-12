using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.Net;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class UserService : IUser
    {
        worldofmemoryEntities db = new worldofmemoryEntities();
        UserMessage IUser.login(RequestUSer request)
        {
            UserMessage msg = new UserMessage();
            try
            {
                Console.WriteLine("Here.........."+ request.user.username + "  "+ request.user.password);

                User authenticated_user = new User();
                authenticated_user = db.Users.Where(u => u.username == request.user.username).FirstOrDefault<User>();
                if (authenticated_user != null)
                {
                    if (authenticated_user.password == request.user.password)
                    {
                        msg.StatusCode = 200;
                        msg.user = authenticated_user;
                        Console.WriteLine("User Found");
                        return msg;
                    }
                }
                msg.StatusCode = 400;
                msg.Error = "Username/Password didn't match!!";
                Console.WriteLine("Here");
                return msg;
            }catch(Exception e)
            {
                msg.Error = e.Message;
                msg.StatusCode = 500;
                Console.WriteLine(e.Message);
                return msg;
            }
            
        }

        UserMessage IUser.register(RequestUSer request)
        {
            UserMessage msg = new UserMessage();
            try
            {
                User new_user = new User();
                var cechk_user = db.Users.Where(u => u.username == request.user.username).FirstOrDefault<User>();
                if(cechk_user == null)
                {
                    Console.WriteLine("Username is available");
                    new_user.username = request.user.username;
                    new_user.password = request.user.password;
                    new_user.email = request.user.email;
                    new_user.profile_pic = "Profile_pic/back.jpg";
                    db.Users.Add(new_user);
                    db.SaveChanges();
                    msg.StatusCode = 200;
                    msg.user = new_user;
                    return msg;
                }
                Console.WriteLine("Username is not available");
                msg.Error = "Username Not Available!!";
                msg.StatusCode = 400;
                msg.user = new_user;
                return msg;
            }
            catch(Exception e)
            {
                msg.Error = e.Message;
                msg.StatusCode = 500;
                return msg;
            }
        }
        UserMessage IUser.GetUser(RequestUSer request)
        {
            UserMessage msg = new UserMessage();
            try
            {
                User user = new User();
                var check_user = db.Users.Where(u => u.username == request.user.username).FirstOrDefault<User>();
                if (check_user != null)
                {
                    Console.WriteLine("User is available");
                    user.Id = check_user.Id;
                    user.username = check_user.username;
                    user.name = check_user.name;
                    user.email = check_user.email;
                    user.profile_pic = check_user.profile_pic;
                    user.freinds = check_user.freinds;
                    msg.StatusCode = 200;
                    msg.user = user;
                    return msg;
                }
                msg.Error = "User not Found!";
                msg.StatusCode = 400;
                Console.WriteLine("User is not available");
                return msg;
            }
            catch (Exception e)
            {
                msg.StatusCode = 500;
                msg.Error = e.Message;
                Console.WriteLine(e.Message);
                return msg;
            }
        }
    }
}
