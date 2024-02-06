// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementGroupBox
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
            GrpUrlaubsort = new GroupBox();
            OptRom = new RadioButton();
            OptParis = new RadioButton();
            OptBerlin = new RadioButton();
            GrpUnterkunft = new GroupBox();
            OptHotel = new RadioButton();
            OptFerienwohnung = new RadioButton();
            OptBedandBreakfast = new RadioButton();
            LblAnzeigen1 = new Label();
            GrpUrlaubsort.SuspendLayout();
            GrpUnterkunft.SuspendLayout();
            SuspendLayout();
            // 
            // GrpUrlaubsort
            // 
            GrpUrlaubsort.Controls.Add(OptRom);
            GrpUrlaubsort.Controls.Add(OptParis);
            GrpUrlaubsort.Controls.Add(OptBerlin);
            GrpUrlaubsort.Location = new Point(48, 61);
            GrpUrlaubsort.Name = "GrpUrlaubsort";
            GrpUrlaubsort.Size = new Size(200, 100);
            GrpUrlaubsort.TabIndex = 0;
            GrpUrlaubsort.TabStop = false;
            GrpUrlaubsort.Text = "Urlaubsort";
            // 
            // OptRom
            // 
            OptRom.AutoSize = true;
            OptRom.Location = new Point(17, 74);
            OptRom.Name = "OptRom";
            OptRom.Size = new Size(50, 19);
            OptRom.TabIndex = 2;
            OptRom.Text = "Rom";
            OptRom.UseVisualStyleBackColor = true;
            OptRom.CheckedChanged += OptRom_CheckedChanged;
            // 
            // OptParis
            // 
            OptParis.AutoSize = true;
            OptParis.Location = new Point(17, 49);
            OptParis.Name = "OptParis";
            OptParis.Size = new Size(50, 19);
            OptParis.TabIndex = 1;
            OptParis.Text = "Paris";
            OptParis.UseVisualStyleBackColor = true;
            OptParis.CheckedChanged += OptParis_CheckedChanged;
            // 
            // OptBerlin
            // 
            OptBerlin.AutoSize = true;
            OptBerlin.Location = new Point(17, 24);
            OptBerlin.Name = "OptBerlin";
            OptBerlin.Size = new Size(55, 19);
            OptBerlin.TabIndex = 0;
            OptBerlin.Text = "Berlin";
            OptBerlin.UseVisualStyleBackColor = true;
            OptBerlin.CheckedChanged += OptBerlin_CheckedChanged;
            // 
            // GrpUnterkunft
            // 
            GrpUnterkunft.Controls.Add(OptHotel);
            GrpUnterkunft.Controls.Add(OptFerienwohnung);
            GrpUnterkunft.Controls.Add(OptBedandBreakfast);
            GrpUnterkunft.Location = new Point(365, 61);
            GrpUnterkunft.Name = "GrpUnterkunft";
            GrpUnterkunft.Size = new Size(200, 100);
            GrpUnterkunft.TabIndex = 3;
            GrpUnterkunft.TabStop = false;
            GrpUnterkunft.Text = "Unterkunft";
            // 
            // OptHotel
            // 
            OptHotel.AutoSize = true;
            OptHotel.Location = new Point(17, 74);
            OptHotel.Name = "OptHotel";
            OptHotel.Size = new Size(54, 19);
            OptHotel.TabIndex = 2;
            OptHotel.Text = "Hotel";
            OptHotel.UseVisualStyleBackColor = true;
            OptHotel.CheckedChanged += OptHotel_CheckedChanged;
            // 
            // OptFerienwohnung
            // 
            OptFerienwohnung.AutoSize = true;
            OptFerienwohnung.Location = new Point(17, 49);
            OptFerienwohnung.Name = "OptFerienwohnung";
            OptFerienwohnung.Size = new Size(108, 19);
            OptFerienwohnung.TabIndex = 1;
            OptFerienwohnung.Text = "Ferienwohnung";
            OptFerienwohnung.UseVisualStyleBackColor = true;
            OptFerienwohnung.CheckedChanged += OptFerienwohnung_CheckedChanged;
            // 
            // OptBedandBreakfast
            // 
            OptBedandBreakfast.AutoSize = true;
            OptBedandBreakfast.Location = new Point(17, 24);
            OptBedandBreakfast.Name = "OptBedandBreakfast";
            OptBedandBreakfast.Size = new Size(119, 19);
            OptBedandBreakfast.TabIndex = 0;
            OptBedandBreakfast.Text = "Bed and Breakfast";
            OptBedandBreakfast.UseVisualStyleBackColor = true;
            OptBedandBreakfast.CheckedChanged += OptBedandBreakfast_CheckedChanged;
            // 
            // LblAnzeigen1
            // 
            LblAnzeigen1.AutoSize = true;
            LblAnzeigen1.Location = new Point(48, 22);
            LblAnzeigen1.Name = "LblAnzeigen1";
            LblAnzeigen1.Size = new Size(38, 15);
            LblAnzeigen1.TabIndex = 4;
            LblAnzeigen1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeigen1);
            Controls.Add(GrpUnterkunft);
            Controls.Add(GrpUrlaubsort);
            Name = "Form1";
            Text = "GroupBox";
            GrpUrlaubsort.ResumeLayout(false);
            GrpUrlaubsort.PerformLayout();
            GrpUnterkunft.ResumeLayout(false);
            GrpUnterkunft.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GrpUrlaubsort;
        private RadioButton OptRom;
        private RadioButton OptParis;
        private RadioButton OptBerlin;
        private GroupBox GrpUnterkunft;
        private RadioButton OptHotel;
        private RadioButton OptFerienwohnung;
        private RadioButton OptBedandBreakfast;
        private Label LblAnzeigen1;
    }
}
