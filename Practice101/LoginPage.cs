using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice101
{
    public partial class LoginPage : Form
    {
        string display = " ";
        int value1;
        int value2;
        string operation;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display = display + "1";
            label2.Text = display;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display = display + "2";
            label2.Text = display;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display = display + "3";
            label2.Text = display;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display = display + "4";
            label2.Text = display;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display = display + "5";
            label2.Text = display;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display = display + "6";
            label2.Text = display;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display = display + "7";
            label2.Text = display;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display = display + "8";
            label2.Text = display;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display = display + "9";
            label2.Text = display;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            display = display + "0";
            label2.Text = display;
        }

        private void button18_Click(object sender, EventArgs e)
        {         
            label1.Text = display + " +";
            operation = "addition";
            label2.Text =" ";
            value1 = Convert.ToInt32(display);
            display = " ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            value2 = Convert.ToInt32(display);
            if (operation == "addition")
            {
                label1.Text = " ";
                label2.Text = (value1 + value2).ToString(); 
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            label2.Text = " ";
            display = " ";
        }
    }
}
