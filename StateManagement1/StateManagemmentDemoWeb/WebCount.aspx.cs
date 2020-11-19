using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SateManagementDemoWeb
{
    public partial class WebCount : System.Web.UI.Page
    {
        int count;//Global variable declaration
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            count = int.Parse(hfcount.Value);//hiiddenfield is bby default striing returning specimen
            count += 1;
            hfcount.Value=(count.ToString());
            Response.Write("No of clicks on the button are: " + count);
        }
    }
}