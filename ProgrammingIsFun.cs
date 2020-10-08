﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProgrammingisFun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = "Click me";
            b.Size = new Size(100, 50);
            b.Location = new Point(200, 200);
            this.Controls.Add(b);
            b.Click += new EventHandler(button1_Click1);
            //b.Click += delegate (object sender2, EventArgs e2)
            //{
            //    MessageBox.Show("Programming is Fun");
            //};
        }
        private void button1_Click1(object sender1, EventArgs e1)
        {
            MessageBox.Show("Programming is Fun");
        }
    }
}

