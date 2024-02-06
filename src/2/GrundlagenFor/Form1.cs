// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAnzeigen1_Click(object sender, EventArgs e)
        {
            //Schleifenzähler deklarieren
            int i;

            //LblAnzeigen1.Text zurücksetzen
            LblAnzeigen.Text = "";

            //for-Schleife
            for (i = 0; i < 10; i++)
            {
                //Schleifenzähler anzeigen
                LblAnzeigen.Text += $"{i}\n";
            }
        }

        private void BtnAnzeigen2_Click(object sender, EventArgs e)
        {
            int i;

            //LblAnzeigen1.Text zurücksetzen
            LblAnzeigen2.Text = "";

            //for-Schleife
            for (i = 0; i < 10; i += 2)
            {
                //Schleifenzähler anzeigen
                LblAnzeigen2.Text += $"{i}\n";
            }
        }

        private void BtnAnzeigen3_Click(object sender, EventArgs e)
        {
            //LblAnzeigen1.Text zurücksetzen
            LblAnzeigen3.Text = "";

            //for-Schleife
            for (int i = 10; i >= 3; i--)
            {
                //Schleifenzähler anzeigen
                LblAnzeigen3.Text += $"{i}\n";
            }
        }

        private void BtnAnzeigen4_Click(object sender, EventArgs e)
        {
            //LblAnzeigen1.Text zurücksetzen
            LblAnzeigen4.Text = "";

            //for-Schleife
            for (double i = 0; i < 5; i+= 0.5)
            {
                //Schleifenzähler anzeigen
                LblAnzeigen4.Text += $"{i}\n";
            }
        }
    }
}
