namespace WindowsFormsApp2
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.LblAdmHmecreateuser = new System.Windows.Forms.Label();
            this.BtnAdmHmecreatnewuser = new System.Windows.Forms.Button();
            this.BtnAdmHmedeleteuser = new System.Windows.Forms.Button();
            this.BtnAdmHmeeditinfo = new System.Windows.Forms.Button();
            this.PctAdmHmeNHS = new System.Windows.Forms.PictureBox();
            this.BtnAdmHmelogout = new System.Windows.Forms.Button();
            this.BtnAdmHmeresetpass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PctAdmHmeNHS)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAdmHmecreateuser
            // 
            this.LblAdmHmecreateuser.AutoSize = true;
            this.LblAdmHmecreateuser.Location = new System.Drawing.Point(201, 83);
            this.LblAdmHmecreateuser.Name = "LblAdmHmecreateuser";
            this.LblAdmHmecreateuser.Size = new System.Drawing.Size(0, 25);
            this.LblAdmHmecreateuser.TabIndex = 0;
            // 
            // BtnAdmHmecreatnewuser
            // 
            this.BtnAdmHmecreatnewuser.Location = new System.Drawing.Point(209, 83);
            this.BtnAdmHmecreatnewuser.Name = "BtnAdmHmecreatnewuser";
            this.BtnAdmHmecreatnewuser.Size = new System.Drawing.Size(287, 58);
            this.BtnAdmHmecreatnewuser.TabIndex = 1;
            this.BtnAdmHmecreatnewuser.Text = "Create new user";
            this.BtnAdmHmecreatnewuser.UseVisualStyleBackColor = true;
            this.BtnAdmHmecreatnewuser.Click += new System.EventHandler(this.BtnAdmHmecreatnewuser_Click);
            // 
            // BtnAdmHmedeleteuser
            // 
            this.BtnAdmHmedeleteuser.Location = new System.Drawing.Point(209, 167);
            this.BtnAdmHmedeleteuser.Name = "BtnAdmHmedeleteuser";
            this.BtnAdmHmedeleteuser.Size = new System.Drawing.Size(286, 60);
            this.BtnAdmHmedeleteuser.TabIndex = 2;
            this.BtnAdmHmedeleteuser.Text = "Delete existing user";
            this.BtnAdmHmedeleteuser.UseVisualStyleBackColor = true;
            this.BtnAdmHmedeleteuser.Click += new System.EventHandler(this.BtnAdmHmedeleteuser_Click);
            // 
            // BtnAdmHmeeditinfo
            // 
            this.BtnAdmHmeeditinfo.Location = new System.Drawing.Point(209, 248);
            this.BtnAdmHmeeditinfo.Name = "BtnAdmHmeeditinfo";
            this.BtnAdmHmeeditinfo.Size = new System.Drawing.Size(287, 60);
            this.BtnAdmHmeeditinfo.TabIndex = 3;
            this.BtnAdmHmeeditinfo.Text = "Edit employee information";
            this.BtnAdmHmeeditinfo.UseVisualStyleBackColor = true;
            this.BtnAdmHmeeditinfo.Click += new System.EventHandler(this.BtnAdmHmeeditinfo_Click);
            // 
            // PctAdmHmeNHS
            // 
            this.PctAdmHmeNHS.Image = ((System.Drawing.Image)(resources.GetObject("PctAdmHmeNmeeditinfo.Text = "Edit employee information";
            this.BtnAdmHmeeditinfo.UseVisualStyleBackColor = true;
            this.BtnAdmHmeeditinfo.Click += new System.EventHandler(this.BtnAdmHmeeditinfo_Click);
            // 
            // PctAdmHmeNHS
            // 
            this.PctAdmHmeNHS.Image = ((System.Drawing.Image)(resources.GetObject("PctAdmHmeNHS.Image")));
            this.PctAdmHmeNHS.Location = new System.Drawing.Point(38, 210);
            this.PctAdmHmeNHS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PctAdmHmeNHS.Name = "PctAdmHmeNHS";
            this.PctAdmHmeNHS.Size = new System.Drawing.Size(115, 40);
            this.PctAdmHmeNHS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctAdmHmeNHS.TabIndex = 4;
            this.PctAdmHmeNHS.TabStop = false;
            // 
            // BtnAdmHmelogout
            // 
            this.BtnAdmHmelogout.Location = new System.Drawing.Point(452, 29);
            this.BtnAdmHmelogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAdmHmelogout.Name = "BtnAdmHmelogout";
            this.BtnAdmHmelogout.Size = new System.Drawing.Size(89, 21);
            this.BtnAdmHmelogout.TabIndex = 5;
            this.BtnAdmHmelogout.Text = "Log out";
            this.BtnAdmHmelogout.UseVisualStyleBackColor = true;
            this.BtnAdmHmelogout.Click += new System.EventHandler(this.BtnAdmHmelogout_Click);
            // 
            // BtnAdmHmeresetpass
            // 
            this.BtnAdmHmeresetpass.Location = new System.Drawing.Point(452, 67);
            this.BtnAdmHmeresetpass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAdmHmeresetpass.Name = "BtnAdmHmeresetpass";
            this.BtnAdmHmeresetpass.Size = new System.Drawing.Size(89, 44);
            this.BtnAdmHmeresetpass.TabIndex = 6;
            this.BtnAdmHmeresetpass.Text = "Reset password";
            this.BtnAdmHmeresetpass.UseVisualStyleBackColor = true;
            this.BtnAdmHmeresetpass.Click += new System.EventHandler(this.BtnAdmHmeresetpass_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(100)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.BtnAdmHmeresetpass);
            this.Controls.Add(this.BtnAdmHmelogout);
            this.Controls.Add(this.PctAdmHmeNHS);
            this.Controls.Add(this.BtnAdmHmeeditinfo);
            this.Controls.Add(this.BtnAdmHmedeleteuser);
            this.Controls.Add(this.BtnAdmHmecreatnewuser);
            this.Controls.Add(this.LblAdmHmecreateuser);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminHome";
            this.Text = "Form1";
            ((System.Com