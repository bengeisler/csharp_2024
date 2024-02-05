// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UOperatorenVergleich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeige1_Click(object sender, EventArgs e)
        {
            double Ergebnis;

            Ergebnis = 3 * -2.5 + 4 * 2;

            LblAnzeigen.Text = Ergebnis.ToString();

        }

        private void cmdAnzeige2_Click(object sender, EventArgs e)
        {
            double Ergebnis;

            Ergebnis = 3 * (-2.5 + 4) * 2;

            LblAnzeigen.Text = Ergebnis.ToString();
        }

        private void cmdAnzeigen3_Click(object sender, EventArgs e)
        {
            double Stunden;
            double Minuten;

            Stunden = 325 / 60;
            Minuten = 325 % 60;

            LblAnzeigen.Text = $"325 Minuten sind {Stunden} Stunden und {Minuten} Minuten.";
        }

        private void cmdAnzeigen4_Click(object sender, EventArgs e)
        {
            double Stunden;
            double Minuten;
            double Sekunden;
            int Eingabe = 3661;

            Stunden = Eingabe / 60 / 60;
            Minuten = Stunden / 60 % 60;
            Sekunden = Eingabe % 60;
            
            
          

            LblAnzeigen.Text = $"{Eingabe} Sekunden sind {Stunden} Stunden, {Minuten} Minuten und {Sekunden} Sekunde.";
        }
    }
}
