using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementWeb
{
    public partial class HiddenCount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string count = Request.Form["hiddenfield"];
            Response.Write("The current hitcount are: " +count); 
        }
    }
}