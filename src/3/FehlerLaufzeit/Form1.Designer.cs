// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace FehlerLaufzeit
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
            cmdOhneEx = new Button();
            cmdMitEx = new Button();
            cmdMitExerw = new Button();
            LblAnzeigen = new Label();
            txtBox1 = new TextBox();
            txtBox2 = new TextBox();
            CmdAuslösen = new Button();
            SuspendLayout();
            // 
            // cmdOhneEx
            // 
            cmdOhneEx.Location = new Point(148, 11);
            cmdOhneEx.Name = "cmdOhneEx";
            cmdOhneEx.Size = new Size(208, 23);
            cmdOhneEx.TabIndex = 0;
            cmdOhneEx.Text = "Ohne Exception Handling";
            cmdOhneEx.UseVisualStyleBackColor = true;
            cmdOhneEx.Click += cmdOhneEx_Click;
            // 
            // cmdMitEx
            // 
            cmdMitEx.Location = new Point(148, 41);
            cmdMitEx.Name = "cmdMitEx";
            cmdMitEx.Size = new Size(208, 23);
            cmdMitEx.TabIndex = 1;
            cmdMitEx.Text = "Mit Exception Handling";
            cmdMitEx.UseVisualStyleBackColor = true;
            // 
            // cmdMitExerw
            // 
            cmdMitExerw.Location = new Point(148, 70);
            cmdMitExerw.Name = "cmdMitExerw";
            cmdMitExerw.Size = new Size(208, 23);
            cmdMitExerw.TabIndex = 2;
            cmdMitExerw.Text = "Mit erweitertem Exception Handling";
            cmdMitExerw.UseVisualStyleBackColor = true;
            // 
            // LblAnzeigen
            // 
            LblAnzeigen.AutoSize = true;
            LblAnzeigen.Location = new Point(22, 107);
            LblAnzeigen.Name = "LblAnzeigen";
            LblAnzeigen.Size = new Size(38, 15);
            LblAnzeigen.TabIndex = 3;
            LblAnzeigen.Text = "label1";
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(22, 12);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(100, 23);
            txtBox1.TabIndex = 4;
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(22, 41);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(100, 23);
            txtBox2.TabIndex = 5;
            // 
            // CmdAuslösen
            // 
            CmdAuslösen.Location = new Point(148, 99);
            CmdAuslösen.Name = "CmdAuslösen";
            CmdAuslösen.Size = new Size(208, 23);
            CmdAuslösen.TabIndex = 6;
            CmdAuslösen.Text = "Ausnahme auslösen";
            CmdAuslösen.UseVisualStyleBackColor = true;
            CmdAuslösen.Click += CmdAuslösen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAuslösen);
            Controls.Add(txtBox2);
            Controls.Add(txtBox1);
            Controls.Add(LblAnzeigen);
            Controls.Add(cmdMitExerw);
            Controls.Add(cmdMitEx);
            Controls.Add(cmdOhneEx);
            Name = "Form1";
            Text = "Laufzeitfehler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdOhneEx;
        private Button cmdMitEx;
        private Button cmdMitExerw;
        private Label LblAnzeigen;
        private TextBox txtBox1;
        private TextBox txtBox2;
        private Button CmdAuslösen;
    }
}
