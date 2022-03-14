<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Client.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Home.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mx-auto mt-5">
        <div class="col-9">
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
                <ItemTemplate>
                    <div class="card mb-5">
                        <div class="card-header">
                            <img src="WebImage/bg1.jpg" class="account-img" />
                            <span class="username">Hello, <%#Eval("username")%></span>
                            <button runat="server" style="float: right; margin-top: 10px;" class="btn btn-mini">
                                <i class="fa-solid fa-thumbs-up"></i>

                            </button>
                        </div>

                        <div class="image_post">
                            <img src="<%#Eval("post_path")%>" class="center" />
                        </div>
                        <div class="card-footer">
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:worldofmemoryConnectionString %>" SelectCommand="SELECT [post_path], [username], [likes] FROM [posts]"></asp:SqlDataSource>
        </div>
    </div>
    <div class="col-3">
        <div class="fixed-col">
            <div>
                <img src="Profile_pic/defualt_user.png" class="account-img" />
                <asp:Label ID="myusername" runat="server" Text="" Style="color: white;"></asp:Label>
            </div>
            <div class="mt-4">
                <h5 style="color: red;">Suggestions for you</h5>
            </div>

            <div class="row mt-2">

                <div class="col-2">
                    <img src="WebImage/back.jpg" class="account-img" />

                </div>
                <div class="col-6 overflow-hidden" style="text-overflow: ellipsis;">
                    <span style="color: white;">UsernamedsacdVDFGBDFBDFNfcnbfgngdfGSDFEe</span>
                </div>
                <div class="col-4">
                    <span style="color: dodgerblue;">Follow</span>
                </div>

            </div>
            <div class="row mt-2">

                <div class="col-2">
                    <img src="WebImage/back.jpg" class="account-img" />

                </div>
                <div class="col-6 overflow-hidden" style="text-overflow: ellipsis;">
                    <span style="color: white;">UsernamedsacdVDFGBDFBDFNfcnbfgngdfGSDFEe</span>
                </div>
                <div class="col-4">
                    <span style="color: dodgerblue;">Follow</span>
                </div>

            </div>
            <div class="row mt-2">

                <div class="col-2">
                    <img src="WebImage/back.jpg" class="account-img" />

                </div>
                <div class="col-6 overflow-hidden" style="text-overflow: ellipsis;">
                    <span style="color: white;">UsernamedsacdVDFGBDFBDFNfcnbfgngdfGSDFEe</span>
                </div>
                <div class="col-4">
                    <span style="color: dodgerblue;">Follow</span>
                </div>

            </div>
            <div class="row mt-2">

                <div class="col-2">
                    <img src="WebImage/back.jpg" class="account-img" />

                </div>
                <div class="col-6 overflow-hidden" style="text-overflow: ellipsis;">
                    <span style="color: white;">UsernamedsacdVDFGBDFBDFNfcnbfgngdfGSDFEe</span>
                </div>
                <div class="col-4">
                    <span style="color: dodgerblue;">Follow</span>
                </div>

            </div>
        </div>
    </div>

</asp:Content>
