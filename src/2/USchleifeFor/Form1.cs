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

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            LblAnzeige1.Text = "";


            for (double i = 35; i >= 20; i -= 2.5)

            {
                LblAnzeige1.Text += $"{i}\n";
            }
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double summe = 0;
            int Anzahl = 0;

            LblAnzeige1.Text = "";

            for (double i = 35; i >= 20; i -= 2.5)
            {
                summe += i;
                Anzahl++;
                

                 LblAnzeige1.Text += $"{i}\n";
                




            }
            LblAnzeige1.Text += $"Summe: {summe}\n";
            LblAnzeige1.Text += $"Mittelwert: {summe / Anzahl}";

        }
    }
}
