// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenFormulare
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
            TxtEingabe = new TextBox();
            CmdAufrufen = new Button();
            ChkOk = new CheckBox();
            SuspendLayout();
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(12, 12);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(150, 31);
            TxtEingabe.TabIndex = 0;
            // 
            // CmdAufrufen
            // 
            CmdAufrufen.Location = new Point(12, 49);
            CmdAufrufen.Name = "CmdAufrufen";
            CmdAufrufen.Size = new Size(150, 66);
            CmdAufrufen.TabIndex = 1;
            CmdAufrufen.Text = "Unterformular aufrufen";
            CmdAufrufen.UseVisualStyleBackColor = true;
            CmdAufrufen.Click += CmdAufrufen_Click;
            // 
            // ChkOk
            // 
            ChkOk.AutoSize = true;
            ChkOk.Location = new Point(15, 133);
            ChkOk.Name = "ChkOk";
            ChkOk.Size = new Size(61, 29);
            ChkOk.TabIndex = 2;
            ChkOk.Text = "Ok";
            ChkOk.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChkOk);
            Controls.Add(CmdAufrufen);
            Controls.Add(TxtEingabe);
            Name = "Form1";
            Text = "Hauptformular";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtEingabe;
        private Button CmdAufrufen;
        private CheckBox ChkOk;
    }
}
