using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookie
{
    public partial class Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //creating cookie
            HttpCookie cookie = new HttpCookie("student");
            HttpCookie cookie1 = new HttpCookie("employee");
            HttpCookie cookie2 = new HttpCookie("department");
            //assigning value to created cookie
            cookie.Value = "kavya";
            cookie1.Value = "dxc";
            cookie2.Value = "software";
            //add cookie to response instance
            Response.Cookies.Add(cookie);
            Response.Cookies.Add(cookie1);
            Response.Cookies.Add(cookie2);
            //fetch the cookie created
            var cookie_value = Response.Cookies["student"].Value;
            label1.Text = cookie_value;
            var cookie_value1 = Response.Cookies["employee"].Value;
            label2.Text = cookie_value1;
            var cookie_value2 = Response.Cookies["department"].Value;
            label3.Text = cookie_value2;
        }
    }
}