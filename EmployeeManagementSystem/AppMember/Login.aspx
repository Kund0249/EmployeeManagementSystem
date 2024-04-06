<%@ Page Title="" Language="C#" MasterPageFile="~/MasterLayouts/EMS_Layout.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EmployeeManagementSystem.AppMember.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headsection" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentPage" runat="server">
    <div class="row mt-5">
        <div class="col-6 offset-3">
            <table class="table">
                <tr>
                    <th>UserId</th>
                    <td>
                        <asp:TextBox runat="server" ID="txtUserId" CssClass="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>Password</th>
                    <td>
                        <asp:TextBox TextMode="Password" runat="server" ID="txtpassword" CssClass="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                   
                    <td>
                        <asp:Button runat="server" ID="btnSubmit" Text="Login"
                            CssClass="btn btn-success" OnClick="btnSubmit_Click"/>
                    </td>
                    <td>
                        <asp:HyperLink runat="server" Text="don't have account? register here." NavigateUrl="~/AppMember/Login.aspx"></asp:HyperLink>
                    </td>
                </tr>
            </table>

            <div class="mt-3">
                <asp:Label runat="server" ID="lblMessage"></asp:Label>
            </div>
        </div>

    </div>
</asp:Content>
