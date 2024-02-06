// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UOperatorenRechnen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAusdruck1_Click(object sender, EventArgs e)
        {
            // 1. Ausdruck: 3 * -2.5 + 4 * 2
            double x = 3 * -2.5 + 4 * 2;
            LblAnzeige.Text = $"Ergebnis: {x}";
        }

        private void CmdAusdruck2_Click(object sender, EventArgs e)
        {
            // 2. Ausdruck: 3 * (-2.5 + 4) * 2
            double x = 3 * (-2.5 + 4) * 2;
            LblAnzeige.Text = $"Ergebnis: {x}";
        }

        private void CmdAusdruck3_Click(object sender, EventArgs e)
        {
            /* ----------------------------------------------------------------------------
             * Rechne 325 Minuten in Stunden und Minuten um.
             *
             * Anzeige: 325 Minuten sind ... Stunden und ... Minuten.
             * ----------------------------------------------------------------------------
             */
            // 5 Stunden, 25 Minuten
            var dauer = 325;
            var stunden = dauer / 60; // Vorkommastelle
            var minuten = dauer % 60; // Rest

            LblAnzeige.Text = $"{dauer} Minuten sind {stunden} Stunden und {minuten} Minuten.";
        }

        private void CmdAusdruck4_Click(object sender, EventArgs e)
        {
            /* 
             * [OPTIONAL]
             * Rechne 3723 Sekunden in Stunden, Minuten und Sekunden um.
             * 
             * Anzeige: 3723 Sekunden sind ... Stunden, ... Minuten und ... Sekunden.
            */
            // 1 Stunde, 2 Minute, 3 Sekunde
            var dauer = 10_000;
            var stunden = dauer / 3600; // 1 Stunde = 3600 Sekunden
            var minuten = dauer / 60 % 60;
            var sekunden = dauer % 60;

            LblAnzeige.Text = $"{dauer} Sekunden sind {stunden} Stunden, {minuten} Minuten und {sekunden} Sekunden.";
        }
    }
}
