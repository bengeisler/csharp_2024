// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace DatenfeldEindimensional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdButton1_Click(object sender, EventArgs e)
        {
            int[] werte = [1, 2, 3, 4, 5, 6, 7];

            foreach (int wert in werte)
            {
                LstWerte.Items.Add(wert);
            }


        }

        private void LbAnzeige2_Click(object sender, EventArgs e)
        {
            int[] werte = [1, 2, 3, 4, 5, 6, 7];
            int[] bereich = werte[^1..^3];
        }

        private void CmdAnzeige3_Click(object sender, EventArgs e)
        {
            LstWerte.Items.Clear();

            int[] werte = [800, 2, 3, 400, 5, 6, 700];

            Array.Sort(werte);
            Array.Reverse(werte);


            foreach (int wert in werte)
            {
                LstWerte.Items.Add(wert);
            }



        }

    }
}
