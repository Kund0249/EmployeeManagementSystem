<%@ Page Language="C#"
    AutoEventWireup="true"
    CodeBehind="Department.aspx.cs"
    Inherits="EmployeeManagementSystem.Admin.Department" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Management : Department</title>
    <link href="../Content/css/bootstrap.css" rel="stylesheet" />
    <style>
        /*  .btnStyle{
            color:white;
            background-color : green;
            font : bold;
        }*/
        /*#btnSubmit{
            color:white;
            background-color : green;
            font : bold;
        }

         #btnReset{
            color:white;
            background-color : green;
            font : bold;
        }*/
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row bg-info">
                <h2 class="text-center text-light">Add New Department</h2>
            </div>

            <div class="row mt-5">
                <div class="col-6 offset-3">
                    <table class="table">
                        <tr>
                            <th>Department Code</th>
                            <td>
                                <%--<input type="text" name="txtDepartmentCode" />--%>
                                <asp:TextBox runat="server" ID="txtDepartmentCode" CssClass="form-control"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <th>Department Name</th>
                            <td>
                                <asp:TextBox runat="server" ID="txtDepartmentName" CssClass="form-control"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button runat="server" ID="btnReset" Text="Reset Form"
                                    CssClass="btn btn-light" />
                            </td>
                            <td>
                                <asp:Button runat="server" ID="btnSubmit" Text="Submit"
                                    CssClass="btn btn-success" />
                            </td>
                        </tr>
                    </table>
                </div>

            </div>
        </div>

    </form>
</body>
</html>
