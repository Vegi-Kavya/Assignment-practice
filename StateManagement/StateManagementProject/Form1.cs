using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StateManagementProject
{
    public partial class Form1 : Form
    {
        int hitcount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hitcount += 1;
            MessageBox.Show("The no of hits on Clickme are: " + hitcount);
            if (hitcount == 5)
            {
                MessageBox.Show("The no of hits on Clickme are equal to " + hitcount);
            }
        }
    }
}