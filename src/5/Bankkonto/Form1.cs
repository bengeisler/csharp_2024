// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Bankkonto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Konto _konto = new();

        private void CmdAuszahlen_Click(object sender, EventArgs e)
        {
            decimal betrag = Convert.ToDecimal(TxtAnzeige.Text);
            _konto.Auszahlen(betrag);
            _konto.Kontostand
            Kontostand =- betrag;
            return Kontostand;



        }

        private void CmdKontostand_Click(object sender, EventArgs e)
        {

            TxtAnzeige.Text = _konto.KontostandAnzeigen();

        }

        private void CmdEinzahlen_Click(object sender, EventArgs e)
        {
            try
            {
                decimal betrag = Convert.ToDecimal(TxtAnzeige.Text);
                _konto.Einzahlen(betrag);
                TxtAnzeige.Text = _konto.KontostandAnzeigen();
            }
            catch
            {
                MessageBox.Show("Bitte gültige Zahl eingeben");
               
            }
            




        }

        private void CmdKontoauszugDrucken_Click(object sender, EventArgs e)
        {

        }

        
            
            
           
            
            
            
        }
    }

