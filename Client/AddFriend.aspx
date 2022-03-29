<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddFriend.aspx.cs" Inherits="Client.AddFriend" %>

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
                    <asp:Button ID="Follow" runat="server" Text="Follow" class="btn btn-success" OnClick="Follow_Click" />
                    <div>
                        <asp:Label ID="status" runat="server" Text="" Style="color: green"></asp:Label>

                    </div>
                </div>
                <hr />
            </div>
        </div>
        <div class="col-7 post-container">
            <div class="row mt-2">
                <asp:Repeater ID="Repeater2" runat="server">
                    <ItemTemplate>
                        <div class="col-6">
                            <asp:Image ID="Image2" runat="server" ImageUrl='<%#Eval("post_path")%>' class="posts" />
                            <i class="fa-solid fa-heart" style="color: red; font-size: medium;"></i>
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("likes")%>' Style="font-weight: 600"></asp:Label>
                        </div>
                    </ItemTemplate>                    
                </asp:Repeater>
                <center><asp:Label ID="Label3" runat="server" Text="label" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="Red"></asp:Label></center>
            </div>
        </div>
    </div>
</asp:Content>
