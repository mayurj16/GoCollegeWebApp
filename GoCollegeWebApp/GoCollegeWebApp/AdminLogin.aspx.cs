using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GoCollege_BL;
using System.Data;


namespace GoCollegeWebApp
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        AdminBL objadminBL = new AdminBL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void adminLoginbtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                // Fetching Values from Text Box

               DataView dv = new DataView();
               dv = objadminBL.AdminLogin(adminUserName.Text.ToString(), adminPassword.Text.ToString());

               if (!dv.Count.Equals(0))
               {
                   Session["AdminID"] = dv[0]["AdminID"].ToString();
                   Session["AdminUserName"] = dv[0]["AdminUserName"].ToString();
                   if (dv[0]["AdminStatus"].ToString().Equals("R"))
                   {
                       Response.Redirect("~/AdminEditDetails.aspx");
                   }
                   else if (dv[0]["AdminStatus"].ToString().Equals("A"))
                   {
                       Response.Redirect("~/AdminHome.aspx");
                   }
               }
               else
               {
                   //Show appropriate error message

               }




            }

        }


    }
}