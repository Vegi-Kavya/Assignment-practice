using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebFormsInAsp
{
    public partial class IndianCricketTeam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("data source=DESKTOP-QGCIGIO\\MSSQLSERVER01;database = master;integrated security=SSPI"))
            {
                SqlDataAdapter SDA = new SqlDataAdapter("select * from IndianCricketTeam", con);//to retrieve data from database-student
                DataSet ds = new DataSet();//to convert dataa into grid
                SDA.Fill(ds);
                datagrid1.DataSource = ds;
                datagrid1.DataBind();
            }
        }

        protected void datagrid1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}