// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.Eventing.Reader;

namespace USteuerbetrag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CmdBerechnen_Click(object sender, EventArgs e)
        {
            var Gehalt = Convert.ToInt32(txtGehalt.Text);
            if (Gehalt < 12000)
            {

                LblSteuerbetrag.Text = $"{Gehalt * 0.12}";
            }
            else if (Gehalt > 12000 && Gehalt < 20000)

                LblSteuerbetrag.Text = $"{Gehalt * 0.15}";


            else if (Gehalt > 20001 && Gehalt < 30000)
                LblSteuerbetrag.Text = $"{Gehalt * 0.20}";
            else
                LblSteuerbetrag.Text = $"{Gehalt * 0.25}";
        }

        private void CmdSwitch_Click(object sender, EventArgs e)
        {
            {
                var Gehalt = Convert.ToInt32(txtGehalt.Text);
                switch(Gehalt)

                {
                    case <= 12000;
                        break;
                        LblSteuerbetrag.Text = $"{Gehalt * 0.12}";
                        break;
                    case >12000 and >20000;
                        LblSteuerbetrag.Text = $"{Gehalt * 0.15}";
                        break;
                    case >20000 and <30000 = ;
                        LblSteuerbetrag.Text = $"{Gehalt * 0.20}";
                        break;
                    default:
                        break;






                };
                Lblausgabe.Text = $"Wert: {x},{bewertung}";
            }
    }
}
