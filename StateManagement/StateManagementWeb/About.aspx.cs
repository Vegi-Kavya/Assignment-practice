using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementWeb
{
    public partial class About : System.Web.UI.Page
    {
        int hitcount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            hitcount = int.Parse(hiddenfield.Value);
            hitcount = hitcount + 1;
            Response.Write("The no of hits on Clickme are: " + hitcount);
            hiddenfield.Value = (hitcount.ToString());
        }
    }
}