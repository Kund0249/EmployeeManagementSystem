<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Employee.aspx.cs" Inherits="EmployeeManagementSystem.Admin.Employee"
    MasterPageFile="~/MasterLayouts/EMS_Layout.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="headsection">
<%--<script src="https://code.jquery.com/jquery-1.11.1.min.js"></script>--%>

<%--<script src="https://cdn.datatables.net/1.10.4/js/jquery.dataTables.min.js"></script>
<link rel="stylesheet" href="https://cdn.datatables.net/1.10.4/css/jquery.dataTables.min.css">

    <script type="text/javascript">
        $(document).ready(function () {
             $('#contentPage_empGrid').dataTable();
        });
    </script>--%>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="contentPage">

    <%-- <div class="row bg-info">
        <h2 class="text-center text-light">Add New Employee</h2>
    </div>--%>
    <h2>Employee</h2>
    <hr />
    <div class="row mt-5">
        <div class="col-6">
            <asp:HiddenField runat="server" ID="hdfEmpId" />
            <table class="table">
                <tr>
                    <th>Select Department</th>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlDepartment" CssClass="form-control"
                            DataValueField="DepartmentId" DataTextField="DepartmentName">
                            <%--  <asp:ListItem Value="-1">Select Department</asp:ListItem>
                                    <asp:ListItem Value="101">Admin</asp:ListItem>
                                     <asp:ListItem Value="102">Super Admin</asp:ListItem>
                                     <asp:ListItem Value="103">Finance & Account</asp:ListItem>
                                     <asp:ListItem Value="104">Payroll</asp:ListItem>
                                     <asp:ListItem Value="105">Information Technology</asp:ListItem>--%>
                        </asp:DropDownList>
                    </td>
                </tr>
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
                            CssClass="btn btn-light"
                            OnClick="btnReset_Click" />
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
    <hr />
    <div class="row">
        <div class="row">
            <div class="col-8">
                <asp:TextBox runat="server" ID="txtSearch" CssClass="form-control"
                    placeholder="Search employee by employee id."></asp:TextBox>
            </div>
            <div class="col-4">
                <asp:Button runat="server" ID="btnSearch" Text="Search" CssClass="btn btn-primary"
                    OnClick="btnSearch_Click" />

                <asp:Button runat="server" ID="btnClearFilter" Text="Clear Filter" CssClass="btn btn-secondary"
                    OnClick="btnClearFilter_Click" />
            </div>
        </div>
        <div class="row mt-3">
            <asp:GridView runat="server" ID="empGrid" CssClass="table" AutoGenerateColumns="false"
                ShowHeaderWhenEmpty="true"
                EmptyDataText="No Content!"
                EmptyDataRowStyle-CssClass="text-danger text-center"
                DataKeyNames="Id"
                OnSelectedIndexChanged="empGrid_SelectedIndexChanged"
                OnRowDeleting="empGrid_RowDeleting">

                <Columns>
                    <asp:BoundField HeaderText="Name" DataField="Name" />
                    <asp:BoundField HeaderText="Offical Email" DataField="Email" />
                    <asp:BoundField HeaderText="Mobile No." DataField="Contact" />
                    <asp:BoundField HeaderText="Department Name" DataField="Department" />
                    <asp:CommandField HeaderText="Action"
                        ButtonType="Image"
                        ShowDeleteButton="true"
                        DeleteImageUrl="~/Content/AppResource/delete.png"
                        ShowSelectButton="true"
                        SelectImageUrl="~/Content/AppResource/edit.png"
                        ControlStyle-Height="30"
                        ControlStyle-Width="30" />
                </Columns>

            </asp:GridView>
        </div>
    </div>

</asp:Content>


