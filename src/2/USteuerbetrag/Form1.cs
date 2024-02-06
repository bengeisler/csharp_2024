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

        private void CmdBerechnenIfElse_Click(object sender, EventArgs e)
        {
            decimal gehalt = Convert.ToDecimal(TxtGehalt.Text);
            decimal steuersatz;
            decimal steuerbetrag;

            // Steuersatz ist abh�ngig vom Gehalt
            if (gehalt <= 12_000)
            {
                steuersatz = 0.12M;
            }
            else if (gehalt > 12_000 && gehalt <= 20_000)
            {
                steuersatz = 0.15M;
            }
            else if (gehalt > 20_000 && gehalt <= 30_000)
            {
                steuersatz = 0.20M;
            }
            else
            {
                steuersatz = 0.25M;
            }

            // Steuerbetrag = Gehalt * Steuersatz
            steuerbetrag = gehalt * steuersatz;

            // Steuerbetrag ausgeben
            LblSteuerbetrag.Text = $"Steuerbetrag: {steuerbetrag}";

            // Falls nur eine Anweisung nach dem if oder else ausgef�hrt werden soll,
            // k�nnen die geschweiften Klammern auch weggelassen werden:

            // if (gehalt <= 12_000) steuersatz = 0.12M;
            // else if (gehalt > 12_000 && gehalt <= 20_000) steuersatz = 0.15M;
            // else if (gehalt > 20_000 && gehalt <= 30_000) steuersatz = 0.20M;
            // else steuersatz = 0.25M;

        }

        private void cmdSwitch_Click(object sender, EventArgs e)
        {
            double gehalt = Convert.ToDouble(TxtGehalt.Text);
            LblSteuerbetrag.Text = "Steuerbetrag: " + gehalt / 100
                * gehalt switch
                {
                    <= 12000 => 12,
                    <= 20000 => 15,
                    <= 30000 => 20,
                    _ => 25

                };

        }
    }
}
