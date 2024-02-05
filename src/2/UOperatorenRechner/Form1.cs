// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UOperatorenRechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAusgabe1_Click(object sender, EventArgs e)
        {
            double x = 3 * -2.5 + 4 * 2;
            LblAusgabe.Text = $"Ergebnis: {x}";


        }

        private void CmdAusgabe2_Click(object sender, EventArgs e)
        {
            ouble x = 3 * (-2.5 + 4) * 2;
            LblAusgabe.Text = $"Ergebnis: {x}";

        }

        private void CmdAusgabe3_Click(object sender, EventArgs e)
        {
            var dauer = 325;
            var stunden = dauer / 60;
            var minuten = dauer % 60; // Rest berechnen
            var sekunden = 
            LblAusgabe.Text = $"{dauer} Minuten sinid {stunden} Stunden und {minuten} Minuten.";
            var dauer = 3661;
            var stunden = dauer / 3600;
            var minuten = dauer / 60% 60
            var sekunden = dauer % 60;

            LblAusgabe.Text = $"{dauer} Sekunden sind {stunden} Stunden und {minuten} Minuten und {sekunden} sekunden";

        }
    }
}
