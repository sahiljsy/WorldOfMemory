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
        //[OperationContract]
        //DataSet GetSuggestedUser();
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
}
