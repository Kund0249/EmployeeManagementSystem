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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //string Name = txtEmpName.Text;
            //string Gender = rdbGender.SelectedValue;
            //string Email = txtEmail.Text;
            //string Mob = txtMob.Text;

            //Prepare connection - 1
            //String CS = @"data source=ABHI\SQLEXPRESS;database=EMSDB;trusted_connection=true";
            //SqlConnection con = new SqlConnection(CS);


            ////Prepare command - 2
            //SqlCommand cmd = new SqlCommand("spAddEmployee", con);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;

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
                Name = txtEmpName.Text,
                Gender = rdbGender.SelectedValue,
                Email = txtEmail.Text,
                Mobile = txtMob.Text
            };

            EmployeeRepository repository = new EmployeeRepository();
            int row = repository.Add(employee);

            if (row == 1)
            {
                txtEmpName.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtMob.Text = string.Empty;
                rdbGender.ClearSelection();
            }

        }
    }
}