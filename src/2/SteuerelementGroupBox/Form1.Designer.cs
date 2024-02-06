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
            LblAnzeigen1 = new Label();
            groupBox1 = new GroupBox();
            OptRom = new RadioButton();
            OptParis = new RadioButton();
            OptBerlin = new RadioButton();
            groupBox2 = new GroupBox();
            OptHotel = new RadioButton();
            OptBed = new RadioButton();
            OptFerienwohnung = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // LblAnzeigen1
            // 
            LblAnzeigen1.AutoSize = true;
            LblAnzeigen1.Location = new Point(157, 118);
            LblAnzeigen1.Name = "LblAnzeigen1";
            LblAnzeigen1.Size = new Size(42, 15);
            LblAnzeigen1.TabIndex = 0;
            LblAnzeigen1.Text = "XXXXX";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OptRom);
            groupBox1.Controls.Add(OptParis);
            groupBox1.Controls.Add(OptBerlin);
            groupBox1.Location = new Point(131, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // OptRom
            // 
            OptRom.AutoSize = true;
            OptRom.Location = new Point(6, 75);
            OptRom.Name = "OptRom";
            OptRom.Size = new Size(50, 19);
            OptRom.TabIndex = 2;
            OptRom.TabStop = true;
            OptRom.Text = "Rom";
            OptRom.UseVisualStyleBackColor = true;
            OptRom.CheckedChanged += OptRom_CheckedChanged;
            // 
            // OptParis
            // 
            OptParis.AutoSize = true;
            OptParis.Location = new Point(6, 47);
            OptParis.Name = "OptParis";
            OptParis.Size = new Size(50, 19);
            OptParis.TabIndex = 1;
            OptParis.TabStop = true;
            OptParis.Text = "Paris";
            OptParis.UseVisualStyleBackColor = true;
            OptParis.CheckedChanged += OptParis_CheckedChanged;
            // 
            // OptBerlin
            // 
            OptBerlin.AutoSize = true;
            OptBerlin.Location = new Point(6, 22);
            OptBerlin.Name = "OptBerlin";
            OptBerlin.Size = new Size(55, 19);
            OptBerlin.TabIndex = 0;
            OptBerlin.TabStop = true;
            OptBerlin.Text = "Berlin";
            OptBerlin.UseVisualStyleBackColor = true;
            OptBerlin.CheckedChanged += OptBerlin_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(OptHotel);
            groupBox2.Controls.Add(OptBed);
            groupBox2.Controls.Add(OptFerienwohnung);
            groupBox2.Location = new Point(509, 187);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // OptHotel
            // 
            OptHotel.AutoSize = true;
            OptHotel.Location = new Point(6, 75);
            OptHotel.Name = "OptHotel";
            OptHotel.Size = new Size(54, 19);
            OptHotel.TabIndex = 5;
            OptHotel.Text = "Hotel";
            OptHotel.UseVisualStyleBackColor = true;
            OptHotel.CheckedChanged += OptHotel_CheckedChanged;
            // 
            // OptBed
            // 
            OptBed.AutoSize = true;
            OptBed.Location = new Point(6, 22);
            OptBed.Name = "OptBed";
            OptBed.Size = new Size(119, 19);
            OptBed.TabIndex = 3;
            OptBed.Text = "Bed and Breakfast";
            OptBed.UseVisualStyleBackColor = true;
            OptBed.CheckedChanged += OprBed_CheckedChanged;
            // 
            // OptFerienwohnung
            // 
            OptFerienwohnung.AutoSize = true;
            OptFerienwohnung.Location = new Point(6, 47);
            OptFerienwohnung.Name = "OptFerienwohnung";
            OptFerienwohnung.Size = new Size(108, 19);
            OptFerienwohnung.TabIndex = 4;
            OptFerienwohnung.Text = "Ferienwohnung";
            OptFerienwohnung.UseVisualStyleBackColor = true;
            OptFerienwohnung.CheckedChanged += OptFerienwohnung_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(LblAnzeigen1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAnzeigen1;
        private GroupBox groupBox1;
        private RadioButton OptRom;
        private RadioButton OptParis;
        private RadioButton OptBerlin;
        private GroupBox groupBox2;
        private RadioButton OptHotel;
        private RadioButton OptBed;
        private RadioButton OptFerienwohnung;
    }
}
