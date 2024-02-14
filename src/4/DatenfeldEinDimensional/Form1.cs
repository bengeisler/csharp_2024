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

        private void CmdButton1_Click(object sender, EventArgs e)
        {
            LstBox.Items.Clear();
            //Datenfeld deklarieren & initialisieren
            int[] werte = [1, 2, 3, 4, 5, 6, 7];
            // Daten in Listbox übernehmen
            //LstBox.Items.Add(werte[0]);
            //LstBox.Items.Add(werte[1]);

            // for (int i= 0; i<wert.Length; i++;
            // {
            // LstBox.Items.Add(werte[i]);
            // }

            foreach (int wert in werte)
            {
                LstBox.Items.Add(wert);
            }
            //Zugriff auf elemente a´ßerhalb des bereichs wirft einen fehler
            // z.B LstBox.Items.Add(werte[20]); <-----> IndexOutOfTheRange

        }

        private void CmdButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdButton3_Click(object sender, EventArgs e)
        {
            LstBox.Items.Clear();
            int[] werte = [1, 2, 3, 4, 5, 6, 7];

            //auf Bereiche Zugreifen
            int[] bereich = werte[1..3];
            
        }

        private void CmdButton4_Click(object sender, EventArgs e)
        {
            LstBox.Items.Clear();
            int[] werte = [878, -1, 34, 999, 1, 0, 7];
            Array.Sort(werte);
            Array.Reverse(werte);
            label1.Text = $"{Array.IndexOf(werte, -1)}";
            foreach (int wert in werte)
            {
                LstBox.Items.Add(wert);
            }
        }

        private void CmdButton5_Click(object sender, EventArgs e)
        {
            LstBox.Items.Clear();
        }
    }
}
