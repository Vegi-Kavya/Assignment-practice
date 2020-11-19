using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateAndControlView
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //ViewState[stringkey]=values(object)
            //object obj=viewstate[stringkey]
            int count = 0;
            if (ViewState["counter"] == null)
                count += 1;
            else
                count = ((int)ViewState["counter"])+1;
            ViewState["counter"] = count;
            Response.Write("Page hitcount is " + count);
        }
    }
}