// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.VisualBasic;

namespace DialogEingabeAusgabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEingabe_Click(object sender, EventArgs e)
        {
            string eingabe = Interaction.InputBox("Bitte Ihren Namen:", "Ihre Name", "Maier");
            if (eingabe != "") LblAusgabe.Text = eingabe;
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Info gelesen? Dann bitte bestätigen", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnJaNein_Click(object sender, EventArgs e)
        {
            var ergebnis = MessageBox.Show("Soll die Datei gesichert werden?", "Sicherung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (ergebnis == DialogResult.Yes) LblAusgabe.Text = "Ja";
            else LblAusgabe.Text = "Nein";
        }
    }
}
