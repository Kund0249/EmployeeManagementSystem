using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using EmployeeManagementSystem.Model.Service;

namespace EmployeeManagementSystem.AppMember
{
    public partial class Login : System.Web.UI.Page
    {
        private readonly LoginManager loginManager;
        public Login()
        {
            loginManager = new LoginManager();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string UserId = txtUserId.Text;
            string Password = txtpassword.Text;

            //if((UserId == "abhishek" && Password == "abhi123") ||
            //    (UserId == "namita" && Password == "nm123") ||
            //    (UserId == "vishal" && Password == "vs123"))
            //{
            //    FormsAuthentication.RedirectFromLoginPage(UserId, false);
            //}
            //else
            //{

            //    string AlertMessage = @"toastr['error']('Invalid userId or Password.', 'Error')";
            //    //ClientScript.RegisterClientScriptBlock(this.GetType(), "S001", "alert('record save successfully.')",true);
            //    ClientScript.RegisterClientScriptBlock(this.GetType(), "E001", AlertMessage, true);
            //}

            if (loginManager.IsValidUser(UserId,Password))
            {
                FormsAuthentication.RedirectFromLoginPage(UserId, false);
            }
            else
            {

                string AlertMessage = @"toastr['error']('Invalid userId or Password.', 'Error')";
                //ClientScript.RegisterClientScriptBlock(this.GetType(), "S001", "alert('record save successfully.')",true);
                ClientScript.RegisterClientScriptBlock(this.GetType(), "E001", AlertMessage, true);
            }
        }
    }
}