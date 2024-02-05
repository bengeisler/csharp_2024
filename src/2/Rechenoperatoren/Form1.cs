// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Rechenoperatoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double ergA = 12 - 3, ergB = 4 * 2.5;
            string ergebnis;
            if (ergA >= ergB)
            {
                ergebnis = "true";

            }
            else
            {
                ergebnis = "false;";
            }
            LblAnzeige.Text = $"12-3>=4*2.5  is  {ergebnis}\n{ergA} >= {ergB}";

        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double x = 3 * -2.5 + 4 * 2;
            LblAnzeige.Text = $"{x}";


        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            var dauer = 325;
            var stunden = dauer / 60;
            var minuten = dauer % 60;
            LblAnzeige.Text = $"{dauer} Minuten sind {stunden} Stunden welche {minuten} Minuten sind";
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            var dauer = 3661;
            var stunden = dauer / 3600;
            var minuten = dauer / 60 % 60;
            var sekunden = dauer % 60;
            LblAnzeige.Text = $"{dauer} Sekunden sind \n{stunden} Stunden \n{minuten} Minuten \n{sekunden} Sekunden";


        }
    }
}
