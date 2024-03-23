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
        public List<DepartmentDTO> GetDepartments()
        {
            List<DepartmentDTO> departments = new List<DepartmentDTO>();

            String CS = @"data source=ABHI\SQLEXPRESS;database=EMSDB;trusted_connection=true";
            SqlConnection con = new SqlConnection(CS);

            SqlCommand cmd = new SqlCommand("SELECT DepartmentId,DepartmentName FROM TDAPETMENT", con);

            con.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    departments.Add(new DepartmentDTO()
                    {
                        DepartmentId = Convert.ToInt32(dataReader["DepartmentId"]),
                        DepartmentName = dataReader["DepartmentName"].ToString()
                    }) ;
                }
            }
            con.Close();

            return departments;
        }
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