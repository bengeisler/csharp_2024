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

        private void button1_Click(object sender, EventArgs e)
        {
            double i;

            LblAnzeigen1.Text = "";

            for (i = 35; i > 20; i -= 2.5)
            {

                LblAnzeigen1.Text += $"{i}\n";
            }
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double i;
            double summe;
            summe = 0;
            int zaehler;
            zaehler = 0;

            LblAnzeigen1.Text = "";

            for (i = 35; i >= 20; i -= 2.5)
            {
                zaehler++;
                LblAnzeigen1.Text += $"{i}\n";
                summe += i;
            }
            LblAnzeigen1.Text += $"Summe: {summe}\n";
            LblAnzeigen1.Text += $"Mittelwert: {summe/zaehler}";

        }
    }
}
