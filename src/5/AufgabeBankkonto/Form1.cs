// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace AufgabeBankkonto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private Konto _konto = new();


        private void cmdEinzahlen_Click(object sender, EventArgs e)
        {
              decimal betrag = Convert.ToDecimal(txtEingabe.Text);
            _konto.Einzahlen(10);












        }

        private void cmdKontostand_Click(object sender, EventArgs e)
        {
            txtAnzeige.Text = _konto.KontostandAnzeigen();

        }

        private void cmdAuszahlen_Click(object sender, EventArgs e)
        {
            _konto.Auszahlen(5);


        }
    }
}
