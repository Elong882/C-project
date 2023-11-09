namespace WindowsFormsApp2
{
    partial class ResetPassword2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword2));
            this.PctBxResetPass2 = new System.Windows.Forms.PictureBox();
            this.LblResetPass2newpass = new System.Windows.Forms.Label();
            this.TxtResetPass2newpass = new System.Windows.Forms.TextBox();
            this.LblResetPass2confirmpass = new System.Windows.Forms.Label();
            this.TxtResetPass2confirmpass = new System.Windows.Forms.TextBox();
            this.BtnResetPass2submit = new System.Windows.Forms.Button();
            this.BtnResetPass2back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxResetPass2)).BeginInit();
            this.SuspendLayout();
            // 
            // PctBxResetPass2
            // 
            this.PctBxResetPass2.Image = ((System.Drawing.Image)(resources.GetObject("PctBxResetPass2.Image")));
            this.PctBxResetPass2.Location = new System.Drawing.Point(36, 344);
            this.PctBxResetPass2.Name = "PctBxResetPass2";
            this.PctBxResetPass2.Size = new System.Drawing.Size(150, 62);
            this.PctBxResetPass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBxResetPass2.TabIndex = 0;
            this.PctBxResetPass2.TabStop = false;
            // 
            // LblResetPass2newpass
            // 
            this.LblResetPass2newpass.AutoSize = true;
            this.LblResetPass2newpass.BackColor = System.Drawing.Color.Transparent;
            this.LblResetPass2newpass.ForeColor = System.Drawing.Color.White;
            this.LblResetPass2newpass.Location = new System.Drawing.Point(271, 75);
            this.LblResetPass2newpass.Name = "LblResetPass2newpass";
            this.LblResetPass2newpass.Size = new System.Drawing.Size(133, 25);
            this.LblResetPass2newpass.TabIndex = 1;
            this.LblResetPass2newpass.Text = "New password:";
            // 
            // TxtResetPass2newpass
            // 
            this.TxtResetPass2newpass.Location = new System.Drawing.Point(271, 112);
            this.TxtResetPass2newpass.Name = "TxtResetPass2newpass";
            this.TxtResetPass2newpass.Size = new System.Drawing.Size(227, 31);
            this.TxtResetPass2newpass.TabIndex = 2;
            // 
            // LblResetPass2confirmpass
            // 
            this.LblResetPass2confirmpass.AutoSize = true;
            this.LblResetPass2confirmpass.ForeColor = System.Drawing.Color.White;
            this.LblResetPass2confirmpass.Location = new System.Drawing.Point(271, 162);
            this.LblResetPass2confirmpass.Name = "LblResetPass2confirmpass";
            this.LblResetPass2confirmpass.Size = new System.Drawing.Size(199, 25);
            this.LblResetPass2confirmpass.TabIndex = 3;
            this.LblResetPass2confirmpass.Text = "Confirm new password:";
            // 
            // TxtResetPass2confirmpass
            // 
            this.TxtResetPass2confirmpass.Location = new System.Drawing.Point(271, 200);
            this.TxtResetPass2confirmpass.Name = "TxtResetPass2confirmpass";
            this.TxtResetPass2confirmpass.Size = new System.Drawing.Size(227, 31);
            this.TxtResetPass2confirmpass.TabIndex = 4;
            // 
            // BtnResetPass2submit
            // 
            this.BtnResetPass2submit.ForeColor = System.Drawing.Color.Black;
            this.BtnResetPass2submit.Location = new System.Drawing.Point(443, 268);
            this.BtnResetPass2submit.Name = "BtnResetPass2submit";
            this.BtnResetPass2submit.Size = new System.Drawing.Size(148, 67);
            this.BtnResetPass2submit.TabIndex = 5;
            this.BtnResetPass2submit.Text = "Submit new password";
            this.BtnResetPass2submit.UseVisualStyleBackColor = true;
            this.BtnResetPass2submit.Click += new System.EventHandler(this.BtnResetPass2submit_Click);
            // 
            // BtnResetPass2back
            // 
            this.BtnResetPass2back.Location = new System.Drawing.Point(616, 26);
            this.BtnResetPass2back.Name = "BtnResetPass2back";
            this.BtnResetPass2back.Size = new System.Drawing.Size(142, 53);
            this.BtnResetPass2back.TabIndex = 6;
            this.BtnResetPass2back.Text = "Back";
            this.BtnResetPass2back.UseVisualStyleBackColor = true;
            this.BtnResetPass2back.Click += new System.EventHandler(this.BtnResetPass2back_Click);
            // 
            // ResetPassword2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(100)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnResetPass2back);
            this.Controls.Add(this.BtnResetPass2submit);
            this.Controls.Add(this.TxtResetPass2confirmpass);
            this.Controls.Add(this.LblResetPass2confirmpass);
            this.Controls.Add(this.TxtResetPass2newpass);
            this.Controls.Add(this.LblResetPass2newpass);
            this.Controls.Add(this.PctBxResetPass2);
            this.Name = "ResetPassword2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBxResetPass2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctBxResetPass2;
        private System.Windows.Forms.Label LblResetPass2newpass;
        private System.Windows.Forms.TextBox TxtResetPass2newpass;
        private System.Windows.Forms.Label LblResetPass2confirmpass;
        private System.Windows.Forms.TextBox TxtResetPass2confirmpass;
        private System.Windows.Forms.Button BtnResetPass2submit;
        private System.Windows.Forms.Button BtnResetPass2back;
    }
}