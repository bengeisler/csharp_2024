// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.Eventing.Reader;
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
            LblAusgabe.Text = eingabe;
            if (eingabe != "") LblAusgabe.Text = eingabe;

        }

        private void CmdInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Info gelsen? Dann bitte bestštigen", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CmdJaNein_Click(object sender, EventArgs e)
        {
            var ergebnis = MessageBox.Show("Soll Datei gesichert ?","sicherung",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ergebnis == DialogResult.Yes) LblAusgabe.Text = "Ja";
            else LblAusgabe.Text = "Nein";

            
                
       
        }   
    }
}
