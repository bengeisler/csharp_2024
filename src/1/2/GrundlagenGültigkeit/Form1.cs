// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenGültigkeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Globale Variable
        private int Mx = 0;
        // private: Sichtbarkeit der Variable (nur innerhalb der Klasse)
        // Mx: Name der Variable
        // = 0: Initialisierung mit dem Wert 0

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            // Lokale Variable
            // - nur gültig innerhalb dieser Funktion
            // - der gleiche Name kann nicht mehrfach deklariert werden
            int x = 0;

            Mx++;

            x++;

            //LblAnzeige.Text = x.ToString();

            // Alternativ:
            LblAnzeige.Text = $"x:{x}, Mx:{Mx}";
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int x = 0;

            Mx++;



            LblAnzeige.Text = $"x: {x}, Mx: {Mx}";  
        }
    }
}
