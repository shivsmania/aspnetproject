using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EducationSystem.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        public string user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            else
            {
                user = Session["user"].ToString();
            }
        }

        protected void logOutBtn_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Session.Abandon();
                Session["user"] = "";
                Response.Redirect("~/Login.aspx");
            }
        }
    }
}