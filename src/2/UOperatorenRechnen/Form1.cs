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

        private void CmdAusdruck1_Click(object sender, EventArgs e)
        {
            double Ergebnis;

            Ergebnis = 3 * -2.5 + 4 * 2;

            LabelAnzeige1.Text = Ergebnis.ToString();




        }

        private void CmdAusdruck2_Click(object sender, EventArgs e)
        {

            double Ergebnis;
            Ergebnis = 3 * (-2.5 + 4) * 2;


            LabelAnzeige1.Text = Ergebnis.ToString();

        }

        private void CmdAusdruck3_Click(object sender, EventArgs e)
        {
            double stunden;
            double minuten;

            stunden = 325 / 60;
            minuten = 325 % 60;

            LabelAnzeige1.Text = $"325 Minuten sind {stunden} stunden und {minuten} minuten";

           


        }
    }
}
