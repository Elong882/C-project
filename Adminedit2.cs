using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp2
{
    public partial class Adminedit2 : Form
    {
        public Adminedit2()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ComputerScience Project.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void BtnAdmnEdit2backhome_Click(object sender, EventArgs e)
        {
            AdminHome AdminHome = new AdminHome();
            this.Hide();
            AdminHome.Show();
        }

        private void Adminedit2_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdmnEdit2submit_Click(object sender, EventArgs e)
        {
            if (TxtAdmEditAcctype.Text == "Management" || TxtAdmEditAcctype.Text == "management")
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "update Management set ManagmentID where ManagementID = '"+TxtAdmEditID.Text+"' and Username ='" + TxtAdmnEditusername.Text + "'and Password ='"+TxtAdmnEditpassword.Text+"' and Forename = '"+TxtAdmnEditforename.Text+"' and Surname = '"+TxtAdmnEditsurname.Text+"' and Mobile number = '"+TxtAdmnEditmobileno.Text+"' and Email = '"+TxtAdmnEditemail.Text+"' and Postcode = '"+TxtAdmnEditpostcode.Text+"')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("User information has been updated in the database");
                con.Close();
            }
            else if (TxtAdmEditAcctype.Text == "Staff" || TxtAdmEditAcctype.Text == "staff")
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "update Staff set StaffID where StaffID = '" + TxtAdmEditID.Text + "' and Username ='" + TxtAdmnEditusername.Text + "'and Password ='" + TxtAdmnEditpassword.Text + "' and Forename = '" + TxtAdmnEditforename.Text + "' and Surname = '" + TxtAdmnEditsurname.Text + "' and Mobile number = '" + TxtAdmnEditmobileno.Text + "' and Email = '" + TxtAdmnEditemail.Text + "' and Postcode = '" + TxtAdmnEditpostcode.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("User information has been updated in the database");
                con.Close();
            }
            else if (TxtAdmEditAcctype.Text == "Admin" || TxtAdmEditAcctype.Text == "admin")
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "update Admin set AdminID where AdminID = '" + TxtAdmEditID.Text + "' and Username ='" + TxtAdmnEditusername.Text + "'and Password ='" + TxtAdmnEditpassword.Text + "' and Forename = '" + TxtAdmnEditforename.Text + "' and Surname = '" + TxtAdmnEditsurname.Text + "' and Mobile number = '" + TxtAdmnEditmobileno.Text + "' and Email = '" + TxtAdmnEditemail.Text + "' and Postcode = '" + TxtAdmnEditpostcode.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("User information has been updated in the database");
                con.Close();
            }
        }
    }
}
