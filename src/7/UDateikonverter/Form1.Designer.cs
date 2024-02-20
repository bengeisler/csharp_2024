// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UDateikonverter
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
            BtnLesen = new Button();
            btnSchreiben = new Button();
            lstWerte = new ListBox();
            LstFehler = new ListBox();
            SuspendLayout();
            // 
            // BtnLesen
            // 
            BtnLesen.Location = new Point(176, 44);
            BtnLesen.Name = "BtnLesen";
            BtnLesen.Size = new Size(75, 23);
            BtnLesen.TabIndex = 0;
            BtnLesen.Text = "Lesen";
            BtnLesen.UseVisualStyleBackColor = true;
            BtnLesen.Click += BtnLesen_Click;
            // 
            // btnSchreiben
            // 
            btnSchreiben.Location = new Point(432, 44);
            btnSchreiben.Name = "btnSchreiben";
            btnSchreiben.Size = new Size(75, 23);
            btnSchreiben.TabIndex = 1;
            btnSchreiben.Text = "Schreiben";
            btnSchreiben.UseVisualStyleBackColor = true;
            btnSchreiben.Click += btnSchreiben_Click;
            // 
            // lstWerte
            // 
            lstWerte.FormattingEnabled = true;
            lstWerte.ItemHeight = 15;
            lstWerte.Location = new Point(155, 123);
            lstWerte.Name = "lstWerte";
            lstWerte.Size = new Size(120, 229);
            lstWerte.TabIndex = 2;
            lstWerte.SelectedIndexChanged += lstWerte_SelectedIndexChanged;
            // 
            // LstFehler
            // 
            LstFehler.FormattingEnabled = true;
            LstFehler.ItemHeight = 15;
            LstFehler.Location = new Point(418, 123);
            LstFehler.Name = "LstFehler";
            LstFehler.Size = new Size(120, 229);
            LstFehler.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LstFehler);
            Controls.Add(lstWerte);
            Controls.Add(btnSchreiben);
            Controls.Add(BtnLesen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnLesen;
        private Button btnSchreiben;
        private ListBox lstWerte;
        private ListBox LstFehler;
    }
}
