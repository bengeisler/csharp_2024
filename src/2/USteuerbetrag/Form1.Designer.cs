// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace USteuerbetrag
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
            CmdBerechnenIfElse = new Button();
            label1 = new Label();
            TxtGehalt = new TextBox();
            LblSteuerbetrag = new Label();
            cmdSwitch = new Button();
            SuspendLayout();
            // 
            // CmdBerechnenIfElse
            // 
            CmdBerechnenIfElse.Location = new Point(8, 52);
            CmdBerechnenIfElse.Margin = new Padding(2, 2, 2, 2);
            CmdBerechnenIfElse.Name = "CmdBerechnenIfElse";
            CmdBerechnenIfElse.Size = new Size(150, 20);
            CmdBerechnenIfElse.TabIndex = 0;
            CmdBerechnenIfElse.Text = "Berechnen mit if...else";
            CmdBerechnenIfElse.UseVisualStyleBackColor = true;
            CmdBerechnenIfElse.Click += CmdBerechnenIfElse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Gehalt:";
            // 
            // TxtGehalt
            // 
            TxtGehalt.Location = new Point(8, 22);
            TxtGehalt.Margin = new Padding(2, 2, 2, 2);
            TxtGehalt.Name = "TxtGehalt";
            TxtGehalt.Size = new Size(106, 23);
            TxtGehalt.TabIndex = 2;
            // 
            // LblSteuerbetrag
            // 
            LblSteuerbetrag.AutoSize = true;
            LblSteuerbetrag.Location = new Point(118, 24);
            LblSteuerbetrag.Margin = new Padding(2, 0, 2, 0);
            LblSteuerbetrag.Name = "LblSteuerbetrag";
            LblSteuerbetrag.Size = new Size(38, 15);
            LblSteuerbetrag.TabIndex = 3;
            LblSteuerbetrag.Text = "label2";
            // 
            // cmdSwitch
            // 
            cmdSwitch.Location = new Point(12, 93);
            cmdSwitch.Name = "cmdSwitch";
            cmdSwitch.Size = new Size(146, 23);
            cmdSwitch.TabIndex = 4;
            cmdSwitch.Text = "Berchnen mit Switch";
            cmdSwitch.UseVisualStyleBackColor = true;
            cmdSwitch.Click += cmdSwitch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 154);
            Controls.Add(cmdSwitch);
            Controls.Add(LblSteuerbetrag);
            Controls.Add(TxtGehalt);
            Controls.Add(label1);
            Controls.Add(CmdBerechnenIfElse);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "USteuerbetrag";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdBerechnenIfElse;
        private Label label1;
        private TextBox TxtGehalt;
        private Label LblSteuerbetrag;
        private Button cmdSwitch;
    }
}
