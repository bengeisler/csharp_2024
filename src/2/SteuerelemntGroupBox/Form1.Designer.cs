// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelemntGroupBox
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
            OptFerienwohung = new RadioButton();
            OptBedandBreakfast = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(25, 9);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 0;
            LblAnzeige.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OptRom);
            groupBox1.Controls.Add(OptParis);
            groupBox1.Controls.Add(OptBerlin);
            groupBox1.Location = new Point(25, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(203, 145);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Urlaubsort";
            // 
            // OptRom
            // 
            OptRom.AutoSize = true;
            OptRom.Location = new Point(6, 69);
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
            OptParis.Location = new Point(6, 44);
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
            OptBerlin.Location = new Point(3, 19);
            OptBerlin.Name = "OptBerlin";
            OptBerlin.Size = new Size(55, 19);
            OptBerlin.TabIndex = 0;
            OptBerlin.Text = "Berlin";
            OptBerlin.UseVisualStyleBackColor = true;
            OptBerlin.CheckedChanged += OptBerlin_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(OptHotel);
            groupBox2.Controls.Add(OptFerienwohung);
            groupBox2.Controls.Add(OptBedandBreakfast);
            groupBox2.Location = new Point(399, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(199, 152);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Urlaubsort";
            // 
            // OptHotel
            // 
            OptHotel.AutoSize = true;
            OptHotel.Location = new Point(18, 72);
            OptHotel.Name = "OptHotel";
            OptHotel.Size = new Size(54, 19);
            OptHotel.TabIndex = 5;
            OptHotel.Text = "Hotel";
            OptHotel.UseVisualStyleBackColor = true;
            OptHotel.CheckedChanged += OptHotel_CheckedChanged;
            // 
            // OptFerienwohung
            // 
            OptFerienwohung.AutoSize = true;
            OptFerienwohung.Location = new Point(18, 47);
            OptFerienwohung.Name = "OptFerienwohung";
            OptFerienwohung.Size = new Size(101, 19);
            OptFerienwohung.TabIndex = 4;
            OptFerienwohung.Text = "Ferienwohung";
            OptFerienwohung.UseVisualStyleBackColor = true;
            OptFerienwohung.CheckedChanged += OptFerienwohung_CheckedChanged;
            // 
            // OptBedandBreakfast
            // 
            OptBedandBreakfast.AutoSize = true;
            OptBedandBreakfast.Location = new Point(18, 22);
            OptBedandBreakfast.Name = "OptBedandBreakfast";
            OptBedandBreakfast.Size = new Size(119, 19);
            OptBedandBreakfast.TabIndex = 3;
            OptBedandBreakfast.Text = "Bed and Breakfast";
            OptBedandBreakfast.UseVisualStyleBackColor = true;
            OptBedandBreakfast.CheckedChanged += OptBedandBreakfast_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(LblAnzeige);
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

        private Label LblAnzeige;
        private GroupBox groupBox1;
        private RadioButton OptBedandBreakfast;
        private RadioButton OptRom;
        private RadioButton OptParis;
        private RadioButton OptBerlin;
        private GroupBox groupBox2;
        private RadioButton OptHotel;
        private RadioButton OptFerienwohung;
    }
}
