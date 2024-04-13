using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagementSystem.Admin
{
    public partial class EmployeeDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Request.QueryString["id"] != null)
                {
                    if(int.TryParse(Request.QueryString["id"],out int EmpId))
                    {
                        lblId.Text = EmpId.ToString();
                    }
                    else
                    {
                        Response.Redirect("~/Admin/Employee.aspx");
                    }
                }
                else
                {
                    Response.Redirect("~/Admin/Employee.aspx");
                }
            }
        }
    }
}