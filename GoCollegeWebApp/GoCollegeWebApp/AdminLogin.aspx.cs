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
                string adminUN, adminPWD;

                // Fetching Values from Text Box
                adminUN = adminUserName.Text.ToString();
                adminPWD = adminPassword.Text.ToString();


               DataView dv = new DataView();
               dv = objadminBL.AdminLogin(adminUN, adminPWD);

               if (!dv.Count.Equals(0))
               {                  

                   string isFirstTimeLogin;

                   isFirstTimeLogin = dv[0]["AdminStatus"].ToString();

                   if (isFirstTimeLogin.Equals("R"))
                   {
                       Response.Redirect("~/AdminHome.aspx");
                   }
                   else if (isFirstTimeLogin.Equals("A"))
                   {
                       Response.Redirect("~/AdminHome.aspx");

                   }
                   
               }




            }

        }


    }
}