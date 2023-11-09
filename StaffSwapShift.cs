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
    public partial class StaffSwapShift : Form
    {

        public StaffSwapShift()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ComputerScience Project.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void BtnStffSwapShiftsYes_Click(object sender, EventArgs e)
        {

           
        }

        private void BtnStffSwapShiftsno_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have chosen not to swap your shift and your current shift will remain the same");
            this.Hide();
        }

        private void StaffSwapShift_Load(object sender, EventArgs e)
        {

        }
    }
}
