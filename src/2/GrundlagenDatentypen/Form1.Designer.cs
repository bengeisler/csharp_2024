// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenDatentypen
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
            CmdAnzeigen = new Button();
            LabelAnzeigen = new Label();
            SuspendLayout();
            // 
            // CmdAnzeigen
            // 
            CmdAnzeigen.Location = new Point(604, 28);
            CmdAnzeigen.Name = "CmdAnzeigen";
            CmdAnzeigen.Size = new Size(75, 23);
            CmdAnzeigen.TabIndex = 0;
            CmdAnzeigen.Text = "Anzeigen";
            CmdAnzeigen.UseVisualStyleBackColor = true;
            CmdAnzeigen.Click += CmdAnzeigen_Click;
            // 
            // LabelAnzeigen
            // 
            LabelAnzeigen.AutoSize = true;
            LabelAnzeigen.Location = new Point(48, 28);
            LabelAnzeigen.Name = "LabelAnzeigen";
            LabelAnzeigen.Size = new Size(38, 15);
            LabelAnzeigen.TabIndex = 1;
            LabelAnzeigen.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 418);
            Controls.Add(LabelAnzeigen);
            Controls.Add(CmdAnzeigen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeigen;
        private Label LabelAnzeigen;
    }
}
