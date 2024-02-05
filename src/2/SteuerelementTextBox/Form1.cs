// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAnzeige_Click(object sender, EventArgs e)
        {
            LblAusgabe.Text = TxtEingabe.Text;
        }

        private void BtnRechnen_Click(object sender, EventArgs e)
        {
            double wert;
            wert = Convert.ToDouble(TxtEingabe.Text);
            wert *= 2;



            LblAusgabe.Text = $"Ergebnis: {wert.ToString()}";


            //Direkte berechnung in der ausgabe:
            //LblAusgabe.Text = (wert * 2).ToString();
        }
    }
}
