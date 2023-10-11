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
    public partial class StudentDashboard : Form
    {
        public string Username { get; set; }
        public StudentDashboard(string user_name)
        {
            InitializeComponent();
            studenthomepage2.Show();               
            studentEnrollmentPage1.Hide();
            studenthomepage2.BringToFront();
            user.Text = user_name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studenthomepage2.Hide();
            studentEnrollmentPage1.Show();
            studentEnrollmentPage1.BringToFront();           
            Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            studenthomepage2.Show();
            studenthomepage2.BringToFront();
            Visible = true;             
        }


    }
}
