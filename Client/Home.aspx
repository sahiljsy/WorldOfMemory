<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Client.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Home.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mt-5" style="margin-left: 70px; margin-right: 50px;">
        <div class="col-9">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="card mb-5">
                        <div class="card-header">
                            <img src='<%# Eval("profilepicpath") %>' class="account-img" />
                            <asp:Label ID="lblId" Text='<%# Eval("pst.Id") %>' runat="server" Visible="False" />
                            <span class="username"><%#Eval("pst.username")%></span>
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/fontawsome/svgs/solid/thumbs-up.svg" Height="40px" Width="40px" Style="float: right" OnClick="ImageButton1_Click" ForeColor="Red" />
                            <asp:Label ID="Label4" runat="server" Text='<%#Eval("pst.likes")%>' Style="float: right; font-size: 30px; margin-right: 11px; margin-top: 2px;"></asp:Label>
                        </div>
                        <div class="image_post">
                            <img src="<%#Eval("pst.post_path")%>" class="center" />
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="col-3">
            <div class="fixed-col">
                <div>
                    <img src="../Profile_pic/defualt_user.png" class="account-img" />
                    <asp:Label ID="myusername" runat="server" Text="" Style="color: white;"></asp:Label>
                </div>
                <div class="mt-4">
                    <h5 style="color: red;">Suggestions for you</h5>
                </div>
                <asp:Repeater ID="Repeater2" runat="server">
                    <ItemTemplate>
                        <tbody>
                            <tr>
                                <td>
                                    <div class="row mt-3">

                                        <div class="col-4">
                                            <asp:Image ID="profile_photo" class="account-img" runat="server" ImageUrl='<%#Eval("profile_pic")%>' />
                                        </div>
                                        <div class="col-5 overflow-hidden p-2" style="text-overflow: ellipsis;">
                                            <asp:Label ID="user_name" runat="server" Text='<%#Eval("username")%>' Style="color: white;"></asp:Label>

                                        </div>
                                        <div class="col-3 p-2">
                                            <asp:HyperLink ID="follow_act" Style="color: dodgerblue;" runat="server" NavigateUrl='<%#Eval("username", "AddFriend.aspx?username={0}" )%>'>Follow</asp:HyperLink>
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
