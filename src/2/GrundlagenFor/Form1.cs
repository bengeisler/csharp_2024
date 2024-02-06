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

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            // Schleifenzähler deklarieren
            int i;

            // LblAnzeigen1.Text zurücksetzen
            LblAnzeigen1.Text = "";

            // for-Schleife
            for (i = 0; i < 10; i++)
            {
                // Schleifenzähler anzeigen
                LblAnzeigen1.Text += $"{i}\n";
            }
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            // Schleifenzähler deklarieren
            int i;

            // LblAnzeigen2.Text zurücksetzen
            LblAnzeigen2.Text = "";

            // for-Schleife
            //
            // i = 0  : Initialisierung der Schleifenvariable. i startet bei 0
            // i < 10 : Schleifenbedingung: Solange diese Bedingung true ist, wird die
            //          Schleife ausgeführt. Also: solange i < 10 ist
            // i += 2 : Inkrement der Schleifenvariable. i wird NACH jedem Durchlauf der
            //          Schleife (hier) um 2 erhöht
            for (i = 0; i < 10; i += 2)
            { // < Innerhalb der geschweiften Klammern ist der Schleifenkörper.
              //   Hier stehen die Befehle, die mit jedem Schleifendurchlauf ausgeführt werden

                // Schleifenzähler anzeigen
                LblAnzeigen2.Text += $"{i}\n";
            }
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            // LblAnzeigen3.Text zurücksetzen
            LblAnzeigen3.Text = "";

            // for-Schleife: Von 10 rückwärts bis 3 zählen
            for (int i = 10; i >= 3; i--)
            {
                LblAnzeigen3.Text += $"{i}\n";
            }
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            LblAnzeigen4.Text = "";

            for (double i = 0; i < 5; i += 0.5)
            {
                LblAnzeigen4.Text += $"{i}\n";
            }
        }

        private void CmdAnzeigen5_Click(object sender, EventArgs e)
        {
            LblAnzeigen5.Text = "";

            for (int i = 0; i < 10; i++)
            {
                if (i == 7) continue;
                if (i == 8) break;
                LblAnzeigen5.Text += $"{i}\n";
            }
        }
    }
}
