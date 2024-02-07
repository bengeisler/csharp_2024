// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenDoWhile
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
            Lblausgabe1.Text = "";

            while (summe < 20)
            {
                summe += r.Next(1, 7);

                Lblausgabe1.Text += $"{summe}\n";

            }

        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int summe = 0;
            Lblausgabe1.Text = "";

            do
            {
                summe += r.Next(1, 7);

                Lblausgabe1.Text += $"{summe}\n";
            }
            while (summe < 20);

        }
    }
}
