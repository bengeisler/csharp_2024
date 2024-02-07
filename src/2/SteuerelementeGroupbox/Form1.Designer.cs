// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementeGroupbox
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
            groupBox1 = new GroupBox();
            OptRom = new RadioButton();
            OptParis = new RadioButton();
            OptBerlin = new RadioButton();
            groupBox2 = new GroupBox();
            OptHotel = new RadioButton();
            OptFerienwohnung = new RadioButton();
            OptBedBreakfast = new RadioButton();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OptRom);
            groupBox1.Controls.Add(OptParis);
            groupBox1.Controls.Add(OptBerlin);
            groupBox1.Location = new Point(61, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 162);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Urlaubsort";
            // 
            // OptRom
            // 
            OptRom.AutoSize = true;
            OptRom.Location = new Point(37, 91);
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
            OptParis.Location = new Point(37, 66);
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
            OptBerlin.Location = new Point(37, 41);
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
            groupBox2.Controls.Add(OptFerienwohnung);
            groupBox2.Controls.Add(OptBedBreakfast);
            groupBox2.Location = new Point(448, 132);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(214, 158);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Unterkunft";
            // 
            // OptHotel
            // 
            OptHotel.AutoSize = true;
            OptHotel.Location = new Point(30, 92);
            OptHotel.Name = "OptHotel";
            OptHotel.Size = new Size(54, 19);
            OptHotel.TabIndex = 3;
            OptHotel.TabStop = true;
            OptHotel.Text = "Hotel";
            OptHotel.UseVisualStyleBackColor = true;
            OptHotel.CheckedChanged += OptHotel_CheckedChanged;
            // 
            // OptFerienwohnung
            // 
            OptFerienwohnung.AutoSize = true;
            OptFerienwohnung.Location = new Point(30, 67);
            OptFerienwohnung.Name = "OptFerienwohnung";
            OptFerienwohnung.Size = new Size(108, 19);
            OptFerienwohnung.TabIndex = 2;
            OptFerienwohnung.TabStop = true;
            OptFerienwohnung.Text = "Ferienwohnung";
            OptFerienwohnung.UseVisualStyleBackColor = true;
            OptFerienwohnung.CheckedChanged += OptFerienwohnung_CheckedChanged;
            // 
            // OptBedBreakfast
            // 
            OptBedBreakfast.AutoSize = true;
            OptBedBreakfast.Location = new Point(30, 42);
            OptBedBreakfast.Name = "OptBedBreakfast";
            OptBedBreakfast.Size = new Size(119, 19);
            OptBedBreakfast.TabIndex = 1;
            OptBedBreakfast.TabStop = true;
            OptBedBreakfast.Text = "Bed and Breakfast";
            OptBedBreakfast.UseVisualStyleBackColor = true;
            OptBedBreakfast.CheckedChanged += OptBedBreakfast_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 44);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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

        private GroupBox groupBox1;
        private RadioButton OptRom;
        private RadioButton OptParis;
        private RadioButton OptBerlin;
        private GroupBox groupBox2;
        private RadioButton OptHotel;
        private RadioButton OptFerienwohnung;
        private RadioButton OptBedBreakfast;
        private Label label1;
    }
}
