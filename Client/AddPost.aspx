<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddPost.aspx.cs" Inherits="Client.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-6 mx-auto">
        <div class="card mx-auto my-5" style="width: 90%; background-color: rgba(255, 255, 255, 0.7);">
            <div class="card-body">
                <center>
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Add New Post"></asp:Label>
                </center>
                <br /><br />
                <asp:Label ID="error" runat="server" Text="" Style="color: red"></asp:Label>
                <div class="mb-3">
                    <label for="File" class="form-label"><b>Upload your image here</b></label>
                    <asp:FileUpload ID="FileUpload1" runat="server" class="form-control" />
                </div>
                <div class="text-center mt-4 mx-auto mb-3">
                    <asp:Button ID="addpst" runat="server" Text="ADD" class="btn btn-dark btn-outline-light mx-3" OnClick="addpst_Click" />
                </div>
            </div>
        </div>

    </div>
</asp:Content>
