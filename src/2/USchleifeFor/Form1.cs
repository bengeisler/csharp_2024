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
            LblAnzeige.Text = "";
            double summe = 0;
            int zaehler = 0;

            for (double i = 35; i >= 20; i -= 2.5)
            {
                LblAnzeige.Text += $"{i}\n";
                summe += i;
                zaehler++;
            }

            LblAnzeige.Text += $"Summe: {summe}\n";
            LblAnzeige.Text += $"Mittelwert: {summe / zaehler}\n";
        }

        private void LblAnzeige_Click(object sender, EventArgs e)
        {

        }
    }
}
