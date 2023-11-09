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
    public partial class Adminddeleteuser : Form
    {
        public Adminddeleteuser()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ComputerScience Project.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void BtnAdmDeleteback_Click(object sender, EventArgs e)
        {
            AdminHome AdminHome = new AdminHome();
            this.Hide();
            AdminHome.Show();
        }

        private void Adminddeleteuser_Load(object sender, EventArgs e)
        {
            LogInPage loginpage = new LogInPage();
            loginpage.Hide();
            con.Open();
        }

        private void BtnAdmDeletesubmit_Click(object sender, EventArgs e)
        {
            if (TxtAdmDeleteacctype.Text == "Management" || TxtAdmDeleteacctype.Text == "management")
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from Management where Username = '" + TxtAdmDeleteusername.Text + "' and ManagementID ='"+TxtAdmDeleteID.Text+"')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User has been deleted from database");
                
            }
            else if (TxtAdmDeleteacctype.Text == "Admin" || TxtAdmDeleteacctype.Text == "Admin")
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from Admin where Username = '" + TxtAdmDeleteusername.Text + "' and AdminID ='" + TxtAdmDeleteID.Text + "')";
                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User has been deleted from database");
             
                
            }
            else if (TxtAdmDeleteacctype.Text == "Staff" || TxtAdmDeleteacctype.Text == "staff")
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from Staff where Username = '" + TxtAdmDeleteusername.Text + "' and StaffID ='" + TxtAdmDeleteID.Text + "')";
                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User has been deleted from database");
              
            }

        }
    }
}
