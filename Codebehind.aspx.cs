using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website1
{
    public partial class Codebehind : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("This is red color");
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("This is green color");
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("This is blue color");
        }
    }
}