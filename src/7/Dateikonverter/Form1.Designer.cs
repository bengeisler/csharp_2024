// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Dateikonverter
{
    partial class FrmKonveter
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
            CmdLesen = new Button();
            CmdSchreiben = new Button();
            Listbox1 = new ListBox();
            Listbox2 = new ListBox();
            SuspendLayout();
            // 
            // CmdLesen
            // 
            CmdLesen.Location = new Point(76, 39);
            CmdLesen.Name = "CmdLesen";
            CmdLesen.Size = new Size(75, 23);
            CmdLesen.TabIndex = 0;
            CmdLesen.Text = "Lesen";
            CmdLesen.UseVisualStyleBackColor = true;
            CmdLesen.Click += CmdLesen_Click;
            // 
            // CmdSchreiben
            // 
            CmdSchreiben.Location = new Point(285, 39);
            CmdSchreiben.Name = "CmdSchreiben";
            CmdSchreiben.Size = new Size(75, 23);
            CmdSchreiben.TabIndex = 1;
            CmdSchreiben.Text = "Schreiben";
            CmdSchreiben.UseVisualStyleBackColor = true;
            CmdSchreiben.Click += CmdSchreiben_Click;
            // 
            // Listbox1
            // 
            Listbox1.FormattingEnabled = true;
            Listbox1.ItemHeight = 15;
            Listbox1.Location = new Point(76, 108);
            Listbox1.Name = "Listbox1";
            Listbox1.Size = new Size(135, 199);
            Listbox1.TabIndex = 2;
            Listbox1.SelectedIndexChanged += Listbox1_SelectedIndexChanged;
            // 
            // Listbox2
            // 
            Listbox2.FormattingEnabled = true;
            Listbox2.ItemHeight = 15;
            Listbox2.Location = new Point(285, 108);
            Listbox2.Name = "Listbox2";
            Listbox2.Size = new Size(142, 199);
            Listbox2.TabIndex = 3;
            // 
            // FrmKonveter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Listbox2);
            Controls.Add(Listbox1);
            Controls.Add(CmdSchreiben);
            Controls.Add(CmdLesen);
            Name = "FrmKonveter";
            Text = "Dateikonverter";
            ResumeLayout(false);
        }

        #endregion

        private Button CmdLesen;
        private Button CmdSchreiben;
        private ListBox Listbox1;
        private ListBox Listbox2;
    }
}
