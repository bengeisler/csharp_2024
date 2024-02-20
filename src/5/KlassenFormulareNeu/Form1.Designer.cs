// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenFormulareNeu
{
    partial class Hauptformular
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
            Cmd = new Button();
            TxtEingabe = new TextBox();
            chkOK = new CheckBox();
            SuspendLayout();
            // 
            // Cmd
            // 
            Cmd.Location = new Point(23, 82);
            Cmd.Name = "Cmd";
            Cmd.Size = new Size(120, 64);
            Cmd.TabIndex = 0;
            Cmd.Text = "Unterformular aufrufen";
            Cmd.UseVisualStyleBackColor = true;
            Cmd.Click += Cmd_Click;
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(23, 29);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(100, 23);
            TxtEingabe.TabIndex = 1;
            // 
            // chkOK
            // 
            chkOK.AutoSize = true;
            chkOK.Location = new Point(186, 33);
            chkOK.Name = "chkOK";
            chkOK.Size = new Size(41, 19);
            chkOK.TabIndex = 2;
            chkOK.Text = "Ok";
            chkOK.UseVisualStyleBackColor = true;
            // 
            // Hauptformular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkOK);
            Controls.Add(TxtEingabe);
            Controls.Add(Cmd);
            Name = "Hauptformular";
            Text = "Hauptformular";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cmd;
        private TextBox TxtEingabe;
        private CheckBox chkOK;
    }
}
