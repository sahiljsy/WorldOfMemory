<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="Client.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mx-auto my-5" style="width: 70%;">
        <div class="row">
            <%--<div class="col-7 mx-auto mt-2">
                <img src="WebImage/back.jpg" style="border-radius: 5%; box-shadow: 10px 10px 10px #ccc;" width=95% height="400" />
            </div>--%>
            <div class="col-6 mx-auto">
                <div class="card mx-auto my-5" style="width: 90%;">
                    <div class="card-body">
                            <asp:Label ID="error" runat="server" Text="" style="color:red"></asp:Label>
                        <div class="mb-3">
                            <label for="username" class="form-label" ><b>Username</b></label>
                            <asp:Label ID="usernameError" runat="server" Text="*" style="color:red"></asp:Label>
                            <asp:TextBox ID="username" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-2">
                            <label for="password" class="form-label" ><b>Password</b></label>
                            <asp:Label ID="passwordError" runat="server" Text="*" style="color:red"></asp:Label>
                            <asp:TextBox ID="password" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                        </div>
                        <div>
                            <button type="button" class="btn btn-link">Forgot Password?</button>
                        </div>
                        <div class="text-center mt-4 mx-auto mb-3">
                            <asp:Button ID="login" runat="server" Text="Login" class="btn btn-dark btn-outline-light mx-3" OnClick="login_Click" />
                            <button type="button" class="btn btn-dark btn-outline-light mx-3">
                                <a href="./SignUp.aspx">Signup</a>
                            </button>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
