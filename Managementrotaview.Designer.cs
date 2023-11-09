namespace WindowsFormsApp2
{
    partial class Managementrotaview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Managementrotaview));
            this.BtnMngRtaViewback = new System.Windows.Forms.Button();
            this.PctMngRtaViewNHS = new System.Windows.Forms.PictureBox();
            this.CalMngRotaviewcal = new System.Windows.Forms.MonthCalendar();
            this.GrpMngRtaViewcalendar = new System.Windows.Forms.GroupBox();
            this.BtnMngrotaviewaddshift = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PctMngRtaViewNHS)).BeginInit();
            this.GrpMngRtaViewcalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnMngRtaViewback
            // 
            this.BtnMngRtaViewback.Location = new System.Drawing.Point(621, 41);
            this.BtnMngRtaViewback.Name = "BtnMngRtaViewback";
            this.BtnMngRtaViewback.Size = new System.Drawing.Size(143, 51);
            this.BtnMngRtaViewback.TabIndex = 1;
            this.BtnMngRtaViewback.Text = "Back home";
            this.BtnMngRtaViewback.UseVisualStyleBackColor = true;
            this.BtnMngRtaViewback.Click += new System.EventHandler(this.BtnMngRtaViewback_Click);
            // 
            // PctMngRtaViewNHS
            // 
            this.PctMngRtaViewNHS.Image = ((System.Drawing.Image)(resources.GetObject("PctMngRtaViewNHS.Image")));
            this.PctMngRtaViewNHS.Location = new System.Drawing.Point(37, 410);
            this.PctMngRtaViewNHS.Name = "PctMngRtaViewNHS";
            this.PctMngRtaViewNHS.Size = new System.Drawing.Size(196, 72);
            this.PctMngRtaViewNHS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctMngRtaViewNHS.TabIndex = 2;
            this.PctMngRtaViewNHS.TabStop = false;
            // 
            // CalMngRotaviewcal
            // 
            this.CalMngRotaviewcal.Location = new System.Drawing.Point(12, 46);
            this.CalMngRotaviewcal.Name = "CalMngRotaviewcal";
            this.CalMngRotaviewcal.TabIndex = 3;
            this.CalMngRotaviewcal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // GrpMngRtaViewcalendar
            // 
            this.GrpMngRtaViewcalendar.Controls.Add(this.CalMngRotaviewcal);
            this.GrpMngRtaViewcalendar.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GrpMngRtaViewcalendar.ForeColor = System.Drawing.Color.White;
            this.GrpMngRtaViewcalendar.Location = new System.Drawing.Point(226, 71);
            this.GrpMngRtaViewcalendar.Name = "GrpMngRtaViewcalendar";
            this.GrpMngRtaViewcalendar.Size = new System.Drawing.Size(336, 311);
            this.GrpMngRtaViewcalendar.TabIndex = 4;
            this.GrpMngRtaViewcalendar.TabStop = false;
            this.GrpMngRtaViewcalendar.Text = "Management view";
            // 
            // BtnMngrotaviewaddshift
            // 
            this.BtnMngrotaviewaddshift.Location = new System.Drawing.Point(469, 400);
            this.BtnMngrotaviewaddshift.Name = "BtnMngrotaviewaddshift";
            this.BtnMngrotaviewaddshift.Size = new System.Drawing.Size(185, 53);
            this.BtnMngrotaviewaddshift.TabIndex = 5;
            this.BtnMngrotaviewaddshift.Text = "Add shift";
            this.BtnMngrotaviewaddshift.UseVisualStyleBackColor = true;
            this.BtnMngrotaviewaddshift.Click += new System.EventHandler(this.BtnMngrotaviewaddshift_Click);
            // 
            // Managementrotaview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(100)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.BtnMngrotaviewaddshift);
            this.Controls.Add(this.GrpMngRtaViewcalendar);
            this.Controls.Add(this.PctMngRtaViewNHS);
            this.Controls.Add(this.BtnMngRtaViewback);
            this.Name = "Managementrotaview";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Managementrotaview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctMngRtaViewNHS)).EndInit();
            this.GrpMngRtaViewcalendar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnMngRtaViewback;
        private System.Windows.Forms.PictureBox PctMngRtaViewNHS;
        private System.Windows.Forms.MonthCalendar CalMngRotaviewcal;
        private System.Windows.Forms.GroupBox GrpMngRtaViewcalendar;
        private System.Windows.Forms.Button BtnMngrotaviewaddshift;
    }
}