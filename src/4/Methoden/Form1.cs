// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Methoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnzeigen1_Click(object sender, EventArgs e)
        {
            Hallo();
        }

        private void Hallo()
        {
            LblAnzeigen.Text = "Hallo Welt!";
        }

        private void btnAnzeigen2_Click(object sender, EventArgs e)
        {
            ZeigeMaximum(10, 20);
        }

        private void ZeigeMaximum(int x, int y)
        {
            if (x > y)
            {
                LblAnzeigen.Text = $"Maximum: {x}";
            }
            else
            {
                LblAnzeigen.Text = $"Maximum: {y}";
            }
        }

        private void btnAnzeigen3_Click(object sender, EventArgs e)
        {
            int ergebnis = Addiere(1, 2);

            LblAnzeigen.Text = $"Ergebnis: {ergebnis}";

        }


        private int Addiere(int x, int y)
        {
            //return: Wert zurückgeben & Methode wird verlassen
            return x + y;
        }

        private void btnAnzeigen4_Click(object sender, EventArgs e)
        {
            int ergebnis = Addiere2(1, 3);
            LblAnzeigen.Text = $"Ergebnis: {ergebnis}";
        }

        private int Addiere2(int x, int y) => x + y;

        private void btnAnzeigen5_Click(object sender, EventArgs e)
        {
            int Addireren3(int x, int y) => x + y;

            LblAnzeigen.Text = $"Ergbnis 1: {Addireren3(1, 2)}\n";
            LblAnzeigen.Text += $"Ergebnis 1: {Addireren3(3, 4)}";
        }

        private void btnAnzeigen6_Click(object sender, EventArgs e)
        {
            var Addiere4 = (int x, int y) => x + y;

            LblAnzeigen.Text = $"Ergebnis 1: {Addiere4(1, 2)}\n";
            LblAnzeigen.Text = $"Ergebnis 2: {Addiere4(3, 4)}\n";

        }

        private void btnAnzeigen7_Click(object sender, EventArgs e)
        {
            int[] werte = [0, 2, 3, 40, 50];

            bool istPositiv(int x) => x > 0;
            bool ergebnis1 = Array.TrueForAll(werte, istPositiv);

            bool ergebnis2 = Array.TrueForAll(werte, x => x > 0);

            int wert = Array.Find(werte, x => x >= 4);

        }

        private void btnAnzeigen8_Click(object sender, EventArgs e)
        {
            bool stringInInt(string s, out int ergebnis)
            {
                
                try
                {
                    ergebnis = Convert.ToInt32(s);
                    return true;
                }
                catch
                {
                    ergebnis = 0;
                    return false;
                }
                
            }
            bool erfolgreich = stringInInt("hjk", out int ergebnis);

            if (erfolgreich) LblAnzeigen.Text = $"{ergebnis}";
            else LblAnzeigen.Text = "Fehler!";

        }
    }
}
