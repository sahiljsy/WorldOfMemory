using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Services
{
    
    [ServiceContract]
    public interface IUser
    {
        [OperationContract]
        UserMessage login(RequestUSer msg);

        [OperationContract]
        UserMessage register(RequestUSer msg);
        [OperationContract]
        UserMessage GetUser(RequestUSer msg);
        [OperationContract]
        IEnumerable<User> GetSuggestedUser(string username);
        [OperationContract]
        UserMessage UpdateUser(RequestUSer msg);
        [OperationContract]
        string AddFreind(string username, string friendname);
        [OperationContract]
        string RemoveFriend(string username, string friendname);

        [OperationContract]
        IEnumerable<User> GetFriends(string username);
        [OperationContract]
        string DeleteAccount(string username);
        [OperationContract]
        string AddPost(post pst);
        [OperationContract]
        string DeletePost(int id);
        [OperationContract]
        List<DisplayPost> ViewPosts(string username);
        [OperationContract]
        List<post> ViewMyPosts(string username);
        [OperationContract]
        int LikePost(int id,string username);

    }

    [MessageContract]
    public class UserMessage
    {
        [MessageHeader]
        public string Error { get; set; }
        [MessageHeader]
        public int StatusCode { get; set; }

        [MessageBodyMember]
        public User user { get; set; }
    }
    [MessageContract]
    public class RequestUSer
    {
        [MessageBodyMember]
        public User user { get; set; }

    }
    [MessageContract]
    public class DisplayPost
    {
        [MessageBodyMember]
        public string profilepicpath { get; set; }

        [MessageBodyMember]
        public post pst { get; set; }
    }
}
