<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Client.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Home.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mx-auto mt-5">
        <div class="col-9">
            <%-- <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <table>
                        <tbody>
                            <tr>
                                <td colspan="2">
                                    <input id="Hidden1" type="hidden" value='<%#Eval("Id") %>' />
                                    <div class="py-2 h5"><b>Q.<%#Eval("question") %></b></div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class="card mb-5">
                                        <div class="card-header">
                                            <img src="WebImage/bg1.jpg" class="account-img" />
                                            <span class="username">Username</span>
                                            <button runat="server" style="float: right; margin-top: 10px;" class="btn btn-mini">
                                                <i class="fa-solid fa-thumbs-up"></i>

                                            </button>
                                        </div>

                                        <div class="image_post">
                                            <img src="WebImage/back.jpg" class="center" />
                                        </div>
                                        <div class="card-footer">
                                        </div>
                                    </div>
                                </td>

                            </tr>
                        </tbody>
                    </table>

                </ItemTemplate>
            </asp:Repeater>--%>


            <div class="card mb-5">
                <div class="card-header">
                    <img src="WebImage/bg1.jpg" class="account-img" />
                    <span class="username">Username</span>
                    <button runat="server" style="float: right; margin-top: 10px;" class="btn btn-mini">
                        <i class="fa-solid fa-thumbs-up"></i>

                    </button>
                </div>

                <div class="image_post">
                    <img src="WebImage/back.jpg" class="center" />
                </div>
                <div class="card-footer">
                </div>
            </div>
            <div class="card mb-5">
                <div class="card-header">
                    <img src="WebImage/bg1.jpg" class="account-img" />
                    <span class="username">Username</span>
                </div>

                <div class="image_post">
                    <img src="WebImage/back.jpg" class="center" />
                </div>
                <div class="card-footer">
                    <i class="fa-solid fa-thumbs-up"></i>
                </div>
            </div>
        </div>
        <div class="col-3">
            <div class="fixed-col">
                <div>
                    <img src="Profile_pic/defualt_user.png" class="account-img" />
                    <asp:Label ID="myusername" runat="server" Text="" style="color: white;"></asp:Label>
                </div>
                <div class="mt-4">
                    <h5 style="color: red;">Suggestions for you</h5>
                </div>
                <%--<asp:Repeater ID="Repeater2" runat="server">
                    <ItemTemplate>
                        <tbody>
                            <tr>
                                <td>
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
                                </td>
                            </tr>
                        </tbody>

                    </ItemTemplate>
                </asp:Repeater>--%>

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

    </div>
</asp:Content>
