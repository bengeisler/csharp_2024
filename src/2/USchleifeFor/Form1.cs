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

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            List<double> werte = [];

            LblAnzeige.Text = "";

            for (double i = 35; i >= 20; i -= 2.5)
            {
                LblAnzeige.Text += $"{i}\n";
                werte.Add(i);
            }

            LblAnzeige.Text += $"Summe: {werte.Sum()}\n";
            LblAnzeige.Text += $"Mittelwert: {werte.Average()}";
        }

        private void LblAnzeige_Click(object sender, EventArgs e)
        {

        }
    }
}
