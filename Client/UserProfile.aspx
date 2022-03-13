<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="Client.UserProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/userProfile.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-3 profile-intro">
            <div class="fixed-col">
                <div class="upper">
                    <img src="WebImage/back.jpg" />
                </div>
                <div class="user text-center">
                    <div class="profile">
                        <asp:Image ID="UserPic" runat="server" ImageUrl="Profile_pic/defualt_user.png" class="rounded-circle" Width="80" />
                    </div>
                </div>
                <div class="mt-5 text-center">
                    <asp:Label ID="displayUsername" runat="server" Text="Username" class="username"></asp:Label>
                    <asp:Label ID="friends" runat="server" Text="Friends: " class="text-muted d-block mb-2"></asp:Label>
                    <asp:Button ID="Update" runat="server" Text="Upadte" CssClass="btn btn-warning" OnClick="Update_Click" />
                    <asp:Label ID="status" runat="server" Text="" Style="color: green"></asp:Label>

                </div>
                <hr />
                <div class="mb-2">
                    <label for="username" class="form-label"><b>Username</b></label>
                    <asp:Label ID="usernameError" runat="server" Text="" Style="color: red"></asp:Label>
                    <asp:TextBox ID="username" runat="server" class="form-control" Text="usrname" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="row mb-2">
                    <div class="col-6">

                        <label for="name" class="form-label"><b>Name</b></label>
                        <asp:Label ID="nameerror" runat="server" Text="" Style="color: red"></asp:Label>
                        <asp:TextBox ID="name" runat="server" class="form-control" Text="name"></asp:TextBox>
                    </div>
                    <div class="col-6">

                        <label for="Profilepic" class="form-label"><b>Change Profile</b></label>
                        <asp:Label ID="Profilepicerror" runat="server" Text="" Style="color: red"></asp:Label>
                        <asp:FileUpload ID="ProfilePic" runat="server" class="form-control" />
                    </div>
                </div>

                <div class="mb-2">
                    <label for="email" class="form-label"><b>Email</b></label>
                    <asp:Label ID="emailerror" runat="server" Text="" Style="color: red"></asp:Label>
                    <asp:TextBox ID="email" runat="server" class="form-control" Text="abc@gmail.com"></asp:TextBox>
                </div>

            </div>
        </div>
        <div class="col-5 post-container">
            <div class="row mt-2">
                <div class="col-6">
                    <asp:Image ID="Image1" runat="server" ImageUrl="WebImage/back.jpg" class="posts" />
                    <div>
                        <i class="fa-solid fa-heart" style="color: red; font-size: medium;"></i>
                        <asp:Label ID="likes" runat="server" Text="0" Style="font-weight: 600"></asp:Label>
                    </div>

                </div>
                <div class="col-6">
                    <asp:Image ID="Image2" runat="server" ImageUrl="WebImage/back.jpg" class="posts" />
                    <i class="fa-solid fa-heart" style="color: red; font-size: medium;"></i>
                    <asp:Label ID="Label1" runat="server" Text="0" Style="font-weight: 600"></asp:Label>
                </div>
            </div>
            <div class="row mt-2">
                <div class="col-6">
                    <asp:Image ID="Image3" runat="server" ImageUrl="WebImage/back.jpg" class="posts" />
                    <div>
                        <i class="fa-solid fa-heart" style="color: red; font-size: medium;"></i>
                        <asp:Label ID="Label2" runat="server" Text="0" Style="font-weight: 600"></asp:Label>
                    </div>

                </div>
                <div class="col-6">
                    <asp:Image ID="Image6" runat="server" ImageUrl="WebImage/back.jpg" class="posts" />
                    <i class="fa-solid fa-heart" style="color: red; font-size: medium;"></i>
                    <asp:Label ID="Label5" runat="server" Text="0" Style="font-weight: 600"></asp:Label>
                </div>
            </div>
            <div class="row mt-2">
                <div class="col-6">
                    <asp:Image ID="Image4" runat="server" ImageUrl="WebImage/back.jpg" class="posts" />
                    <div>
                        <i class="fa-solid fa-heart" style="color: red; font-size: medium;"></i>
                        <asp:Label ID="Label3" runat="server" Text="0" Style="font-weight: 600"></asp:Label>
                    </div>

                </div>
                <div class="col-6">
                    <asp:Image ID="Image5" runat="server" ImageUrl="WebImage/back.jpg" class="posts" />
                    <i class="fa-solid fa-heart" style="color: red; font-size: medium;"></i>
                    <asp:Label ID="Label4" runat="server" Text="0" Style="font-weight: 600"></asp:Label>
                </div>
            </div>
        </div>
        <div class="col-3 friend-list">
            <div class="fixed-col">
                <h3 style="font-family: fantasy;">Friends </h3>
                <hr />
                <asp:Repeater ID="friendList" runat="server">
                    <ItemTemplate>
                        <tbody>
                            <tr>
                                <td>
                                    <div class="row mt-3">

                                        <div class="col-4">
                                            <asp:Image ID="profile_photo" class="account-img" runat="server" ImageUrl='<%#Eval("profile_pic")%>' />
                                        </div>
                                        <div class="col-5 overflow-hidden pt-3" style="text-overflow: ellipsis;font-family:cursive; font-weight:600">
                                            <asp:Label ID="user_name" runat="server" Text='<%#Eval("username")%>' ></asp:Label>

                                        </div>
                                        <div class="col-3 pt-3">
                                            <asp:HyperLink ID="follow_act" Style="color: darkred; font-weight:600" runat="server" NavigateUrl='<%#Eval("username", "RemoveFriend.aspx?username={0}" )%>'>Remove</asp:HyperLink>
                                        </div>

                                    </div>
                                </td>
                            </tr>
                        </tbody>

                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
