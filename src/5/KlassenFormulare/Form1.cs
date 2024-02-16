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

        // Eigenschaft
        public bool istOk;

        private void CmdAufrufen_Click(object sender, EventArgs e)
        {

            // Unterformular anzeigen
            // - Neues Objekt vom Typ "Form2" erzeugen
            Form2 unterformular = new();

            // - Eigenschaft zuweisen
            unterformular.AnzeigeText = TxtEingabe.Text;
            unterformular.Hauptformular = this;
            
            // - Unterformular anzeigen
            var ergebnis = unterformular.ShowDialog();

            // Rückgaben aus Formular 2 verarbeiten
            if (ergebnis == DialogResult.OK)
            {
                ChkOk.Checked = istOk;
            }
            
        }
    }
}
