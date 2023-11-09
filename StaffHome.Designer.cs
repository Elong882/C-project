namespace WindowsFormsApp2
{
    partial class StaffHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffHome));
            this.BtnStaffHmeresetpass = new System.Windows.Forms.Button();
            this.PctStaffHmeNHS = new System.Windows.Forms.PictureBox();
            this.CalStffHmecalendar = new System.Windows.Forms.MonthCalendar();
            this.BtnStffHmesearch = new System.Windows.Forms.Button();
            this.GrpBxStffHmecalendar = new System.Windows.Forms.GroupBox();
            this.BtnStffHmeAddShift = new System.Windows.Forms.Button();
            this.BtnStffHmeSwapShift = new System.Windows.Forms.Button();
            this.BtnStffHmeLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PctStaffHmeNHS)).BeginInit();
            this.GrpBxStffHmecalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStaffHmeresetpass
            // 
            this.BtnStaffHmeresetpass.Location = new System.Drawing.Point(619, 88);
            this.BtnStaffHmeresetpass.Name = "BtnStaffHmeresetpass";
            this.BtnStaffHmeresetpass.Size = new System.Drawing.Size(146, 57);
            this.BtnStaffHmeresetpass.TabIndex = 1;
            this.BtnStaffHmeresetpass.Text = "Reset password";
            this.BtnStaffHmeresetpass.UseVisualStyleBackColor = true;
            this.BtnStaffHmeresetpass.Click += new System.EventHandler(this.BtnStaffHmeresetpass_Click);
            // 
            // PctStaffHmeNHS
            // 
            this.PctStaffHmeNHS.Image = ((System.Drawing.Image)(resources.GetObject("PctStaffHmeNHS.Image")));
            this.PctStaffHmeNHS.Location = new System.Drawing.Point(39, 530);
            this.PctStaffHmeNHS.Name = "PctStaffHmeNHS";
            this.PctStaffHmeNHS.Size = new System.Drawing.Size(164, 68);
            this.PctStaffHmeNHS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctStaffHmeNHS.TabIndex = 3;
            this.PctStaffHmeNHS.TabStop = false;
            // 
            // CalStffHmecalendar
            // 
            this.CalStffHmecalendar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CalStffHmecalendar.ForeColor = System.Drawing.Color.White;
            this.CalStffHmecalendar.Location = new System.Drawing.Point(11, 45);
            this.CalStffHmecalendar.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.CalStffHmecalendar.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.CalStffHmecalendar.Name = "CalStffHmecalendar";
            this.CalStffHmecalendar.TabIndex = 4;
            this.CalStffHmecalendar.TrailingForeColor = System.Drawing.Color.Transparent;
            this.CalStffHmecalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // BtnStffHmesearch
            // 
            this.BtnStffHmesearch.Location = new System.Drawing.Point(251, 415);
            this.BtnStffHmesearch.Name = "BtnStffHmesearch";
            this.BtnStffHmesearch.Size = new System.Drawing.Size(151, 58);
            this.BtnStffHmesearch.TabIndex = 5;
            this.BtnStffHmesearch.Text = "Search this date";
            this.BtnStffHmesearch.UseVisualStyleBackColor = true;
            this.BtnStffHmesearch.Click += new System.EventHandler(this.BtnStffHmesearch_Click);
            // 
            // GrpBxStffHmecalendar
            // 
            this.GrpBxStffHmecalendar.Controls.Add(this.CalStffHmecalendar);
            this.GrpBxStffHmecalendar.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GrpBxStffHmecalendar.ForeColor = System.Drawing.Color.White;
            this.GrpBxStffHmecalendar.Location = new System.Drawing.Point(139, 88);
            this.GrpBxStffHmecalendar.Name = "GrpBxStffHmecalendar";
            this.GrpBxStffHmecalendar.Size = new System.Drawing.Size(336, 307);
            this.GrpBxStffHmecalendar.TabIndex = 7;
            this.GrpBxStffHmecalendar.TabStop = false;
            this.GrpBxStffHmecalendar.Text = "Your monthly rota";
            this.GrpBxStffHmecalendar.Enter += new System.EventHandler(this.GrpBxStffHmecalendar_Enter);
            // 
            // BtnStffHmeAddShift
            // 
            this.BtnStffHmeAddShift.Location = new System.Drawing.Point(410, 415);
            this.BtnStffHmeAddShift.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnStffHmeAddShift.Name = "BtnStffHmeAddShift";
            this.BtnStffHmeAddShift.Size = new System.Drawing.Size(147, 58);
            this.BtnStffHmeAddShift.TabIndex = 8;
            this.BtnStffHmeAddShift.Text = "Add shift ";
            this.BtnStffHmeAddShift.UseVisualStyleBackColor = true;
            this.BtnStffHmeAddShift.Click += new System.EventHandler(this.BtnStffHmeAddShift_Click);
            // 
            // BtnStffHmeSwapShift
            // 
            this.BtnStffHmeSwapShift.Location = new System.Drawing.Point(566, 415);
            this.BtnStffHmeSwapShift.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnStffHmeSwapShift.Name = "BtnStffHmeSwapShift";
            this.BtnStffHmeSwapShift.Size = new System.Drawing.Size(151, 58);
            this.BtnStffHmeSwapShift.TabIndex = 9;
            this.BtnStffHmeSwapShift.Text = "Swap this shift";
            this.BtnStffHmeSwapShift.UseVisualStyleBackColor = true;
            this.BtnStffHmeSwapShift.Click += new System.EventHandler(this.BtnStffHmeSwapShift_Click);
            // 
            // BtnStffHmeLogout
            // 
            this.BtnStffHmeLogout.Location = new System.Drawing.Point(619, 24);
            this.BtnStffHmeLogout.Name = "BtnStffHmeLogout";
            this.BtnStffHmeLogout.Size = new System.Drawing.Size(146, 47);
            this.BtnStffHmeLogout.TabIndex = 10;
            this.BtnStffHmeLogout.Text = "Log out";
            this.BtnStffHmeLogout.UseVisualStyleBackColor = true;
            // 
            // StaffHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(100)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.BtnStffHmeLogout);
            this.Controls.Add(this.BtnStffHmeSwapShift);
            this.Controls.Add(this.BtnStffHmeAddShift);
            this.Controls.Add(this.GrpBxStffHmecalendar);
            this.Controls.Add(this.BtnStffHmesearch);
            this.Controls.Add(this.PctStaffHmeNHS);
            this.Controls.Add(this.BtnStaffHmeresetpass);
            this.Name = "StaffHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StaffHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctStaffHmeNHS)).EndInit();
            this.GrpBxStffHmecalendar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStaffHmeresetpass;
        private System.Windows.Forms.PictureBox PctStaffHmeNHS;
        private System.Windows.Forms.MonthCalendar CalStffHmecalendar;
        private System.Windows.Forms.Button BtnStffHmesearch;
        private System.Windows.Forms.GroupBox GrpBxStffHmecalendar;
        private System.Windows.Forms.Button BtnStffHmeAddShift;
        private System.Windows.Forms.Button BtnStffHmeSwapShift;
        private System.Windows.Forms.Button BtnStffHmeLogout;
    }
}