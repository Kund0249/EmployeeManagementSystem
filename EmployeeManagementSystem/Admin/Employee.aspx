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
                    <th>Profile Image</th>
                    <td>
                        <asp:FileUpload runat="server" ID="ImageFile" CssClass="form-control" />
                    </td>
                </tr>
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
                        <asp:RequiredFieldValidator runat="server"
                            ControlToValidate="ddlDepartment"
                            ErrorMessage="Please select department."
                            ForeColor="Red"
                            Display="Dynamic"
                            InitialValue="-1"
                            SetFocusOnError="true"
                            ValidationGroup="EmpValidationGrp">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <th>Employee Name</th>
                    <td>
                        <asp:TextBox runat="server" ID="txtEmpName" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server"
                            ControlToValidate="txtEmpName"
                            ErrorMessage="Please enter name."
                            ForeColor="Red"
                            Display="Dynamic"
                            SetFocusOnError="true"
                            ValidationGroup="EmpValidationGrp">
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator runat="server"
                            ControlToValidate="txtEmpName"
                            ErrorMessage="Only alphabets are allowed."
                            ValidationExpression="[a-zA-Z\s]*"
                            ForeColor="Red"
                            Display="Dynamic"
                            ValidationGroup="EmpValidationGrp">
                        </asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <th>Gender</th>
                    <td>
                        <asp:RadioButtonList runat="server" ID="rdbGender">
                            <asp:ListItem Value="M">Male</asp:ListItem>
                            <asp:ListItem Value="F">Female</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:RequiredFieldValidator runat="server"
                            ControlToValidate="rdbGender"
                            ErrorMessage="Please select gender."
                            ForeColor="Red"
                            Display="Dynamic"
                            ValidationGroup="EmpValidationGrp">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <th>Employee Email</th>
                    <td>
                        <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server"
                            ControlToValidate="txtEmail"
                            ErrorMessage="Please enter email address."
                            ForeColor="Red"
                            Display="Dynamic"
                            ValidationGroup="EmpValidationGrp">
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator runat="server"
                            ControlToValidate="txtEmail"
                            ErrorMessage="please enter a valid email address."
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                            ForeColor="Red"
                            Display="Dynamic"
                            ValidationGroup="EmpValidationGrp"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <th>Employee Contact</th>
                    <td>
                        <asp:TextBox runat="server" ID="txtMob" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server"
                            ControlToValidate="txtMob"
                            ErrorMessage="Please enter contact number."
                            ForeColor="Red"
                            Display="Dynamic"
                            ValidationGroup="EmpValidationGrp">
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator runat="server"
                            ControlToValidate="txtMob"
                            ErrorMessage="please enter a valid  contact number."
                            ValidationExpression="[6-9]{1}[0-9]{9}"
                            ForeColor="Red"
                            Display="Dynamic"
                            ValidationGroup="EmpValidationGrp"></asp:RegularExpressionValidator>
                    </td>
                </tr>

                <tr>
                    <th>Salary</th>
                    <td>
                        <asp:TextBox runat="server" ID="txtSalary" CssClass="form-control"></asp:TextBox>
                        <asp:RangeValidator runat="server"
                             ControlToValidate="txtSalary"
                            ErrorMessage="please enter a salary between 10000 and 100000."
                            Type="Integer"
                            MinimumValue="10000"
                            MaximumValue="100000"
                            ForeColor="Red"
                            Display="Dynamic">

                        </asp:RangeValidator>
                    </td>
                </tr>

                <tr>
                    <th>Employee Salary Ac No.</th>
                    <td>
                        <asp:TextBox runat="server" ID="txtSalaryAccount" CssClass="form-control"
                            TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server"
                            ControlToValidate="txtSalaryAccount"
                            ErrorMessage="Please enter account number."
                            ForeColor="Red"
                            Display="Dynamic">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <th>Reenter Salary Ac No.</th>
                    <td>
                        <asp:TextBox runat="server" ID="txtReSalaryAccount" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server"
                            ControlToValidate="txtReSalaryAccount"
                            ErrorMessage="Please enter account number."
                            ForeColor="Red"
                            Display="Dynamic">
                        </asp:RequiredFieldValidator>
                        <asp:CompareValidator runat="server"
                            ControlToValidate="txtReSalaryAccount"
                            ControlToCompare="txtSalaryAccount"
                            ErrorMessage="account number does not matches."
                            ForeColor="Red"
                            Display="Dynamic">
                        </asp:CompareValidator>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Button runat="server" ID="btnReset" Text="Reset Form"
                            CssClass="btn btn-light"
                            OnClick="btnReset_Click" 
                            CausesValidation="false"/>
                    </td>
                    <td>
                        <asp:Button runat="server" ID="btnSubmit" Text="Submit"
                            CssClass="btn btn-success" OnClick="btnSubmit_Click" 
                            ValidationGroup="EmpValidationGrp"/>
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
                    <%--<asp:BoundField HeaderText="Name" DataField="Name" />--%>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:HyperLink runat="server" 
                                NavigateUrl='<%# string.Format("~/Admin/EmployeeDetail.aspx?id={0}",Eval("Id")) %>'>
                                <asp:Label runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                            </asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
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


