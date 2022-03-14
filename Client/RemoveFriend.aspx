<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RemoveFriend.aspx.cs" Inherits="Client.RemoveFriend" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/userProfile.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-4 profile-intro">
            <div class="fix-column">
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
                    <asp:Button ID="Remove" runat="server" Text="Remove" class="btn btn-success" OnClick="Remove_Click" />
                    <div>
                        <asp:Label ID="status" runat="server" Text="" Style="color: green"></asp:Label>

                    </div>
                </div>
                <hr />
            </div>
        </div>
        <div class="col-7 post-container">
            <div class="row mt-2">
                <div class="col-4">
                    <asp:Image ID="Image1" runat="server" ImageUrl="WebImage/back.jpg" class="posts" />
                    <div>
                        <i class="fa-solid fa-heart" style="color: red; font-size: medium;"></i>
                        <asp:Label ID="likes" runat="server" Text="0" Style="font-weight: 600"></asp:Label>
                    </div>

                </div>
                <div class="col-4">
                    <asp:Image ID="Image2" runat="server" ImageUrl="WebImage/back.jpg" class="posts" />
                    <i class="fa-solid fa-heart" style="color: red; font-size: medium;"></i>
                    <asp:Label ID="Label1" runat="server" Text="0" Style="font-weight: 600"></asp:Label>
                </div>
                <div class="col-4">
                    <asp:Image ID="Image3" runat="server" ImageUrl="WebImage/back.jpg" class="posts" />
                    <i class="fa-solid fa-heart" style="color: red; font-size: medium;"></i>
                    <asp:Label ID="Label2" runat="server" Text="0" Style="font-weight: 600"></asp:Label>
                </div>
            </div>
            <div class="row mt-2">
                <div class="col-4">
                    <asp:Image ID="Image4" runat="server" ImageUrl="WebImage/back.jpg" class="posts" />
                    <div>
                        <i class="fa-solid fa-heart" style="color: red; font-size: medium;"></i>
                        <asp:Label ID="Label3" runat="server" Text="0" Style="font-weight: 600"></asp:Label>
                    </div>

                </div>
                <div class="col-4">
                    <asp:Image ID="Image5" runat="server" ImageUrl="WebImage/back.jpg" class="posts" />
                    <i class="fa-solid fa-heart" style="color: red; font-size: medium;"></i>
                    <asp:Label ID="Label4" runat="server" Text="0" Style="font-weight: 600"></asp:Label>
                </div>
                <div class="col-4">
                    <asp:Image ID="Image6" runat="server" ImageUrl="WebImage/back.jpg" class="posts" />
                    <i class="fa-solid fa-heart" style="color: red; font-size: medium;"></i>
                    <asp:Label ID="Label5" runat="server" Text="0" Style="font-weight: 600"></asp:Label>
                </div>
            </div>
        </div>

    </div>
</asp:Content>
