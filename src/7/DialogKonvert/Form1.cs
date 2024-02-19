// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace DialogKonvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLesen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                Multiselect = true, //Erlaubt Mehrfachauswahl
                InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(),
                Filter = "Tabellen (*.xlsx)| *.xlsx|"
                + "Texte (*.txt; *.docx)|*.txt; *.docx|"
                + "Alle Dateien (*.*)|*.*",
                Title = "Datei zum Öffnen auswählen"
            };

            //OpenFileDialog anzeigen
            var ergebnis = ofd.ShowDialog();

            if (ergebnis == DialogResult.OK)
            {
                foreach (var file in ofd.FileNames)
                {
                    MessageBox.Show(file);
                }
            }

            else
            {
                MessageBox.Show("Abbruch");
            }
        }
    }
}
