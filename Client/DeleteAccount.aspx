<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DeleteAccount.aspx.cs" Inherits="Client.DeleteAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-7 mx-auto">
            <div class="card mx-auto mt-5 mb-5">
                <div class="card-body mt-5">
                    <center>
                        <h1>Do you want to delete your account?</h1>
                        <asp:Label ID="error" runat="server" Text="" ForeColor="red"></asp:Label>
                    </center>
                </div>

                <div class="card-footer mx-auto mt-3">
                    <asp:LinkButton ID="Cancel" runat="server" CssClass="btn btn-success mx-4" OnClick="Cancel_Click">Cancel</asp:LinkButton>
                    <asp:LinkButton ID="Delete" runat="server" CssClass="btn btn-danger mx-4" OnClick="Delete_Click">Delete</asp:LinkButton>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
