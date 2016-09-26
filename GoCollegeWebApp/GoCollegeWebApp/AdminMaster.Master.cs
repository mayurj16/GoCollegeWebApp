using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GoCollegeWebApp
{
    public partial class AdminMaster : System.Web.UI.MasterPage
    {
        public string LabelAdminName
        {
            get
            {
                return this.lblAdminName.Text;
            }
            set
            {
                this.lblAdminName.Text = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblAdminName.Text = "Hi";
        }
    }
}