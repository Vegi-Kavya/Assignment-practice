using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryStringsWeb
{
    public partial class QueryWebState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                TextBox3.Focus();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text == "Admin" && TextBox4.Text == "Admin")
            {
                Response.Redirect("Homepage.aspx?Name= "+TextBox3.Text +"&pwd="+TextBox4.Text);
                Response.Write("Login Succesful");
            }
            else
                lblstatus.Text = "Invalid User Credentials,Login failed";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}