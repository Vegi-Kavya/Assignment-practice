using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinkButton
{
    public partial class LinkButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Linkbutton1_Click(object sender, EventArgs e)
        {
            Hello.Text = "Welcome to Facebook";
            Hello.Text = "Welcome to Youtube";
            Hello.Text = "Welcome to Instagram";
            Hello.Text = "Welcome to hike";
            Hello.Text = "Welcome to Telegram";
        }
    }
}