// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenFormulare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAufrufen_Click(object sender, EventArgs e)
        {
            // Unterformular 2 Aufrufen
            // - Neues Objekt vom Typ "Form2" erzeugen
            Form2 unterFormlar = new();

            //Eigentschaft zuweisen
            unterFormlar.AnzeigeText = txtEingabe.Text;

            // -Unterformular anzeigen
            unterFormlar.ShowDialog();




        }


    }   

        
    }
}
