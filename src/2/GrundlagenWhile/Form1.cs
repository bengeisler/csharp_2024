// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Zufallszahlengenerator
        private readonly Random r = new();

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int summe = 0;
            LblAnzeige.Text = "";

            while (summe < 20)
            {
                // Summe um Zufallszahl zwischen 1 und 6 erhöhen
                summe += r.Next(1, 7);

                LblAnzeige.Text += $"{summe}\n";
            }
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int summe = 0;
            LblAnzeige.Text = "";

            do
            {
                // Summe um Zufallszahl zwischen 1 und 6 erhöhen
                summe += r.Next(1, 7);

                LblAnzeige.Text += $"{summe}\n";
            }
            while (summe < 20);
        }
    }
}
