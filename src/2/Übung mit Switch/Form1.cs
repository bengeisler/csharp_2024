// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Übung_mit_Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            decimal gehalt = (Numtext.Value);
            decimal steuersatz = 0;
            decimal steuerbetrag = 0;
            if (gehalt <= 12000)
            {
                steuersatz = 0.12M;
            }
            else if (gehalt > 12000 && gehalt <= 20000)
            {
                steuersatz = 0.15M;
            }
            else if (gehalt > 20000 && gehalt <= 30000)
            {
                steuersatz = 0.20M;
            }
            else if (gehalt > 30000)
            {
                steuersatz = 0.25M;
            }
            else
                LblAnzeige1.Text = "ERROR";
            steuerbetrag = gehalt * steuersatz;
            LblAnzeige1.Text = $"Steuerbetrag: {steuerbetrag}";
        }

        private void Numtext_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
