namespace WindowsFormsApp2
{
    partial class Popup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popup));
            this.LblPopupdoyouwishtoswap = new System.Windows.Forms.Label();
            this.BtnPopupyes = new System.Windows.Forms.Button();
            this.BtnPopupno = new System.Windows.Forms.Button();
            this.PctPopupNHS = new System.Windows.Forms.PictureBox();
            this.BtnPopupback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PctPopupNHS)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPopupdoyouwishtoswap
            // 
            this.LblPopupdoyouwishtoswap.AutoSize = true;
            this.LblPopupdoyouwishtoswap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(100)))), ((int)(((byte)(196)))));
            this.LblPopupdoyouwishtoswap.ForeColor = System.Drawing.Color.White;
            this.LblPopupdoyouwishtoswap.Location = new System.Drawing.Point(227, 160);
            this.LblPopupdoyouwishtoswap.Name = "LblPopupdoyouwishtoswap";
            this.LblPopupdoyouwishtoswap.Size = new System.Drawing.Size(318, 25);
            this.LblPopupdoyouwishtoswap.TabIndex = 0;
            this.LblPopupdoyouwishtoswap.Text = "Do you wish to swap with this person?";
            // 
            // BtnPopupyes
            // 
            this.BtnPopupyes.Location = new System.Drawing.Point(233, 209);
            this.BtnPopupyes.Name = "BtnPopupyes";
            this.BtnPopupyes.Size = new System.Drawing.Size(135, 51);
            this.BtnPopupyes.TabIndex = 1;
            this.BtnPopupyes.Text = "Yes";
            this.BtnPopupyes.UseVisualStyleBackColor = true;
            // 
            // BtnPopupno
            // 
            this.BtnPopupno.Location = new System.Drawing.Point(394, 209);
            this.BtnPopupno.Name = "BtnPopupno";
            this.BtnPopupno.Size = new System.Drawing.Size(115, 51);
            this.BtnPopupno.TabIndex = 2;
            this.BtnPopupno.Text = "No";
            this.BtnPopupno.UseVisualStyleBackColor = true;
            // 
            // PctPopupNHS
            // 
            this.PctPopupNHS.Image = ((System.Drawing.Image)(resources.GetObject("PctPopupNHS.Image")));
            this.PctPopupNHS.Location = new System.Drawing.Point(53, 343);
            this.PctPopupNHS.Name = "PctPopupNHS";
            this.PctPopupNHS.Size = new System.Drawing.Size(151, 64);
            this.PctPopupNHS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctPopupNHS.TabIndex = 3;
            this.PctPopupNHS.TabStop = false;
            // 
            // BtnPopupback
            // 
            this.BtnPopupback.Location = new System.Drawing.Point(617, 37);
            this.BtnPopupback.Name = "BtnPopupback";
            this.BtnPopupback.Size = new System.Drawing.Size(138, 55);
            this.BtnPopupback.TabIndex = 4;
            this.BtnPopupback.Text = "Back ";
            this.BtnPopupback.UseVisualStyleBackColor = true;
            this.BtnPopupback.Click += new System.EventHandler(this.BtnPopupback_Click);
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(100)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPopupback);
            this.Controls.Add(this.PctPopupNHS);
            this.Controls.Add(this.BtnPopupno);
            this.Controls.Add(this.BtnPopupyes);
            this.Controls.Add(this.LblPopupdoyouwishtoswap);
            this.Name = "Popup";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Popup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctPopupNHS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPopupdoyouwishtoswap;
        private System.Windows.Forms.Button BtnPopupyes;
        private System.Windows.Forms.Button BtnPopupno;
        private System.Windows.Forms.PictureBox PctPopupNHS;
        private System.Windows.Forms.Button BtnPopupback;
    }
}