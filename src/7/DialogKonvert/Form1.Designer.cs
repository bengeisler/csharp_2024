// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace DialogKonvert
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
            BtnSchreiben = new Button();
            IstWerte = new ListBox();
            IstFehler = new ListBox();
            SuspendLayout();
            // 
            // BtnLesen
            // 
            BtnLesen.Location = new Point(58, 31);
            BtnLesen.Name = "BtnLesen";
            BtnLesen.Size = new Size(75, 23);
            BtnLesen.TabIndex = 0;
            BtnLesen.Text = "Lesen";
            BtnLesen.UseVisualStyleBackColor = true;
            BtnLesen.Click += BtnLesen_Click;
            // 
            // BtnSchreiben
            // 
            BtnSchreiben.Location = new Point(213, 31);
            BtnSchreiben.Name = "BtnSchreiben";
            BtnSchreiben.Size = new Size(75, 23);
            BtnSchreiben.TabIndex = 1;
            BtnSchreiben.Text = "Schreiben";
            BtnSchreiben.UseVisualStyleBackColor = true;
            // 
            // IstWerte
            // 
            IstWerte.FormattingEnabled = true;
            IstWerte.ItemHeight = 15;
            IstWerte.Location = new Point(39, 60);
            IstWerte.Name = "IstWerte";
            IstWerte.Size = new Size(120, 289);
            IstWerte.TabIndex = 2;
            // 
            // IstFehler
            // 
            IstFehler.FormattingEnabled = true;
            IstFehler.ItemHeight = 15;
            IstFehler.Location = new Point(191, 60);
            IstFehler.Name = "IstFehler";
            IstFehler.Size = new Size(120, 289);
            IstFehler.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 366);
            Controls.Add(IstFehler);
            Controls.Add(IstWerte);
            Controls.Add(BtnSchreiben);
            Controls.Add(BtnLesen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnLesen;
        private Button BtnSchreiben;
        private ListBox IstWerte;
        private ListBox IstFehler;
    }
}
