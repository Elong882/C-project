using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp2
{
   
    public partial class ResetPassword : Form
    {
        string RandomCode;
        public static string to;

        public ResetPassword()
        {
            InitializeComponent();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void BtnResetPasssubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnResetPasssendcode_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            RandomCode = (rand.Next(999999999)).ToString();
            MailMessage msg = new MailMessage();
            to = (TxtResetPasssendcode.Text).ToString();
            string from = "cotest186@gmail";
            string password = "cOmpsci87?24*";
            string messagesubject = "Your code is" + RandomCode;
            msg.To.Add(to);
            msg.From = new MailAddress(from);
            msg.Body = messagesubject;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, password);
            try
            {
                smtp.Send(msg);
                MessageBox.Show("Code has been sent to your email");
            }
             catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }

        private void BtnResetPassverifycode_Click(object sender, EventArgs e)
        {
            if (RandomCode == (TxtResetPassverifycode.Text).ToString())
            {
                to = TxtResetPasssendcode.Text;
                ResetPassword resetpass = new ResetPassword();
                this.Hide();
                resetpass.Show();
            }
            else
            {
                MessageBox.Show("Invalid code entered");
            }

        }

        private void BtnResetPassback_Click(object sender, EventArgs e)
        {
            LogInPage loginpage = new LogInPage();
            this.Hide();
            loginpage.Show();
        }
    }
}
