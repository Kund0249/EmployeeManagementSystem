using EmployeeManagementSystem.Model.DTO;
using EmployeeManagementSystem.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem.Model.Service
{
    public class EmployeeRepository
    {
        String CS = string.Empty;
        public EmployeeRepository()
        {
            //CS = @"data source=ABHI\SQLEXPRESS;database=EMSDB;trusted_connection=true";

            CS = ConfigurationManager.ConnectionStrings["EMPDBCON"].ConnectionString;
        }
        public int Add(EmployeeDTO employee)
        {
            try
            {
                //Prepare connection - 1
               // String CS = @"data source=ABHI\SQLEXPRESS;database=EMSDB;trusted_connection=true";
               
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

        public List<EmployeeViewDTO> GetEmployees()
        {
            try
            {
                List<EmployeeViewDTO> employees = new List<EmployeeViewDTO>();

                SqlConnection con = new SqlConnection(CS);
                SqlCommand cmd = new SqlCommand(SdProcedures.GetEmployee, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();
                 SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        EmployeeViewDTO employee = new EmployeeViewDTO()
                        {
                            Name = reader["Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            Contact = reader["Mob"].ToString(),
                            Department = reader["DepartmentName"].ToString(),
                        };

                        employees.Add(employee);
                    }
                }

                con.Close();

                return employees;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}