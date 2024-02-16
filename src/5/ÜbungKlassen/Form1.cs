// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace ÜbungKlassen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Konto _konto = new();


        private void CmdButtonEin_Click(object sender, EventArgs e)
        {
            try
            {
            decimal betrag = Convert.ToDecimal(TxtBox.Text);
            _konto.Einzahlen(betrag);
            }
            catch
            {
                MessageBox.Show("NUR Zahlen Eingeben!");
            }

            
        }

        private void CmdButtonAus_Click(object sender, EventArgs e)
        {
            try
            {
                decimal betrag = Convert.ToDecimal(TxtBox.Text);
                _konto.Auszahlen(betrag);
            }
            catch
            {
                MessageBox.Show("NUR Zahlen Eingeben!");
            }
        }

        private void CmdButtonStand_Click(object sender, EventArgs e)
        {
            LblAnzeige2.Text = _konto.KontostandAnzeigen();
        }

        private void CmdButtonC_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
