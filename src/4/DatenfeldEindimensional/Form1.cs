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

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            int[] werte = [1, 2, 3, 4, 5, 6, 7];

            // Werte in Listbox übernehmen
            // LstWerte.Items.Add(werte[0]);

            //Daniel
            // for (int i = 0; i < werte.Length; i++)
            {
                // LstWerte.Items.Add(werte[i]);

            }
            foreach (int wert in werte)
            {
                LstWerte.Items.Add(wert);

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblAusgabe_Click(object sender, EventArgs e)
        {

        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int[] werte = [1, 2, 3, 4, 5, 6, 7];

            // Auf Bereiche zugreifen
            int[] bereich = werte[1..3];
        }

        private void cmdAnzeigen3_Click(object sender, EventArgs e)

        {
           

            


           
            {
                

            }
        }
    }
}
