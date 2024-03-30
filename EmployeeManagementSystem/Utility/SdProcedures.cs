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
        #endregion

        #region "Department"
        public static string AddDepartment = "spAddDepartment";
        #endregion
    }
}