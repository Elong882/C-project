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
    public partial class Managementrotaview : Form
    {
        public Managementrotaview()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ComputerScience Project.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void Managementrotaview_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void BtnMngRtaViewback_Click(object sender, EventArgs e)
        {
            ManagementHome ManagementHome = new ManagementHome();
            this.Hide();
            ManagementHome.Show(); /////needs work
        }

        private void BtnMngrotaviewaddshift_Click(object sender, EventArgs e)
        {
            string date = CalMngRotaviewcal.SelectionRange.Start.ToShortDateString();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Shifts where Shifts.AccountID = Admin.AdminID ([ShiftDate],[ShiftTime]) values ("; ///this also needs a lot of work
            cmd.ExecuteNonQuery();
            con.Close();
            AdminHome AdminHome = new AdminHome();
            this.Hide();
            AdminHome.Show();

            

        }
    }
}
