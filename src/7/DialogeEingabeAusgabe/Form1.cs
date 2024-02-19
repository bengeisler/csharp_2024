// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.VisualBasic;

namespace DialogeEingabeAusgabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdButton1_Click(object sender, EventArgs e)
        {
            string eingabe = Interaction.InputBox("Bitte Ihren Namen:", "Ihr Name", "Maier");
            if (eingabe != "") LblAnzeige1.Text = eingabe;
        }

        private void CmdButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Infogelesen? Dann bitte bestätigen.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CmdButton4_Click(object sender, EventArgs e)
        {
            var ergebnis =MessageBox.Show("Soll die Datei gesichert werden?.", "Sicherung", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            LblAnzeige1.Text = ergebnis == DialogResult.Yes ? "Ja" : "Nein";
            //if (ergebnis == DialogResult.Yes)  LblAnzeige1.Text = "ja"; 
            //else  LblAnzeige1.Text = "nein"; 
        }
    }
}
