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
            else if (eingabe >20000)
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
    }
}
