using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace EmployeeManagementSystem.Admin
{
    public partial class Department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string DepartmentCode = txtDepartmentCode.Text;
            string DepartmentName = txtDepartmentName.Text;

            //Save data into database
            String CS = @"data source=ABHI\SQLEXPRESS;database=EMSDB;trusted_connection=true";

            SqlConnection con = new SqlConnection(CS);

            // string query = string.Format("Insert into TDAPETMENT (DepartmentCode,DepartmentName) Values('{0}','{1}')",DepartmentCode,DepartmentName);


            //SqlCommand cmd = new SqlCommand(query, con);

            //con.Open();
            //int row = cmd.ExecuteNonQuery();
            //con.Close();

            //if (row > 0)
            //{
            //    txtDepartmentCode.Text = string.Empty;
            //    txtDepartmentName.Text = string.Empty;
            //    lblMessage.Text = $"{row} rows inserted!";
            //    lblMessage.ForeColor = System.Drawing.Color.Green;
            //}
            //else
            //{
            //    lblMessage.Text = $"There is some problem";
            //    lblMessage.ForeColor = System.Drawing.Color.Red;
            //}

            SqlCommand cmd = new SqlCommand("spAddDepartment", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@departmentCode", DepartmentCode);
            cmd.Parameters.AddWithValue("@departmentName", DepartmentName);

            con.Open();
            string StatusCode =  (string)cmd.ExecuteScalar();
            con.Close();


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