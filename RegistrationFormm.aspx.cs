using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormRegistration
{
    public partial class RegistrationFormm : System.Web.UI.Page
    {
        protected System.Web.UI.HtmlControls.HtmlInputFile Field;
        protected System.Web.UI.HtmlControls.HtmlInputButton Submit;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            message.Text = "Hello "+ Username.Text + " Good Afternoon";
            message.Text = message.Text + " You have succesfully registerd with following details";
            label1.Text = Username.Text;
            label2.Text = EmailAddress.Text;
            showusername.Text = Username.Text;
            showemailadress.Text = EmailAddress.Text;
            if (radiobutton1.Checked)
                showgender.Text = radiobutton1.Text;
            else
                showgender.Text = radiobutton2.Text;
            var courses = "";
            if (checkbox1.Checked)
                showcourses.Text = checkbox1.Text + " " ; 
            if (checkbox2.Checked)
                showcourses.Text += checkbox2.Text + " "; 
            if (checkbox3.Checked)
                showcourses.Text += checkbox3.Text + " "; 
            if (checkbox4.Checked)
                showcourses.Text = checkbox4.Text + " " ; 
            if (checkbox5.Checked)
                showcourses.Text = checkbox5.Text + " " ; 
            if (checkbox6.Checked)
                showcourses.Text = checkbox6.Text + " "; 
            if (checkbox7.Checked)
                showcourses.Text = checkbox7.Text + " "; 
           
            showccourses.Text = courses;
            Username.Text = "";
            EmailAddress.Text = "";

            radiobutton1.Checked = false;
            radiobutton2.Checked = false;
            checkbox1.Checked = false;
            checkbox2.Checked = false;
            checkbox3.Checked = false;
            checkbox4.Checked = false;
            checkbox5.Checked = false;
            checkbox6.Checked = false;
            checkbox7.Checked = false;
            //showusernamelabel.Text =" Username";
            //showemailaddresslabel.Text = "EmailAddress";
            //showgenderlabel.Text = "gender";
            //showcourseslabel.Text= "courses";
        }
    }
}
