// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UZahlenraten
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
            button1 = new Button();
            label1 = new Label();
            TxtEingabe = new TextBox();
            CmdAnzeigen = new Button();
            LblAnzeige = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(188, 34);
            button1.TabIndex = 0;
            button1.Text = "Zahl erzeugen";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 1;
            label1.Text = "Ihre Eingabe:";
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(136, 58);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(150, 31);
            TxtEingabe.TabIndex = 2;
            // 
            // CmdAnzeigen
            // 
            CmdAnzeigen.Location = new Point(292, 56);
            CmdAnzeigen.Name = "CmdAnzeigen";
            CmdAnzeigen.Size = new Size(191, 34);
            CmdAnzeigen.TabIndex = 4;
            CmdAnzeigen.Text = "Eingabe prüfen";
            CmdAnzeigen.UseVisualStyleBackColor = true;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(12, 104);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(59, 25);
            LblAnzeige.TabIndex = 3;
            LblAnzeige.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 162);
            Controls.Add(CmdAnzeigen);
            Controls.Add(LblAnzeige);
            Controls.Add(TxtEingabe);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Zahlenraten";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox TxtEingabe;
        private Button CmdAnzeigen;
        private Label LblAnzeige;
    }
}
