using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace AspSession
{
    public partial class Datalist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Email");
            table.Rows.Add(1, "kavya", "kavyavegi4@gmail.com");
            table.Rows.Add(2, "samyu", "msamyu18@gmail.com");
            table.Rows.Add(3,"neelu","neelaveniparapati1999@gmail.com");
            table.Rows.Add(4, "jerry", "jyothirmayeenaidu@gmail.com");
            datalist1.DataSource=table;
            datalist1.DataBind();
        }
    }
}