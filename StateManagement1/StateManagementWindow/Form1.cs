using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StateManagementDemo
{
    public partial class Form1 : Form
    {
        int count = 0;//Gllobal declaration
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //logic to demonstrate for count on button click
            count += 1;
            MessageBox.Show("No of hit counts are "+count);
                
        }
    }
}
