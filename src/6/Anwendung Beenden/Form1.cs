// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Anwendung_Beenden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdBeenden_Click(object sender, EventArgs e)
        {
            // Anwendung beenenden
            Close();



        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Abfragen ob wirklich beendet werden soll
            var ergebnis = MessageBox.Show("Wollen Sie wirklich beenden?","Beenden", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);


            // Falls Benutzer auf "Abbrechen" geklickt hat wird das
            // Schlieﬂen des Formulars abgebrochen
            if (ergebnis == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
