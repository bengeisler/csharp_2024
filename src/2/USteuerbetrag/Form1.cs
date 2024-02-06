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

        private void CmdRechnen_Click(object sender, EventArgs e)
        {

            decimal gehalt = Convert.ToDecimal(TxtGehalt.Text);
            decimal steuersatz = 0;
            decimal steuerbetrag = 0;

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

            steuerbetrag = gehalt * steuersatz;

                LblSteuerbetrag.Text = $"Steuerbetrag: {steuerbetrag}";













        }

            
           
            
                

            
        
    }
}
