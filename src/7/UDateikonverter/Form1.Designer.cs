// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UDateikonverter
{
    partial class Dateikonverter
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
            BtnLesen = new Button();
            BtnSchreiben = new Button();
            LstWert = new ListBox();
            LstFehler = new ListBox();
            SuspendLayout();
            // 
            // BtnLesen
            // 
            BtnLesen.Location = new Point(69, 25);
            BtnLesen.Name = "BtnLesen";
            BtnLesen.Size = new Size(75, 23);
            BtnLesen.TabIndex = 0;
            BtnLesen.Text = "Lesen";
            BtnLesen.UseVisualStyleBackColor = true;
            BtnLesen.Click += BtnLesen_Click;
            // 
            // BtnSchreiben
            // 
            BtnSchreiben.Location = new Point(295, 25);
            BtnSchreiben.Name = "BtnSchreiben";
            BtnSchreiben.Size = new Size(75, 23);
            BtnSchreiben.TabIndex = 1;
            BtnSchreiben.Text = "Schreiben";
            BtnSchreiben.UseVisualStyleBackColor = true;
            BtnSchreiben.Click += BtnSchreiben_Click;
            // 
            // LstWert
            // 
            LstWert.FormattingEnabled = true;
            LstWert.ItemHeight = 15;
            LstWert.Location = new Point(22, 65);
            LstWert.Name = "LstWert";
            LstWert.Size = new Size(175, 319);
            LstWert.TabIndex = 2;
            // 
            // LstFehler
            // 
            LstFehler.FormattingEnabled = true;
            LstFehler.ItemHeight = 15;
            LstFehler.Location = new Point(243, 65);
            LstFehler.Name = "LstFehler";
            LstFehler.Size = new Size(175, 319);
            LstFehler.TabIndex = 3;
            // 
            // Dateikonverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LstFehler);
            Controls.Add(LstWert);
            Controls.Add(BtnSchreiben);
            Controls.Add(BtnLesen);
            Name = "Dateikonverter";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnLesen;
        private Button BtnSchreiben;
        private ListBox LstWert;
        private ListBox LstFehler;
    }
}
