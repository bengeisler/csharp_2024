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

        private void BtnAnzeigen1_Click(object sender, EventArgs e)
        {

            LblAnzeigen.Text = "";

            for (decimal i = 35; i >= 20; i -= 2.5M)
            {
                LblAnzeigen.Text += $"{i}\n";
            }
        }

        private void BtnAnzeigen2_Click(object sender, EventArgs e)
        {
            LblAnzeigen.Text = "";

            decimal ergebniss = 0;
            int anzahl = 0;

            for (decimal i = 35; i >= 20; i -= 2.5M)
            {
                LblAnzeigen.Text += $"{i}\n";
                ergebniss += i;
                anzahl++;
            }

            LblAnzeigen.Text += $"Summe: {ergebniss}\n";
            LblAnzeigen.Text += $"Mittelwert: {ergebniss / anzahl}";




        }
    }
}
