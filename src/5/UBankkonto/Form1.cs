// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UBankkonto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private Konto _konto = new();


        private void CmdEinzahlen_Click(object sender, EventArgs e)
        {
            decimal var = Convert.ToDecimal(TxtBeitrag.Text);

            _konto.Einzahlen(10);

        }

        private void CmdAuszahlen_Click(object sender, EventArgs e)
        {
            decimal var  = Convert.ToDecimal(TxtBeitrag.Text);
            _konto.AusZahlen(9);

            TxtBeitrag.Text = _konto.ToString();


        }

        private void CmdKontostand_Click(object sender, EventArgs e)
        {
            
            TxtBeitrag.Text = _konto.ToString();

        }

    }
}
