﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loading.BackgroundImageLayout = ImageLayout.Stretch;
        }

        

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            loading.Visible = true;
            label1.Visible = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            start.Visible = false;
            percentage.Visible = true;
            percentage.Text = progressBar1.Value.ToString() + "%";
            progressBar1.Increment(5);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                login fm2 = new login();
                fm2.Show();
                this.Hide();
            }

        }

    }
}
