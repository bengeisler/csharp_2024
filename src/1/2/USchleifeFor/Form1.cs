// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace USchleifeFor
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {

            LblAnzeigen1.Text = "";
            decimal Ergebnis = 0;

            for (decimal i = 35; i >= 20; i -= 2.5M)
            {
                LblAnzeigen1.Text += $"{i}\n";
                Ergebnis += i;
            }

        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {

            LblAnzeigen1.Text = "";
            decimal Ergebnis = 0;
            int Anzahl = 0;

            for (decimal i = 35; i >= 20; i -= 2.5M)
            {
                LblAnzeigen1.Text += $"{i}\n";
               
                Ergebnis += i;
                Anzahl++;


            }
            LblAnzeigen1.Text += $"Summe: {Ergebnis}\n";
            LblAnzeigen1.Text += $"Mittelwert: {Ergebnis / Anzahl}";
        }
    }
}
