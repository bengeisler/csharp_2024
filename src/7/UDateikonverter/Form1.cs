// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UDateikonverter
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
                InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(),
                Filter = "Tabellen (*.xlsx)|*.docx|"
                + "Texte (*.txt; *.docx)|*.txt;*.docx|"
                + "Alle Dateien (*.*)|*.*",
                Title = "Datei zum Öffnen auswählen"
            };

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

        private void btnSchreiben_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new()
            {
                InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(),
                Filter = "Tabellen (*.xlsx)|*.docx|"
                + "Texte (*.txt; *.docx)|*.txt;*.docx|"
                + "Alle Dateien (*.*)|*.*",
                Title = "Datei zum Öffnen auswählen"
            };
            var ergebnis = sfd.ShowDialog();
            if (ergebnis == DialogResult.OK)
            {
                MessageBox.Show($"{sfd.FileName}");
            }
        }

        private void lstWerte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
}
