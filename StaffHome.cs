using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp2
{
    public partial class StaffHome : Form
    {
        public StaffHome()
        {
            InitializeComponent();
            ControlBox = false;
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ComputerScience Project.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void BtnStffHmesearch_Click(object sender, EventArgs e)
        {
            string date = CalStffHmecalendar.SelectionRange.Start.ToShortDateString();
            
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            string shift = cmd.CommandText = "SELECT  Username FROM Staff AND Shifts WHERE Staff.Username = Shifts.Username AND SELECT ShiftDate, ShiftTime FROM Shifts";
            cmd.ExecuteNonQuery();
            MessageBox.Show(date + shift);
            con.Close();
            
        }

        private void BtnStaffHmeresetpass_Click(object sender, EventArgs e)
        {
            ResetPassword ResetPassword = new ResetPassword();
            this.Hide();
            ResetPassword.Show();

        }

        private void GrpBxStffHmecalendar_Enter(object sender, EventArgs e)
        {

        }

        private void StaffHome_Load(object sender, EventArgs e)
        {

        }

        private void BtnStffHmeAddShift_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnStffHmeSwapShift_Click(object sender, EventArgs e)
        {
            string date = CalStffHmecalendar.SelectionRange.Start.ToShortDateString();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            MessageBox.Show("Please enter your password again to swap this shift");
            string password = Console.ReadLine();
            string shift = cmd.CommandText = "SELECT  Username,StaffID, ShiftDate, ShiftStartTime, ShiftEndTime,AccountID FROM Staff, Shifts WHERE Staff.StaffID = Shifts.AccountID AND Staff.Username = Shifts.Username";
            string swap = cmd.CommandText = "UPDATE Shifts WHERE Shifts.ShiftDate = '"+date+"' AND Staff.Username = Shifts.Username AND Staff.Password = '"+password+"')";
            cmd.ExecuteNonQuery();
            con.Close();

            this.Hide();
            StaffSwapShift SwapShift = new StaffSwapShift();
            SwapShift.Show();
        }
    }
}
