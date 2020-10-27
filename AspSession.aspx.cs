using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspSession
{
    public partial class AspSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void textbox1_TextChanged(object sender, EventArgs e)
        {
            if (password.Text == "kavya")
            {
                //storing an email to session
                Session["email"] = email.Text;
                Session["phone"] = mobile.Text;
            }
            if (Session["email"] != null)
            {
                //display the stored mail
                label1.Text = "this email stored in session";
                label2.Text = Session["email"].ToString();
            }
        }
    }
}