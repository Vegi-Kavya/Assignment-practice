using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Downloadfile
{
    public partial class Downloadfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            var filepath = "C:\\programs\\kavya\\assesment2.txt";
            FileInfo file = new FileInfo(filepath);
            if (file.Exists)
            {
                //clear the response reframe
                Response.Clear();
                //Add header by specifying filename
                Response.AddHeader("Content-Disposition", "attachment;filename=" + file.Name);
                //add header for content lngth
                Response.AddHeader("Content-Length", file.Length.ToString());
                //specify the content type
                Response.ContentType = "text/plain";
                //clear the flush
                Response.Flush();
                //transmit the file
                Response.TransmitFile(file.FullName);
                Response.End();
            }
            else
            {
                label1.Text = "Requested file not available to download";
            }
        }
    }
}