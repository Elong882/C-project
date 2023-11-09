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
    public partial class Admincreatenewuser : Form
    {
        public Admincreatenewuser()
        {
            InitializeComponent();
            
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\WindowsFormsApp2\\Database36.laccdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void TxtAdmCreateusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admincreatenewuser_Load(object sender, EventArgs e)
        {
            
        }
        private void BtnAdmCreateback_Click(object sender, EventArgs e)
        {
            AdminHome AdminHome = new AdminHome();
            this.Hide();
            AdminHome.Show();
        }

        private void TxtAdmCreateusername_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TxtAdmCreateAccType_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdmCreatesubmit_Click(object sender, EventArgs e)
        {
            if (TxtAdmCreateAccType.Text == "Admin" || TxtAdmCreateAccType.Text == "admin")
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO Admin ([ManagementID],[Username],[Password],[Forename],[Surname],[Email],[Mobile number],[Postcode]) values ('" + TxtAdmCreateID.Text + "','" + TxtAdmCreateusername.Text + "','" + TxtAdmCreatepassword.Text + "','" + TxtAdmCreateforename.Text + "','" + TxtAdmCreatesurname.Text + "','" + TxtAdmCreateemail.Text + "','" + TxtAdmCreatemobile.Text + "','" + TxtAdmCreatepostcode.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New user has been created");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error trying to create this user" + ex);
                }
            }
            if (TxtAdmCreateAccType.Text == "Staff" || TxtAdmCreateAccType.Text == "staff")
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO Staff ([Username], [Password],[Forename],[Surname],[Email],[Mobile number],[Postcode]) values('" + TxtAdmCreateusername.Text + "','" + TxtAdmCreatepassword.Text + "','" + TxtAdmCreateforename.Text + "','" + TxtAdmCreatesurname.Text + "','" + TxtAdmCreateemail.Text + "','" + TxtAdmCreatemobile.Text + "','" + TxtAdmCreatepostcode.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New user has been created");
                    con.Close();
                    con.Dispose();
                }

                catch (Exception)
                {
                    MessageBox.Show("There was an error trying to create this user");
                }
            }
            if (TxtAdmCreateAccType.Text == "Management" || TxtAdmCreateAccType.Text == "management")
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO Management ([ManagementID],[Username],[Password],[Forename],[Surname],[Email],[Mobile number],[Postcode]) values ('" + TxtAdmCreateID.Text + "','" + TxtAdmCreateusername.Text + "','" + TxtAdmCreatepassword.Text + "','" + TxtAdmCreateforename.Te{
  "runtimeTarget": {
    "name": ".NETCoreApp,Version=v3.1",
    "signature": ""
  },
  "compilationOptions": {},
  "targets": {
    ".NETCoreApp,Version=v3.1": {
      "Microsoft.Win32.Registry/5.0.0": {
        "dependencies": {
          "System.Security.AccessControl": "6.0.0",
          "System.Security.Principal.Windows": "5.0.0"
        },
        "runtime": {
          "lib/netstandard2.0/Microsoft.Win32.Registry.dll": {
            "assemblyVersion": "5.0.0.0",
            "fileVersion": "5.0.20.51904"
          }
        },
        "runtimeTargets": {
          "runtimes/win/lib/netstan