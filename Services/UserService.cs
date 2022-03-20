using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.Net;
using System.Data;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class UserService : IUser
    {
        worldofmemoryEntities db = new worldofmemoryEntities();

        string IUser.AddPost(post pst)
        {
            try
            { 
                post p = new post();
                p.username = pst.username;
                p.post_path = pst.post_path;
                Console.WriteLine("INN");
                Console.WriteLine(p.username);
                Console.WriteLine(p.post_path);
                db.posts.Add(p);
                db.SaveChanges();
                Console.WriteLine("success");
                string message = " has been Added Successfully.";
                return message;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return e.Message;
            }

        }

        string IUser.DeletePost(int id)
        {
            try
            {
                post pst = db.posts.Where(p => (p.Id == id)).FirstOrDefault();
                string path = pst.post_path;
                db.posts.Remove(pst);
                db.SaveChanges();
                return path;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return e.Message;
            }
        }

        List<post> IUser.ViewPosts(string username)
        {
            try
            {
                List<post> post_list = new List<post>();
                IEnumerable<Friend> friends = db.Friends.Where(f => (f.username == username) ).ToList();
                foreach (var f in friends)
                {
                   IEnumerable<post> pst = db.posts.Where(p => (p.username == f.friend_name));                   
                   foreach (var pt in pst)
                   {
                        post_list.Add(pt);
                   }
                }
                for (int i = 0, j = post_list.Count - 1; i < j; i++)
                {
                    post temp = post_list[j];
                    post_list.RemoveAt(j);
                    post_list.Insert(i, temp);
                }
                foreach (var pst in post_list)
                {
                    Console.WriteLine(pst.username);
                }
                return post_list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        List<post> IUser.ViewMyPosts(string username)
        {
            try
            {
                List<post> post_list = db.posts.Where(f => (f.username == username)).ToList();            
                return post_list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        int IUser.LikePost(int id)
        {
            try
            {
                post pt = db.posts.Where(p => p.Id == id).FirstOrDefault<post>();
                if (pt != null)
                {
                    Console.WriteLine("Post Found");
                    pt.likes = pt.likes + 1;
                    db.SaveChanges();
                    return pt.likes;
                }
                Console.WriteLine("User not Found");
                return -1;
            }
            catch (Exception e)
            {
                return -2;
            }
        }

        UserMessage IUser.login(RequestUSer request)
        {
            UserMessage msg = new UserMessage();
            try
            {
                Console.WriteLine("Here.........." + request.user.username + "  " + request.user.password);

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
            }
            catch (Exception e)
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
                if (cechk_user == null)
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
            catch (Exception e)
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
                    user.friends = check_user.friends;
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

        IEnumerable<User> IUser.GetSuggestedUser(string username)
        {
            try
            {
                IEnumerable<User> Users_ = db.Users.Where(u => u.username != username).ToList();
                IEnumerable<Friend> followed = db.Friends.Where(f => (f.username == username)).ToList();
                foreach (var u in Users_)
                {
                    foreach (var f in followed)
                    {
                        if(u.username == f.friend_name)
                        {
                            Users_ = Users_.Where(user => user.username != u.username);
                            break;
                        }
                    }
                }
                return Users_.Take(10);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public UserMessage UpdateUser(RequestUSer request)
        {
            UserMessage msg = new UserMessage();
            try
            {
                User new_user = new User();
                var cechk_user = db.Users.Where(u => u.username == request.user.username).FirstOrDefault<User>();
                if (cechk_user != null)
                {
                    Console.WriteLine("User Found");
                    cechk_user.username = request.user.username;
                    cechk_user.name = request.user.name;
                    cechk_user.email = request.user.email;
                    cechk_user.profile_pic = request.user.profile_pic;
                    db.SaveChanges();
                    msg.StatusCode = 200;
                    msg.user = cechk_user;
                    return msg;
                }
                Console.WriteLine("User not Found");
                msg.Error = "User Doesn't exists!!";
                msg.StatusCode = 400;
                msg.user = new_user;
                return msg;
            }
            catch (Exception e)
            {
                msg.Error = e.Message;
                msg.StatusCode = 500;
                return msg;
            }
        }

        public string AddFreind(string username, string friendname)
        {
            try
            {
                var user = db.Users.Where(u => u.username == username).FirstOrDefault();
                if (user != null)
                {
                    var friend = db.Users.Where(f => f.username == friendname).FirstOrDefault();
                    if (friend != null)
                    {
                        var check_entry = db.Friends.Where(f => f.username == username && f.friend_name == friendname).FirstOrDefault();
                        if(check_entry == null)
                        {
                            Friend new_entry = new Friend();
                            new_entry.username = username;
                            new_entry.friend_name = friendname;
                            user.friends = user.friends + 1;
                            db.Friends.Add(new_entry);
                            db.SaveChanges();
                            return friendname + " added as friend";
                        }
                        else
                        {
                            return friendname + " already added as friend";

                        }
                    }
                    else
                    {
                        return "Can't add " + friendname + " as friend";
                    }
                }
                return "Can't add " + friendname + " as friend";
            }
            catch (Exception e)
            {
                return "Unable to Add Friend";
            }
        }

        public string RemoveFriend(string username, string friendname)
        {
            try
            {
                var user = db.Users.Where(u => u.username == username).FirstOrDefault();
                if (user != null)
                {
                    var friend = db.Users.Where(f => f.username == friendname).FirstOrDefault();
                    if (friend != null)
                    {
                        var check_entry = db.Friends.Where(f => f.username == username && f.friend_name == friendname).FirstOrDefault();
                        if (check_entry != null)
                        {
                            db.Friends.Remove(check_entry);
                            user.friends = user.friends - 1;
                            db.SaveChanges();
                            return friendname + " remove from friend list";
                        }
                        else
                        {
                            return friendname + " is not your friend";

                        }
                    }
                    else
                    {
                        return "Can't remove " + friendname + " as friend";
                    }
                }
                return "Can't remove " + friendname + " as friend";
            }
            catch (Exception e)
            {
                return "Unable to Remove Friend";
            }
        }
        public IEnumerable<User> GetFriends(string username)
        {
            try
            {
                IEnumerable<Friend> friends = db.Friends.Where(f => f.username == username).ToList();
                IEnumerable<User> friendList = new List<User>();
                foreach (var f in friends)
                {
                    //User u = 
                    friendList = friendList.Append(db.Users.Where(u => u.username == f.friend_name).FirstOrDefault());
                }
                return friendList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public string DeleteAccount(string username)
        {
            try
            {
                User account = db.Users.Where(u => u.username == username).FirstOrDefault();
                if(account != null)
                {
                    var friends = db.Friends.Where(f => f.username == username || f.friend_name == username).ToList();
                    var posts = db.posts.Where(p => p.username == username).ToList();
                    foreach (var f in friends)
                    {
                        db.Friends.Remove(f);
                    }
                    foreach (var p in posts)
                    {
                        db.posts.Remove(p);
                    }
                    db.Users.Remove(account);
                    db.SaveChanges();
                    return "Account Deleted !";
                }
                else
                {
                    return "Unable to delete account";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "Something Went Wrong";
            }
        }

    }
}
