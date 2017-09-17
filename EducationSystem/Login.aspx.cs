using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EducationSystem
{
    public partial class Login : System.Web.UI.Page
    {
        public string alertType;
        public string hidden;

        private void SendError()
        {
            hidden = "visible";
            this.alertType = "alert-danger";
        }
        private void SendSuccess()
        {
            hidden = "visible";
            this.alertType = "alert-success";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            hidden = "hidden";
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            if (username.Value == "Admin" || username.Value == "admin")
            {
                if (password.Value == "admin")
                {
                    alertMsg.Text = "Successfully Login.";
                    SendSuccess();
                    Session["user"] = username.Value;
                    Response.Redirect("Admin/Dashboard.aspx");
                }
                else
                {
                    alertMsg.Text = "Incorrect Password.";
                    SendError();
                }
            }
            else
            {
                alertMsg.Text = "Username not found.";
                SendError();
            }
        }
    }
}