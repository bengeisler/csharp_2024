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

        private void CmdIfElse_Click(object sender, EventArgs e)
        {


            double wert = Convert.ToDouble(TxtEingabe.Text);





            if (TxtEingabe.Value >= 0 && TxtEingabe.Value <= 12_000)
            {
                LblAnzeigen.Text = $"Steuerbetrag: {wert * 0.12}";

            }

            if (TxtEingabe.Value > 12_000 && TxtEingabe.Value <= 20_000)
            {
                LblAnzeigen.Text = $"Steuerbetrag: {wert * 0.15}";
            }

            if (TxtEingabe.Value > 20_000 && TxtEingabe.Value <= 30_000)
            {
                LblAnzeigen.Text = $"Steuerbetrag: {wert * 0.20}";
            }

            if (TxtEingabe.Value > 30_000)
            {
                LblAnzeigen.Text = $"Steuerbetrag: {wert * 0.25}";
            }




        }

        private void CmdSwitch_Click(object sender, EventArgs e)
        {
            
            var Gehalt = Convert.ToDecimal(TxtEingabe.Text);

            

            
            decimal Steuersatz = Gehalt switch
            {
                <= 12_000 => 0.12M,
                <= 20_000 => 0.15M,
                <= 30_000 => 0.20M,
                > 30_000 => 0.25M
            };       

            LblAnzeigen.Text = $"Steuerbetrag: {Steuersatz * Gehalt}";
        }
    }
}
