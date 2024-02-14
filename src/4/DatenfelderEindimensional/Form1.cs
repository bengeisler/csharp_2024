// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace DatenfelderEindimensional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int[] werte = [1, 2, 3, 4, 5, 6, 7];
            LstWerte.Items.Add(werte[0]);
            foreach (int wert in werte) ;
            LstWerte.Items.Add(wert);

        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int[] werte = [1, 2, 3, 4, 5, 6, 7];

            int[] bereich = werte[1..3];

        }

        private void CmdAnzeige3_Click(object sender, EventArgs e)
        {
            int[] werte = [878, -1, 34, 999, 1, 0, 7];
            Array.Sort(werte);
            Array.Reverse(werte);
            LblAusgabe.Text = $"{Array.IndexOf(werte, -500}";

            foreach (int wert in werte) 
            {
                LstWerte.Items.Add(wert);

            }
        }
}
