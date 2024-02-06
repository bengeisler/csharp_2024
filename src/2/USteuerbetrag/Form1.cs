// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.Eventing.Reader;

namespace USteuerbetrag
{
    public partial class Form1 : Form
    {
        private const int V = 30000;

        public Form1()
        {
            InitializeComponent();
        }

        private void CmdBerechnen_Click(object sender, EventArgs e)
        {
            var gehalt = Convert.ToInt32(TxtGehalt.Text);
            if
                (gehalt <= 12000)
            {
                LblSteuer.Text = $"{gehalt * 0.12}";

            }
            else if (gehalt > 12000 && gehalt < 20000)
            {
                LblSteuer.Text = $"{gehalt * 0.15}";
            }
            else if (gehalt > 20000 && gehalt <= 30000)

            {
                LblSteuer.Text = $"{gehalt * 0.20}";
            }
            else
            {
                LblSteuer.Text = $"{gehalt * 0.25}";
            }




        }

        private void CmdButtonswitch_Click(object sender, EventArgs e)
        {
            var gehalt = Convert.ToInt32(TxtGehalt.Text);

            switch (gehalt)
            {
                case <= 12000:
                    LblSteuer.Text = $"{gehalt * 0.12}";
                    break;
                case > 12000 and <=20000:
                    LblSteuer.Text = $"{gehalt * 0.15}";
                    break;
                case > 20000 and < 30000:
                    LblSteuer.Text = $"{gehalt * 0.20}";
                    break;
                default:
                    LblSteuer.Text = $"{gehalt * 0.25}";
                    break;  

            };

        }
    }
}
