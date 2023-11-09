using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp2
{
    
    public partial class LogInPage : Form
    {
        
        public LogInPage()
        {
            InitializeComponent();
            
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\WindowsFormsApp2\\Database36.accdb;Persist Security Info=True");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void BtnLgnPgforgotpass_Click(object sender, EventArgs e)
        {
         
            ResetPassword ResetPassword = new ResetPassword();
            this.Hide();
            ResetPassword.Show();
            
          
        }

        private void BtnLgnPgsubmit_Click(object sender, EventArgs e)
        {
            if (TxtLgnPgusername.Text == "" && TxtLgnPgpassword.Text == "")
            {
                MessageBox.Show("Username and password boxes are empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtLgnPgpassword.Text == TxtLgnPgconfirmpass.Text && TxtLgnPg1acctype.Text == "admin" || TxtLgnPg1acctype.Text == "Admin")
            {
                
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT Username FROM Admin WHERE Username = ? AND Password = ?";
                cmd.Parameters.AddWithValue("@user", LblLgnPgusername.Text);
                cmd.Parameters.AddWithValue("@pass", LblLgnPgpassword.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                AdminHome AdminHome = new AdminHome();
                this.Hide();
                AdminHome.Show();

            }
            else if (TxtLgnPgpassword.Text == TxtLgnPgconfirmpass.Text && TxtLgnPg1acctype.Text == "management" || TxtLgnPg1acctype.Text == "Management")
            {
                con.Open();
                string login = "SELECT * FROM Management WHERE Username '" + TxtLgnPgusername.Text + "')";
                login = "SELECT * FROM Management WHERE Password = '" + TxtLgnPgpassword.Text + "')";
                cmd = new OleDbCommand(login, con);
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {

                    ManagementHome ManagementHome = new ManagementHome();
                    this.Hide();
                    ManagementHome.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtLgnPgusername.Text = "";
                    TxtLgnPgpassword.Text = "";
                    TxtLgnPgusername.Focus();
                }

            }
            else if (TxtLgnPgpassword.Text == TxtLgnPgconfirmpass.Text && TxtLgnPg1acctype.Text == "staff" || TxtLgnPg1acctype.Text =="Staff")
            {

                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT Username FROM Staff WHERE Username = ? AND Password = ?";
                cmd.Parameters.AddWithValue("@user", LblLgnPgusername.Text);
                cmd.Parameters.AddWithValue("@pass", LblLgnPgpassword.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                StaffHome staffHome = new StaffHome();
                this.Hide();
                staffHome.Show();

            }
            else
            {
                MessageBox.Show("Passwords don't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtLgnPg{
  "version": 3,
  "targets": {
    ".NETCoreApp,Version=v3.1": {
      "Microsoft.Win32.Registry/5.0.0": {
        "type": "package",
        "dependencies": {
          "System.Security.AccessControl": "5.0.0",
          "System.Security.Principal.Windows": "5.0.0"
        },
        "compile": {
          "ref/netstandard2.0/Microsoft.Win32.Registry.dll": {}
        },
        "runtime": {
          "lib/netstandard2.0/Microsoft.Win32.Registry.dll": {}
        },
        "runtimeTargets": {
          "runtimes/win/lib/netstandard2.0/Microsoft.Win32.Registry.dll": {
            "assetType": "runtime",
            "rid": "win"
          }
        }
      },
      "Microsoft.Win32.SystemEvents/6.0.0": {
        "type": "package",
        "compile": {
          "lib/netcoreapp3.1/Microsoft.Win32.SystemEvents.dll": {}
        },
        "runtime": {
          "lib/netcoreapp3.1/Microsoft.Win32.SystemEvents.dll": {}
        },
        "build": {
          "buildTransitive/netcoreapp3.1/_._": {}
        },
        "runtimeTargets": {
          "run