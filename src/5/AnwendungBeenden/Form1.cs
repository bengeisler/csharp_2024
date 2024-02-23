// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace AnwendungBeenden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            var ergebnis = MessageBox.Show("Wollen sie wirklich beenden?", "Beenden?", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (ergebnis == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
