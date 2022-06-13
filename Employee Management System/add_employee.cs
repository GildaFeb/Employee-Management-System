using System;
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
    public partial class add_employee : Form
    {
        public add_employee()
        {
            InitializeComponent();
            comboBox1.Items.Add("Single");
            comboBox1.Items.Add("Married");
            comboBox1.Items.Add("divorced");
            comboBox1.Items.Add("widowed");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
