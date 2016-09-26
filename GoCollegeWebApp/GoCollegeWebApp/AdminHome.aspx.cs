using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GoCollegeWebApp
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["AdminID"]!=null || Session["AdminUserName"]!=null)
            {
                //send sessions to master page
                Label masterLabelAdminName = this.Master.FindControl("lblAdminName") as Label;
                masterLabelAdminName.Text = Session["AdminUserName"].ToString();
                //txtContent.Text = string.Empty;

                //this.Master.LabelAdminName = Session["AdminUserName"].ToString();
            }
        }
    }
}