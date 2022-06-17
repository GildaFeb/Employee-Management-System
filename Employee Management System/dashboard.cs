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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            employees employees = new employees();
            employees.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            attendance attendance = new attendance();   
            attendance.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            salary_details salary_details = new salary_details();   
            salary_details.Show();
            this.Hide();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
           
        }
    }
}
