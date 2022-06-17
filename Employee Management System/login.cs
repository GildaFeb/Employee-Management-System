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
    public partial class login : Form
    {
        private int ticks = 0;

        public login()
        {
            InitializeComponent();
            password_.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(password_.Text == "admin" && username_.Text == "admin")
            {
                
                timer1.Start();
            }
            else if (!(password_.Text == "admin") && username_.Text == "admin")
            {
                error_message.Text = " [!] Incorrect password.";
            }
            else if (password_.Text == "admin" && !(username_.Text == "admin"))
            {
                error_message.Text = " [!] Incorrect username";
            }
            else
            {
                error_message.Text = " [!] Incorrect username and password";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            error_message.Text = "LOGIN SUCCESSFUL!";
            error_message.ForeColor = Color.GreenYellow;
            if (ticks == 4)
            {
                dashboard dashboard = new dashboard();
                dashboard.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
