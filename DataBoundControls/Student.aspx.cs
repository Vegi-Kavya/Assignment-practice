using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataBoundControl
{
    public partial class Student : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
            }
        }
        public void Bind()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from StudentTable", con);//select all the record present in the datatable        
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);//retreiving data by creating an instance
            DataSet ds = new DataSet();//setting data into single frame
            adapt.Fill(ds, "StudentTable");//record of employee table record o
            RP1.DataSource = ds.Tables[0];
            RP1.DataBind();
            con.Close();
        }

    }
}