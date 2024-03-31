using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem.Utility
{
    public static class SdProcedures
    {
        #region "Employee"
        public static string AddEmployee = "spAddEmployee";
        public static string GetEmployee = "spGetEmployee";
        public static string GetEmployeeById = "spGetEmployeeById";
        public static string UpdateEmployee = "spUpdateEmployee";
        public static string DeleteEmployee = "spDeleteEmployeeById";
        #endregion

        #region "Department"
        public static string AddDepartment = "spAddDepartment";
        #endregion
    }
}