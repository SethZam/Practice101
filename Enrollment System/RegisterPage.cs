﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Enrollment_System
{
    public partial class RegisterPage : Form
    
    {
        int age;
        DateTime birth;
        Regex validateEmail = new Regex("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
        Regex validatephone = new Regex("^(09)\\d{9}");
        public RegisterPage()
        {
            InitializeComponent();
        }
        EnrollmentDataContext db = new EnrollmentDataContext();
        private void login_Click(object sender, EventArgs e)
        {
            if (IsEmpty() is true)
            {
                MessageBox.Show("Enter all informations", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(CheckAccount() is false )
            {
                MessageBox.Show("Username is already used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pass.Text != cpass.Text)
            {
                MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CheckEmail() is false)
            {
                MessageBox.Show("You've Entered Invalid Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CheckTel() is false)
            {
                MessageBox.Show("You've Entered Invalid Phone Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                birth = DateTime.Parse(bd.Text);
                age = GetAge(birth);
                db.create_account(username.Text, pass.Text, fname.Text, mname.Text, lname.Text, DateTime.Parse(bd.Text), age, addrss.Text, email.Text, tel.Text);
                MessageBox.Show("Create account successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enrollment f1 = new Enrollment();
                f1.Show();
                MessageBox.Show("Log in to your account!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Visible = false;
            }
        }
        bool IsEmpty()
        {
            if (username.Text == "" || pass.Text =="" || cpass.Text =="" || fname.Text =="" || mname.Text=="" || lname.Text =="" ||addrss.Text =="" || email.Text =="" || tel.Text =="")
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        static int GetAge(DateTime birth)
        {

            int age;
            if (birth.Month <= DateTime.Now.Month && birth.Day <= DateTime.Now.Day)
            {
                age = DateTime.Now.Year - birth.Year;
                Convert.ToInt32(age);
            }
            else
            {
                age = DateTime.Now.Year - birth.Year;
                age--;
                Convert.ToInt32(age);
            }

            return age;
        }

        public bool CheckEmail()
        {
            if (validateEmail.IsMatch(email.Text))
            {
                return true;
            }

            else
            {
                return false;
            }


        }
        public bool CheckTel()
        {
            if (validatephone.IsMatch(tel.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckAccount()
        {
            int user = db.check_studentacc(username.Text).Count();
            if (user == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

      
}
