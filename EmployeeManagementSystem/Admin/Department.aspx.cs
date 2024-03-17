using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using EmployeeManagementSystem.Model.DTO;
using EmployeeManagementSystem.Model.Service;

namespace EmployeeManagementSystem.Admin
{
    public partial class Department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string StatusCode = string.Empty;

            DepartmentDTO department = new DepartmentDTO()
            {
                DepartmentCode = txtDepartmentCode.Text,
                DepartmentName = txtDepartmentName.Text
            };

            DepartmentRepository repository = new DepartmentRepository();
            StatusCode = repository.Add(department);


            if (StatusCode == "S001")
            {
                txtDepartmentCode.Text = string.Empty;
                txtDepartmentName.Text = string.Empty;
                lblMessage.Text = $"Record inserted!";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            else if (StatusCode == "RE01")
            {
                lblMessage.Text = $"Department already exist with same code or name.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblMessage.Text = $"There is some problem";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}