using EmployeeManagementSystem.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem.Model.Service
{
    public class LoginManager
    {
        String CS = string.Empty;
        public LoginManager()
        {
            // CS = @"data source=ABHI\SQLEXPRESS;database=EMSDB;trusted_connection=true";
            CS = ConfigurationManager.ConnectionStrings["EMPDBCON"].ConnectionString;
        }
        public bool IsValidUser(string UserId,string Password)
        {
            try
            {
                SqlConnection con = new SqlConnection(CS);

                SqlCommand cmd = new SqlCommand(SdProcedures.ValidateUser, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@Password", Password);

                con.Open();
                bool isValid = Convert.ToBoolean(cmd.ExecuteScalar());
                con.Close();

                return isValid;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}