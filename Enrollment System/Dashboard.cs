using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class Dashboard : Form
    {
        public string Username { get; set; }
     
        public Dashboard(string user_name)
        {
            InitializeComponent();
            user.Text = user_name;
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            homePage1.Show();
            enrolleesPage1.Hide();
            subjectpage.Hide();
            coursepage.Hide();
            instructorepage.Hide();
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            homePage1.Show();
            enrolleesPage1.Hide();
            homePage1.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            enrolleesPage1.Show();
            homePage1.Hide();
            enrolleesPage1.BringToFront();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            subjectpage.Show();
            subjectpage.BringToFront();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            coursepage.Show();
            coursepage.BringToFront();
            enrolleesPage1.Hide();
            subjectpage.Hide();
            instructorepage.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            instructorepage.Show();
            instructorepage.BringToFront();
            enrolleesPage1.Hide();
            subjectpage.Hide();
            coursepage.Hide();

        }
        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successfully!");
            Enrollment f1 = new Enrollment();
            f1.Show();
            Visible = false;
        }

       
    }
}
