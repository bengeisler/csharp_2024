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
            LblAnzeige = new Label();
            groupBox1 = new GroupBox();
            OptRom = new RadioButton();
            OptParis = new RadioButton();
            OptBerlin = new RadioButton();
            groupBox2 = new GroupBox();
            OptHotel = new RadioButton();
            OptBedAndBreakfast = new RadioButton();
            OptFerienwohnung = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(13, 16);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(59, 25);
            LblAnzeige.TabIndex = 0;
            LblAnzeige.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OptRom);
            groupBox1.Controls.Add(OptParis);
            groupBox1.Controls.Add(OptBerlin);
            groupBox1.Location = new Point(13, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 150);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Urlaubsort";
            // 
            // OptRom
            // 
            OptRom.AutoSize = true;
            OptRom.Location = new Point(6, 112);
            OptRom.Name = "OptRom";
            OptRom.Size = new Size(74, 29);
            OptRom.TabIndex = 2;
            OptRom.Text = "Rom";
            OptRom.UseVisualStyleBackColor = true;
            OptRom.CheckedChanged += OptRom_CheckedChanged;
            // 
            // OptParis
            // 
            OptParis.AutoSize = true;
            OptParis.Location = new Point(6, 77);
            OptParis.Name = "OptParis";
            OptParis.Size = new Size(73, 29);
            OptParis.TabIndex = 1;
            OptParis.Text = "Paris";
            OptParis.UseVisualStyleBackColor = true;
            OptParis.CheckedChanged += OptParis_CheckedChanged;
            // 
            // OptBerlin
            // 
            OptBerlin.AutoSize = true;
            OptBerlin.Location = new Point(6, 42);
            OptBerlin.Name = "OptBerlin";
            OptBerlin.Size = new Size(80, 29);
            OptBerlin.TabIndex = 0;
            OptBerlin.Text = "Berlin";
            OptBerlin.UseVisualStyleBackColor = true;
            OptBerlin.CheckedChanged += OptBerlin_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(OptHotel);
            groupBox2.Controls.Add(OptBedAndBreakfast);
            groupBox2.Controls.Add(OptFerienwohnung);
            groupBox2.Location = new Point(374, 64);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 150);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Unterkunft";
            // 
            // OptHotel
            // 
            OptHotel.AutoSize = true;
            OptHotel.Location = new Point(6, 112);
            OptHotel.Name = "OptHotel";
            OptHotel.Size = new Size(80, 29);
            OptHotel.TabIndex = 5;
            OptHotel.Text = "Hotel";
            OptHotel.UseVisualStyleBackColor = true;
            OptHotel.CheckedChanged += OptHotel_CheckedChanged;
            // 
            // OptBedAndBreakfast
            // 
            OptBedAndBreakfast.AutoSize = true;
            OptBedAndBreakfast.Location = new Point(6, 42);
            OptBedAndBreakfast.Name = "OptBedAndBreakfast";
            OptBedAndBreakfast.Size = new Size(179, 29);
            OptBedAndBreakfast.TabIndex = 3;
            OptBedAndBreakfast.Text = "Bed and Breakfast";
            OptBedAndBreakfast.UseVisualStyleBackColor = true;
            OptBedAndBreakfast.CheckedChanged += OptBedAndBreakfast_CheckedChanged;
            // 
            // OptFerienwohnung
            // 
            OptFerienwohnung.AutoSize = true;
            OptFerienwohnung.Location = new Point(6, 77);
            OptFerienwohnung.Name = "OptFerienwohnung";
            OptFerienwohnung.Size = new Size(159, 29);
            OptFerienwohnung.TabIndex = 4;
            OptFerienwohnung.Text = "Ferienwohnung";
            OptFerienwohnung.UseVisualStyleBackColor = true;
            OptFerienwohnung.CheckedChanged += OptFerienwohnung_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 232);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(LblAnzeige);
            Name = "Form1";
            Text = "GroupBox";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAnzeige;
        private GroupBox groupBox1;
        private RadioButton OptRom;
        private RadioButton OptParis;
        private RadioButton OptBerlin;
        private GroupBox groupBox2;
        private RadioButton OptHotel;
        private RadioButton OptBedAndBreakfast;
        private RadioButton OptFerienwohnung;
    }
}
