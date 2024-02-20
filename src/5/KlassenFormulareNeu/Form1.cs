// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenFormulareNeu
{
    public partial class Hauptformular : Form
    {
        public Hauptformular()
        {
            InitializeComponent();

        }
        // Eigenschaft OK
        public bool istOK;

        private void Cmd_Click(object sender, EventArgs e)
        {
            Form2 unterformular = new();

            // Eigenschaft zuweisen
            unterformular.AnzeigeText = TxtEingabe.Text;
            unterformular.Hauptformular = this;

            // Unterformular
            var ergebnis = unterformular.ShowDialog();

            // Rückgabe aus Formular 2 verarbeiten
        }

        {
            chkOK.Checked = istOK;
        }    



    }
}
