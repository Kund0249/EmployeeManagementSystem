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
        public static string RemoveEmployee = "spDeleteEmployee";
        public static string UpdateEmployee = "spUpdateEmployee";
        #endregion

        #region "Department"
        public static string AddDepartment = "spAddDepartment";
        #endregion
    }
}