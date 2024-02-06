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
            //Schleifenz�hler deklarieren
            int i;

            //LblAnzeigen1.Text zur�cksetzen
            LblAnzeigen.Text = "";

            //for-Schleife
            for (i = 0; i < 10; i++)
            {
                //Schleifenz�hler anzeigen
                LblAnzeigen.Text += $"{i}\n";
            }
        }

        private void BtnAnzeigen2_Click(object sender, EventArgs e)
        {
            int i;

            //LblAnzeigen1.Text zur�cksetzen
            LblAnzeigen2.Text = "";

            //for-Schleife
            for (i = 0; i < 10; i += 2)
            {
                //Schleifenz�hler anzeigen
                LblAnzeigen2.Text += $"{i}\n";
            }
        }

        private void BtnAnzeigen3_Click(object sender, EventArgs e)
        {
            //LblAnzeigen1.Text zur�cksetzen
            LblAnzeigen3.Text = "";

            //for-Schleife
            for (int i = 10; i >= 3; i--)
            {
                //Schleifenz�hler anzeigen
                LblAnzeigen3.Text += $"{i}\n";
            }
        }

        private void BtnAnzeigen4_Click(object sender, EventArgs e)
        {
            //LblAnzeigen1.Text zur�cksetzen
            LblAnzeigen4.Text = "";

            //for-Schleife
            for (double i = 0; i < 5; i+= 0.5)
            {
                //Schleifenz�hler anzeigen
                LblAnzeigen4.Text += $"{i}\n";
            }
        }
    }
}
