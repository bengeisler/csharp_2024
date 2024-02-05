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

        private void BtnRechnung1_Click(object sender, EventArgs e)
        {
            double Ergebniss;

            Ergebniss = 3 * -2.5 + 4 * 2;

            LblAnzeige.Text = Ergebniss.ToString();
        }

        private void BtnRechnung2_Click(object sender, EventArgs e)
        {
            double Ergebniss;

            Ergebniss = 3 * (-2.5 + 4) * 2;

            LblAnzeige.Text = Ergebniss.ToString();

        }

        private void BtnRechnung3_Click(object sender, EventArgs e)
        {
            double Minuten;
            double Stunden;

            Stunden = 325 / 60;
            Minuten = 325 % 60;

            LblAnzeige.Text = $"325 Minuten sind {Stunden} Stunden\nund {Minuten} Minuten.";

        }

        private void BtnRechnung4_Click(object sender, EventArgs e)
        {
            int Stunden;
            int Minuten;
            int MinutenRest;
            int Sekunden;

            int Eingabe = 3661;

            Stunden = Eingabe / 60 / 60;
            Minuten = Eingabe / 60 % 60;
            Sekunden = Eingabe % 60;

            LblAnzeige.Text = $"{Eingabe} Minuten sind {Stunden} Stunden,\n{Minuten} Minuten und {Sekunden} Sekunden.";

        }
    }
}
