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

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            // Schleifenz�hler deklarieren
            int i;

            //LblAnzeigen1.Text zur�cksetzen
            LblAnzeigen1.Text = "";

            // for-Schleife
            for (i = 0; i < 10; i++)
            {
                // Schleifenz�hler anzeigen
                LblAnzeigen1.Text += $"{i}\n";
            }
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            // Schleifenz�hler deklarieren
            int i;

            //LblAnzeigen1.Text zur�cksetzen
            LblAnzeigen2.Text = "";

            // for-Schleife
            for (i = 0; i < 10; i += 2)
            {
                // Schleifenz�hler anzeigen
                LblAnzeigen2.Text += $"{i}\n";
            }
        }

        private void cmdAnzeigen3_Click(object sender, EventArgs e)
        {
            // Schleifenz�hler deklarieren
            int i;

            //LblAnzeigen1.Text zur�cksetzen
            LblAnzeigen3.Text = "";

            // for-Schleife: Von 10 r�ckw�rts bis 3 z�hlen
            for (i = 10; i >= 3; i--)
            {
                // Schleifenz�hler anzeigen
                LblAnzeigen3.Text += $"{i}\n";
            }
        }

        private void cmdAnzeigen4_Click(object sender, EventArgs e)
        {
   
            LblAnzeigen4.Text = "";

            for (double i = 0; i < 5; i += 0.5)
            {
                // Schleifenz�hler anzeigen
                LblAnzeigen4.Text += $"{i}\n";
            }
        }
    }
}
