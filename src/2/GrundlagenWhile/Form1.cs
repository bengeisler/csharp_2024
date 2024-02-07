// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Random r = new();


        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int summe = 0;
            LblAnzeigen.Text = "";


            while (summe < 20)
            {
                summe += r.Next(1, 7);

                LblAnzeigen.Text += $" {summe}\n";


            }

        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int summe = 30;
            LblAnzeigen.Text = "";


            do
            {
                summe += r.Next(1, 7);

                LblAnzeigen.Text += $" {summe}\n";


            }
            while (summe < 20);
        }   
    }
}
