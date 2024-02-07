// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GroupBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpUnterkunft = new System.Windows.Forms.GroupBox();
            OptFerienwohnung = new RadioButton();
            OptBedBreakfast = new RadioButton();
            OptHotel = new RadioButton();
            grpBox1 = new System.Windows.Forms.GroupBox();
            OptParis = new RadioButton();
            OptBerlin = new RadioButton();
            OptRom = new RadioButton();
            Lbl1 = new Label();
            grpUnterkunft.SuspendLayout();
            grpBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grpUnterkunft
            // 
            grpUnterkunft.Controls.Add(OptFerienwohnung);
            grpUnterkunft.Controls.Add(OptBedBreakfast);
            grpUnterkunft.Controls.Add(OptHotel);
            grpUnterkunft.Location = new Point(543, 178);
            grpUnterkunft.Name = "grpUnterkunft";
            grpUnterkunft.Size = new Size(213, 218);
            grpUnterkunft.TabIndex = 0;
            grpUnterkunft.TabStop = false;
            grpUnterkunft.Text = "Unterkunft";
            // 
            // OptFerienwohnung
            // 
            OptFerienwohnung.AutoSize = true;
            OptFerienwohnung.Location = new Point(64, 84);
            OptFerienwohnung.Name = "OptFerienwohnung";
            OptFerienwohnung.Size = new Size(108, 19);
            OptFerienwohnung.TabIndex = 4;
            OptFerienwohnung.Text = "Ferienwohnung";
            OptFerienwohnung.UseVisualStyleBackColor = true;
            OptFerienwohnung.CheckedChanged += OptFerienwohnung_CheckedChanged;
            // 
            // OptBedBreakfast
            // 
            OptBedBreakfast.AutoSize = true;
            OptBedBreakfast.Location = new Point(64, 47);
            OptBedBreakfast.Name = "OptBedBreakfast";
            OptBedBreakfast.Size = new Size(119, 19);
            OptBedBreakfast.TabIndex = 2;
            OptBedBreakfast.Text = "Bed and Breakfast";
            OptBedBreakfast.UseVisualStyleBackColor = true;
            OptBedBreakfast.CheckedChanged += OptBedBreakfast_CheckedChanged;
            // 
            // OptHotel
            // 
            OptHotel.AutoSize = true;
            OptHotel.Location = new Point(64, 122);
            OptHotel.Name = "OptHotel";
            OptHotel.Size = new Size(54, 19);
            OptHotel.TabIndex = 3;
            OptHotel.Text = "Hotel";
            OptHotel.UseVisualStyleBackColor = true;
            OptHotel.CheckedChanged += OptHotel_CheckedChanged;
            // 
            // grpBox1
            // 
            grpBox1.Controls.Add(OptParis);
            grpBox1.Controls.Add(OptBerlin);
            grpBox1.Controls.Add(OptRom);
            grpBox1.Location = new Point(39, 178);
            grpBox1.Name = "grpBox1";
            grpBox1.Size = new Size(213, 218);
            grpBox1.TabIndex = 1;
            grpBox1.TabStop = false;
            grpBox1.Text = "Urlaubsort";
            // 
            // OptParis
            // 
            OptParis.AutoSize = true;
            OptParis.Location = new Point(15, 84);
            OptParis.Name = "OptParis";
            OptParis.Size = new Size(50, 19);
            OptParis.TabIndex = 7;
            OptParis.Text = "Paris";
            OptParis.UseVisualStyleBackColor = true;
            OptParis.CheckedChanged += OptParis_CheckedChanged;
            // 
            // OptBerlin
            // 
            OptBerlin.AutoSize = true;
            OptBerlin.Location = new Point(15, 47);
            OptBerlin.Name = "OptBerlin";
            OptBerlin.Size = new Size(55, 19);
            OptBerlin.TabIndex = 5;
            OptBerlin.Text = "Berlin";
            OptBerlin.UseVisualStyleBackColor = true;
            OptBerlin.CheckedChanged += OptBerlin_CheckedChanged;
            // 
            // OptRom
            // 
            OptRom.AutoSize = true;
            OptRom.Location = new Point(15, 122);
            OptRom.Name = "OptRom";
            OptRom.Size = new Size(50, 19);
            OptRom.TabIndex = 6;
            OptRom.Text = "Rom";
            OptRom.UseVisualStyleBackColor = true;
            OptRom.CheckedChanged += OptRom_CheckedChanged;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(45, 70);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(38, 15);
            Lbl1.TabIndex = 2;
            Lbl1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Lbl1);
            Controls.Add(grpBox1);
            Controls.Add(grpUnterkunft);
            Name = "Form1";
            Text = "Form1";
            grpUnterkunft.ResumeLayout(false);
            grpUnterkunft.PerformLayout();
            grpBox1.ResumeLayout(false);
            grpBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpUnterkunft;
        private RadioButton OptFerienwohnung;
        private RadioButton OptBedBreakfast;
        private RadioButton OptHotel;
        private System.Windows.Forms.GroupBox grpBox1;
        private RadioButton OptParis;
        private RadioButton OptBerlin;
        private RadioButton OptRom;
        private Label Lbl1;
    }
}
