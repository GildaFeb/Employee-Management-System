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
    public partial class employees : Form
    {
        public employees()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            add_employee add_Employee = new add_employee();
            add_Employee.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Close();
        }
    }
}
