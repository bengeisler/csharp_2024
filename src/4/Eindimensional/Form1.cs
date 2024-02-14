// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Eindimensional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnzeigen1_Click(object sender, EventArgs e)
        {
            lstWerte.Items.Clear();

            int[] werte = [1, 2, 3, 4, 5, 6, 7,];

            //Werte in ListBox übernehmen
            //lstWerte.Items.Add(werte[0]);
            //lstWerte.Items.Add(werte[1]);

            foreach (int wert in werte)
            {
                lstWerte.Items.Add(wert);
            }

        }

        private void btnAnzeigen2_Click(object sender, EventArgs e)
        {
            int[] werte = [1, 2, 3, 4, 5, 6, 7,];

            int[] bereich = werte[1..3];
        }

        private void btnAnzeigen3_Click(object sender, EventArgs e)
        {
            int[] werte = [878, 1, -1, 34, 999, 0, 7,];

            Array.Sort(werte);
            Array.Reverse(werte);

            foreach(int wert in werte)
            {
                lstWerte.Items.Add(wert);
            }
            
        }
    }
}
