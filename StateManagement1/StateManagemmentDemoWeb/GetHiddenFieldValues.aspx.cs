using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SateManagementDemoWeb
{
    public partial class GetHiddenFieldValues : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string value = Request.Form["hfcount"];
            Response.Write("Your current hitcount is " + value);
        }
    }
}