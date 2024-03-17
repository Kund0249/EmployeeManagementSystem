<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="EmployeeManagementSystem.Admin.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee</title>
    <link href="../Content/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row bg-info">
                <h2 class="text-center text-light">Add New Employee</h2>
            </div>

            <div class="row mt-5">
                <div class="col-6 offset-3">
                    <table class="table">
                        <tr>
                            <th>Employee Name</th>
                            <td>
                                <asp:TextBox runat="server" ID="txtEmpName" CssClass="form-control"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <th>Gender</th>
                            <td>
                               <asp:RadioButtonList runat="server" ID="rdbGender">
                                   <asp:ListItem Value="M">Male</asp:ListItem>
                                    <asp:ListItem Value="F">Female</asp:ListItem>
                               </asp:RadioButtonList>
                            </td>
                        </tr>
                         <tr>
                            <th>Employee Email</th>
                            <td>
                                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control"></asp:TextBox>
                            </td>
                        </tr>
                         <tr>
                            <th>Employee Contact</th>
                            <td>
                                <asp:TextBox runat="server" ID="txtMob" CssClass="form-control"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button runat="server" ID="btnReset" Text="Reset Form"
                                    CssClass="btn btn-light" />
                            </td>
                            <td>
                                <asp:Button runat="server" ID="btnSubmit" Text="Submit"
                                    CssClass="btn btn-success" OnClick="btnSubmit_Click"/>
                            </td>
                        </tr>
                    </table>

                    <div class="mt-3">
                        <asp:Label runat="server" ID="lblMessage"></asp:Label>
                    </div>
                </div>

            </div>
        </div>
    </form>
</body>
</html>
