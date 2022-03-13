<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Client.SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mx-auto my-5" style="width: 70%;">
        <div class="row">
            <%--<div class="col-7 mx-auto mt-2">
                <img src="WebImage/back.jpg" style="border-radius: 5%; box-shadow: 10px 10px 10px #ccc;" width=95% height="400" />
            </div>--%>
            <div class="col-7 mx-auto">
                <div class="card mx-auto my-3" style="width: 90%;">
                    <div class="card-body">
                        <asp:Label id="error" runat="server" style="color: red"></asp:Label>

                        <div class="mb-3">
                            <label for="email" class="form-label"><b>Email address</b></label>
                            <span style="color: red">*</span>
                            <asp:Label id="emailError" runat="server" style="color: red"></asp:Label>
                            <asp:TextBox ID="email" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label for="username" class="form-label"><b>Username</b></label>
                            <span style="color: red">*</span>
                            <asp:Label id="usernamerror" runat="server" style="color: red"></asp:Label>
                            <asp:TextBox ID="username" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label for="password" class="form-label"><b>Password</b></label>
                            <span style="color: red">*</span>
                            <asp:Label id="passerror" runat="server" style="color: red"></asp:Label>
                            <asp:TextBox ID="password" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="mb-2">
                            <label for="password" class="form-label"><b>Confirm Password</b></label>
                            <span style="color: red">*</span>
                            <asp:Label id="confpassworderror" runat="server" style="color: red"></asp:Label>
                            <asp:TextBox ID="confpassword" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                        </div>
                        <div>
                            <button type="button" class="btn btn-link">
                                <a href="SignIn.aspx" style="color: red;">Already have an account?</a>
                            </button>
                        </div>
                        <div class="text-center mt-3 ">
                            <asp:Button ID="register" runat="server" Text="Register" class="btn btn-success btn-outline-light mx-3" OnClick="register_Click" />
                        </div>

                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
