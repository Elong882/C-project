using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void BtnAdmHmecreatnewuser_Click(object sender, EventArgs e)
        {
            Admincreatenewuser Admincreatenewuser = new Admincreatenewuser();
            Admincreatenewuser.Show();
        }

        private void BtnAdmHmeresetpass_Click(object sender, EventArgs e)
        {
            ResetPassword ResetPassword = new ResetPassword();
            ResetPassword.Show();
        }

        private void BtnAdmHmedeleteuser_Click(object sender, EventArgs e)
        {
            Adminddeleteuser Adminddeleteuser = new Adminddeleteuser();
            Adminddeleteuser.Show();
        }

        private void BtnAdmHmeeditinfo_Click(object sender, EventArgs e)
        {
            Adminedit2 Adminedit = new Adminedit2();
            this.Hide();
            Adminedit.Show();
        }

        private void BtnAdmHmelogout_Click(object sender, EventArgs e)
        {
            LogInPage LoginPage = new LogInPage();
            this.Hide();
            LoginPage.Show();

            MessageBox.Show("You have been succesfully logged out");

        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }
    }
}
