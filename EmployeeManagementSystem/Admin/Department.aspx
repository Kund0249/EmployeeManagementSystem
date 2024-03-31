<%@ Page Language="C#"
    AutoEventWireup="true"
    CodeBehind="Department.aspx.cs"
    Inherits="EmployeeManagementSystem.Admin.Department"
    MasterPageFile="~/MasterLayouts/EMS_Layout.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="contentPage">


 <%--   <div class="row bg-info">
        <h2 class="text-center text-light">Add New Department</h2>
    </div>--%>

    <h2 class="">Department</h2>
    <hr />
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
                            CssClass="btn btn-light btn-water" />
                    </td>
                    <td>
                        <asp:Button runat="server" ID="btnSubmit" Text="Submit"
                            CssClass="btn btn-success" OnClick="btnSubmit_Click" />
                    </td>
                </tr>
            </table>

            <div class="mt-3">
                <asp:Label runat="server" ID="lblMessage"></asp:Label>
            </div>
        </div>

    </div>

</asp:Content>
