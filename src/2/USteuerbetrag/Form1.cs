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

            // Steuersatz ist abhängig vom Gehalt
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

            // Falls nur eine Anweisung nach dem if oder else ausgeführt werden soll,
            // können die geschweiften Klammern auch weggelassen werden:

            // if (gehalt <= 12_000) steuersatz = 0.12M;
            // else if (gehalt > 12_000 && gehalt <= 20_000) steuersatz = 0.15M;
            // else if (gehalt > 20_000 && gehalt <= 30_000) steuersatz = 0.20M;
            // else steuersatz = 0.25M;

        }

        private void CmdBerechnenMitSwitch_Click(object sender, EventArgs e)
        {
            var gehalt = Convert.ToDecimal(TxtGehalt.Text);
            decimal steuersatz;
            decimal steuerbetrag;

            steuersatz = gehalt switch
            {
                <= 12_000 => 0.12M,
                <= 20_000 => 0.15M,
                <= 30_000 => 0.20M,
                _ => 0.25M
            };

            // Steuerbetrag = Gehalt * Steuersatz
            steuerbetrag = gehalt * steuersatz;

            // Steuerbetrag ausgeben
            LblSteuerbetrag.Text = $"Steuerbetrag: {steuerbetrag}";
        }
    }
}
