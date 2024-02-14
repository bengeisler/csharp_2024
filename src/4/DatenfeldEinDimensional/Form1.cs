// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace DatenfeldEinDimensional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            LstWerte.Items.Clear();

            int[] werte = [1, 2, 3, 4, 5, 6, 7];

            foreach (int wert in werte)
            {
                LstWerte.Items.Add(wert);

            }
        }

        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {
            int[] werte = [1, 2, 3, 4, 5, 6, 7];

            int[] bereich = werte[1..3];
        }

        private void cmdAnzeigen3_Click(object sender, EventArgs e)
        {
            LstWerte.Items.Clear();

            int[] werte = [341, 242, 31, 4664, 5345, 90889786, 347];

            Array.Sort(werte);

            

            foreach (int wert in werte)
            {
                LstWerte.Items.Add(wert);
                
            }
        }
    }
}
