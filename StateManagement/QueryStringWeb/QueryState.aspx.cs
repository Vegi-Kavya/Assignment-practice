using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryStringWeb
{
    public partial class QueryState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                TextBox2.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == TextBox3.Text)
            {
                Response.Redirect("Homepage.aspx?Name= " + TextBox1.Text + "&pwd=" + TextBox2.Text);
                Response.Write("User Signup Succesfully");
            }
            else
                lblstatus.Text="Your Password Not Matching";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}