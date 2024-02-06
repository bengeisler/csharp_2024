// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace USteuerbetrag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBerechnung_Click(object sender, EventArgs e)
        {

            decimal ausgabe;

            decimal eingabe = Convert.ToDecimal(TxtEingabe.Text);

            if (eingabe > 30000)
            {
                ausgabe = eingabe * 0.25M;
            }
            else if (eingabe > 20000)
            {
                ausgabe = eingabe * 0.20M;
            }
            else if (eingabe > 12000)
            {
                ausgabe = eingabe * 0.15M;
            }
            else
            {
                ausgabe = eingabe * 0.12M;
            }

            LblAnzeige1.Text = $"Steuerbetrag: {ausgabe}";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal eingabe = Convert.ToDecimal(TxtEingabe.Text);
            decimal wert;
            decimal ausgabe;

            switch (eingabe)
            {
                case > 30000:
                    wert = 0.25M;
                    break;
                case > 20000:
                    wert = 0.20M;
                    break;
                case > 12000:
                    wert = 0.15M;
                    break;
                case < 30000:
                    wert = 0.12M;
                    break;
            }
            ausgabe = eingabe * wert;

            LblAnzeige1.Text = $"Steuerbetrag: {ausgabe}";
        }
    }
}
