using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ManagementHome : Form
    {

        public ManagementHome()
        {
            InitializeComponent();
        }

        private void BtnMngRtaViewresetpass_Click(object sender, EventArgs e)
        {
            ResetPassword ResetPassword = new ResetPassword();
            ResetPassword.Show();
        }

        private void BtnMngHmeLogout_Click(object sender, EventArgs e)
        {
            LogInPage LogInPage = new LogInPage();
            this.Hide();
            LogInPage.Show();
            MessageBox.Show("You have been succesfully logged out");

        }

        private void ManagementHome_Load(object sender, EventArgs e)
        {

        }
    }
}
