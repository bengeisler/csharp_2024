// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UBankkonto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            reset();
        }
        private Konto _konto = new();
        private void btnEinzahlen_Click(object sender, EventArgs e)
        {
            decimal vareingabe = Convert.ToDecimal(txtEingabe.Text);

            _konto.Einzahlen(vareingabe);

        }

        private void btnAuszahlen_Click(object sender, EventArgs e)
        {
            decimal vareingabe = Convert.ToDecimal(txtEingabe.Text);

            _konto.Auzahlen(vareingabe);
            txtEingabe.Text = _konto.ToString();
        }

        private void btnKontostand_Click(object sender, EventArgs e)
        {
            txtEingabe.Text = _konto.ToString();
        }


        private void reset()
        {
            lblAnzeigen1.Text = "";
        }

        private void btnKontoauszugdrucken_Click(object sender, EventArgs e)
        {
            
            lblAnzeigen1.Text += $"{_konto.Aufzählung()}\n";
        }
    }
}
