
namespace WindowsFormsApp2
{
    partial class StaffSwapShift
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
            this.LblStffSwapShiftdoyou = new System.Windows.Forms.Label();
            this.BtnStffSwapShiftsYes = new System.Windows.Forms.Button();
            this.BtnStffSwapShiftsno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblStffSwapShiftdoyou
            // 
            this.LblStffSwapShiftdoyou.AutoSize = true;
            this.LblStffSwapShiftdoyou.ForeColor = System.Drawing.Color.White;
            this.LblStffSwapShiftdoyou.Location = new System.Drawing.Point(182, 106);
            this.LblStffSwapShiftdoyou.Name = "LblStffSwapShiftdoyou";
            this.LblStffSwapShiftdoyou.Size = new System.Drawing.Size(256, 15);
            this.LblStffSwapShiftdoyou.TabIndex = 0;
            this.LblStffSwapShiftdoyou.Text = "Do you want to swap the shift with this person?";
            // 
            // BtnStffSwapShiftsYes
            // 
            this.BtnStffSwapShiftsYes.Location = new System.Drawing.Point(182, 138);
            this.BtnStffSwapShiftsYes.Name = "BtnStffSwapShiftsYes";
            this.BtnStffSwapShiftsYes.Size = new System.Drawing.Size(108, 41);
            this.BtnStffSwapShiftsYes.TabIndex = 1;
            this.BtnStffSwapShiftsYes.Text = "Yes";
            this.BtnStffSwapShiftsYes.UseVisualStyleBackColor = true;
            this.BtnStffSwapShiftsYes.Click += new System.EventHandler(this.BtnStffSwapShiftsYes_Click);
            // 
            // BtnStffSwapShiftsno
            // 
            this.BtnStffSwapShiftsno.Location = new System.Drawing.Point(314, 138);
            this.BtnStffSwapShiftsno.Name = "BtnStffSwapShiftsno";
            this.BtnStffSwapShiftsno.Size = new System.Drawing.Size(105, 43);
            this.BtnStffSwapShiftsno.TabIndex = 2;
            this.BtnStffSwapShiftsno.Text = "No";
            this.BtnStffSwapShiftsno.UseVisualStyleBackColor = true;
            this.BtnStffSwapShiftsno.Click += new System.EventHandler(this.BtnStffSwapShiftsno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "delete and add logo";
            // 
            // StaffSwapShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(100)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(599, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnStffSwapShiftsno);
            this.Controls.Add(this.BtnStffSwapShiftsYes);
            this.Controls.Add(this.LblStffSwapShiftdoyou);
            this.Name = "Staf﻿<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="Current" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <ItemGroup>
    <Compile Update="AdminHome.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Update="Admincreatenewuser.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Update="Adminddeleteuser.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Update="Adminedit2.cs">
      <SubType>Form</SubType>
    </C