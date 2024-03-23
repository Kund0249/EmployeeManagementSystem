using EmployeeManagementSystem.Model.DTO;
using EmployeeManagementSystem.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem.Model.Service
{
    public class EmployeeRepository
    {
        public int Add(EmployeeDTO employee)
        {
            try
            {
                //Prepare connection - 1
                String CS = @"data source=ABHI\SQLEXPRESS;database=EMSDB;trusted_connection=true";
                SqlConnection con = new SqlConnection(CS);


                //Prepare command - 2
                SqlCommand cmd = new SqlCommand(SdProcedures.AddEmployee, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@Gender", employee.Gender);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@Mob", employee.Mobile);
                cmd.Parameters.AddWithValue("@DepartmentId", employee.DepartmentId);
                //Execute Command - 3

                con.Open();
                int row = cmd.ExecuteNonQuery();
                con.Close();

                return row;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}