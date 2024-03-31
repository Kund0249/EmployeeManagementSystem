using EmployeeManagementSystem.Model.DTO;
using EmployeeManagementSystem.Model.Service;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagementSystem.Admin
{
    public partial class Employee : System.Web.UI.Page
    {
        EmployeeRepository repository = new EmployeeRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Postback : when user or application subit the form to the server
            if (!IsPostBack)
            {
                LoadDepartment();
                empGrid.DataSource = repository.GetEmployees();
                empGrid.DataBind();
            }
           
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //string Name = txtEmpName.Text;
            //string Gender = rdbGender.SelectedValue;
            //string Email = txtEmail.Text;
            //string Mob = txtMob.Text;
            //int DepartmentId =  Convert.ToInt32(ddlDepartment.SelectedValue)

            //Prepare connection - 1
            //String CS = @"data source=ABHI\SQLEXPRESS;database=EMSDB;trusted_connection=true";
            //SqlConnection con = new SqlConnection(CS);


            ////Prepare command - 2
            //SqlCommand cmd = new SqlCommand("spAddEmployee", con);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //cmd.Parameters.AddWithValue("@DepartmentId", DepartmentId);
            //cmd.Parameters.AddWithValue("@Name", Name);
            //cmd.Parameters.AddWithValue("@Gender", Gender);
            //cmd.Parameters.AddWithValue("@Email", Email);
            //cmd.Parameters.AddWithValue("@Mob", Mob);

            ////Execute Command - 3

            //con.Open();
            //int row = cmd.ExecuteNonQuery();
            //con.Close();

            EmployeeDTO employee = new EmployeeDTO()
            {
                EmpId = (hdfEmpId.Value != ""? Convert.ToInt32(hdfEmpId.Value):0),
                Name = txtEmpName.Text,
                Gender = rdbGender.SelectedValue,
                Email = txtEmail.Text,
                Mobile = txtMob.Text,
                DepartmentId = Convert.ToInt32(ddlDepartment.SelectedValue)
            };

            int row = 0;
            if (employee.EmpId != 0)
                row = repository.Update(employee);
            else
                row = repository.Add(employee);

            if (row == 1)
            {
                hdfEmpId.Value = string.Empty;
                txtEmpName.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtMob.Text = string.Empty;
                rdbGender.ClearSelection();
                ddlDepartment.ClearSelection();

                empGrid.DataSource = repository.GetEmployees();
                empGrid.DataBind();
            }

        }

        private void LoadDepartment()
        {
            //String CS = @"data source=ABHI\SQLEXPRESS;database=EMSDB;trusted_connection=true";
            //SqlConnection con = new SqlConnection(CS);

            //SqlCommand cmd = new SqlCommand("SELECT DepartmentId,DepartmentName FROM TDAPETMENT", con);

            //con.Open();
            //ddlDepartment.DataSource = cmd.ExecuteReader();
            //ddlDepartment.DataBind();
            //con.Close();


            DepartmentRepository repository = new DepartmentRepository();
            List<DepartmentDTO> departments = repository.GetDepartments();

            ddlDepartment.DataSource = departments;
            ddlDepartment.DataBind();

            ListItem item = new ListItem() { Value = "-1", Text = "Select Department" };

            ddlDepartment.Items.Insert(0, item);
        }

        protected void empGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(empGrid.DataKeys[empGrid.SelectedIndex].Value);
            EmployeeDTO employee = repository.GetEmployee(id);

            if(employee != null)
            {
                hdfEmpId.Value = employee.EmpId.ToString();
                txtEmpName.Text = employee.Name;
                txtEmail.Text = employee.Email;
                txtMob.Text = employee.Mobile;
                rdbGender.SelectedValue = employee.Gender;
                ddlDepartment.SelectedValue = employee.DepartmentId.ToString();
            }
        }

        protected void empGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Id = Convert.ToInt32(empGrid.DataKeys[e.RowIndex].Value);
            repository.Remove(Id);

            empGrid.DataSource = repository.GetEmployees();
            empGrid.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtSearch.Text);
                empGrid.DataSource = repository.GetEmployees(Id);
                empGrid.DataBind();
            }
            catch (Exception)
            {

               
            }
        }

        protected void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            empGrid.DataSource = repository.GetEmployees();
            empGrid.DataBind();
        }
    }
}