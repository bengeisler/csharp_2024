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

        private void CmdEingabe_Click(object sender, EventArgs e)
        {
            string eingabe = Interaction.InputBox("Bitte Ihren Namen:", "Ihr Name", "Maier");
            if (eingabe != "") LblAngabe.Text = eingabe;

        }

        private void CmdInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Info gelesen? Dann bitte bestätigen.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CmdJaNein_Click(object sender, EventArgs e)
        {
            var ergebnis = MessageBox.Show("Soll die Datei gesichert werden?", "Sicherung", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            // Ternärer Operator
            LblAngabe.Text = ergebnis == DialogResult.Yes ? "Ja" : "Nein";
            if (ergebnis == DialogResult.Yes) LblAngabe.Text = "Ja";
            else LblAngabe.Text = "Nein";

        }
    }
}
