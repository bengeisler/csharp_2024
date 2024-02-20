// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UKonverter
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
            CmdLaden = new Button();
            CmdSpeichern = new Button();
            LstWerte = new ListBox();
            LstFehler = new ListBox();
            SuspendLayout();
            // 
            // CmdLaden
            // 
            CmdLaden.Location = new Point(79, 12);
            CmdLaden.Name = "CmdLaden";
            CmdLaden.Size = new Size(112, 34);
            CmdLaden.TabIndex = 0;
            CmdLaden.Text = "Laden";
            CmdLaden.UseVisualStyleBackColor = true;
            CmdLaden.Click += CmdLaden_Click;
            // 
            // CmdSpeichern
            // 
            CmdSpeichern.Location = new Point(322, 12);
            CmdSpeichern.Name = "CmdSpeichern";
            CmdSpeichern.Size = new Size(112, 34);
            CmdSpeichern.TabIndex = 1;
            CmdSpeichern.Text = "Speichern";
            CmdSpeichern.UseVisualStyleBackColor = true;
            CmdSpeichern.Click += CmdSpeichern_Click;
            // 
            // LstWerte
            // 
            LstWerte.FormattingEnabled = true;
            LstWerte.ItemHeight = 25;
            LstWerte.Location = new Point(12, 52);
            LstWerte.Name = "LstWerte";
            LstWerte.Size = new Size(242, 279);
            LstWerte.TabIndex = 2;
            // 
            // LstFehler
            // 
            LstFehler.FormattingEnabled = true;
            LstFehler.ItemHeight = 25;
            LstFehler.Location = new Point(260, 52);
            LstFehler.Name = "LstFehler";
            LstFehler.Size = new Size(242, 279);
            LstFehler.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 351);
            Controls.Add(LstFehler);
            Controls.Add(LstWerte);
            Controls.Add(CmdSpeichern);
            Controls.Add(CmdLaden);
            Name = "Form1";
            Text = "Dateikonverter";
            ResumeLayout(false);
        }

        #endregion

        private Button CmdLaden;
        private Button CmdSpeichern;
        private ListBox LstWerte;
        private ListBox LstFehler;
    }
}
