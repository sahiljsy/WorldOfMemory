﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.UserServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Services")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int freindsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string profile_picField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int freinds {
            get {
                return this.freindsField;
            }
            set {
                if ((this.freindsField.Equals(value) != true)) {
                    this.freindsField = value;
                    this.RaisePropertyChanged("freinds");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string profile_pic {
            get {
                return this.profile_picField;
            }
            set {
                if ((object.ReferenceEquals(this.profile_picField, value) != true)) {
                    this.profile_picField = value;
                    this.RaisePropertyChanged("profile_pic");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                if ((object.ReferenceEquals(this.usernameField, value) != true)) {
                    this.usernameField = value;
                    this.RaisePropertyChanged("username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServiceReference.IUser")]
    public interface IUser {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/login", ReplyAction="http://tempuri.org/IUser/loginResponse")]
        Client.UserServiceReference.UserMessage login(Client.UserServiceReference.RequestUSer request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/login", ReplyAction="http://tempuri.org/IUser/loginResponse")]
        System.Threading.Tasks.Task<Client.UserServiceReference.UserMessage> loginAsync(Client.UserServiceReference.RequestUSer request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/register", ReplyAction="http://tempuri.org/IUser/registerResponse")]
        Client.UserServiceReference.UserMessage register(Client.UserServiceReference.RequestUSer request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/register", ReplyAction="http://tempuri.org/IUser/registerResponse")]
        System.Threading.Tasks.Task<Client.UserServiceReference.UserMessage> registerAsync(Client.UserServiceReference.RequestUSer request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUser", ReplyAction="http://tempuri.org/IUser/GetUserResponse")]
        Client.UserServiceReference.UserMessage GetUser(Client.UserServiceReference.RequestUSer request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUser", ReplyAction="http://tempuri.org/IUser/GetUserResponse")]
        System.Threading.Tasks.Task<Client.UserServiceReference.UserMessage> GetUserAsync(Client.UserServiceReference.RequestUSer request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RequestUSer", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class RequestUSer {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Client.UserServiceReference.User user;
        
        public RequestUSer() {
        }
        
        public RequestUSer(Client.UserServiceReference.User user) {
            this.user = user;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UserMessage", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UserMessage {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string Error;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public int StatusCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Client.UserServiceReference.User user;
        
        public UserMessage() {
        }
        
        public UserMessage(string Error, int StatusCode, Client.UserServiceReference.User user) {
            this.Error = Error;
            this.StatusCode = StatusCode;
            this.user = user;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserChannel : Client.UserServiceReference.IUser, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserClient : System.ServiceModel.ClientBase<Client.UserServiceReference.IUser>, Client.UserServiceReference.IUser {
        
        public UserClient() {
        }
        
        public UserClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.UserServiceReference.UserMessage Client.UserServiceReference.IUser.login(Client.UserServiceReference.RequestUSer request) {
            return base.Channel.login(request);
        }
        
        public string login(ref Client.UserServiceReference.User user, out int StatusCode) {
            Client.UserServiceReference.RequestUSer inValue = new Client.UserServiceReference.RequestUSer();
            inValue.user = user;
            Client.UserServiceReference.UserMessage retVal = ((Client.UserServiceReference.IUser)(this)).login(inValue);
            StatusCode = retVal.StatusCode;
            user = retVal.user;
            return retVal.Error;
        }
        
        public System.Threading.Tasks.Task<Client.UserServiceReference.UserMessage> loginAsync(Client.UserServiceReference.RequestUSer request) {
            return base.Channel.loginAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.UserServiceReference.UserMessage Client.UserServiceReference.IUser.register(Client.UserServiceReference.RequestUSer request) {
            return base.Channel.register(request);
        }
        
        public string register(ref Client.UserServiceReference.User user, out int StatusCode) {
            Client.UserServiceReference.RequestUSer inValue = new Client.UserServiceReference.RequestUSer();
            inValue.user = user;
            Client.UserServiceReference.UserMessage retVal = ((Client.UserServiceReference.IUser)(this)).register(inValue);
            StatusCode = retVal.StatusCode;
            user = retVal.user;
            return retVal.Error;
        }
        
        public System.Threading.Tasks.Task<Client.UserServiceReference.UserMessage> registerAsync(Client.UserServiceReference.RequestUSer request) {
            return base.Channel.registerAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.UserServiceReference.UserMessage Client.UserServiceReference.IUser.GetUser(Client.UserServiceReference.RequestUSer request) {
            return base.Channel.GetUser(request);
        }
        
        public string GetUser(ref Client.UserServiceReference.User user, out int StatusCode) {
            Client.UserServiceReference.RequestUSer inValue = new Client.UserServiceReference.RequestUSer();
            inValue.user = user;
            Client.UserServiceReference.UserMessage retVal = ((Client.UserServiceReference.IUser)(this)).GetUser(inValue);
            StatusCode = retVal.StatusCode;
            user = retVal.user;
            return retVal.Error;
        }
        
        public System.Threading.Tasks.Task<Client.UserServiceReference.UserMessage> GetUserAsync(Client.UserServiceReference.RequestUSer request) {
            return base.Channel.GetUserAsync(request);
        }
    }
}