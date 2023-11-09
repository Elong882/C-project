using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class ResetPassword2 : Form
    {
        string username = ResetPassword.to; 
        public ResetPassword2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnResetPass2submit_Click(object sender, EventArgs e)
        {
            
            if (TxtResetPass2newpass.Text == TxtResetPass2confirmpass.Text )
            {
                
            }
            else
            {
                MessageBox.Show("Passwords don't match, enter again");
            }
        }

        private void BtnResetPass2back_Click(object sender, EventArgs e)
        {
            LogInPage loginpage = new LogInPage();
            this.Hide();
            loginpage.Show();
        }
    }
}
