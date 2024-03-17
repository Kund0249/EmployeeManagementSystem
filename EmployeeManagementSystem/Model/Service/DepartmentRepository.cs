using EmployeeManagementSystem.Model.DTO;
using EmployeeManagementSystem.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem.Model.Service
{
    public class DepartmentRepository
    {
        public string Add(DepartmentDTO department)
        {
            try
            {
                String CS = @"data source=ABHI\SQLEXPRESS;database=EMSDB;trusted_connection=true";

                SqlConnection con = new SqlConnection(CS);
                SqlCommand cmd = new SqlCommand(SdProcedures.AddDepartment, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@departmentCode", department.DepartmentCode);
                cmd.Parameters.AddWithValue("@departmentName", department.DepartmentName);

                con.Open();
                string StatusCode = (string)cmd.ExecuteScalar();
                con.Close();
                return StatusCode;
            }
            catch (Exception ex)
            {
                return "404";
            }
        }
    }
}