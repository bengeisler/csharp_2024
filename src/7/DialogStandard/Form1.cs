// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace DialogStandard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cmd÷ffnen_Click(object sender, EventArgs e)
        {
            // Objekt vom Typ OpenFileDialog erstellen
            OpenFileDialog ofd = new()
            {
                Multiselect = true, // Erlaubt Mehrfachauswahl
                InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(),
                Filter = "Tabellen (*.xlsx)|*.xlsx,|"
                + "Texte (*.txt; *.docx)| *.txt;*.docx|"
                + "Alle Dateien (*.*)|*.*",
                Title = "Datei zum ÷ffnen ausw‰hlen"

            };


            // OpenFileDialog anzeigen
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

        private void CmdSpeichern_Click(object sender, EventArgs e)
        {
            // Objekt vom Typ SaveFileDialog erstellen
            SaveFileDialog sfd = new()
            {
                InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(),
                Filter = "Tabellen (*.xlsx)|*.xlsx,|"
                + "Texte (*.txt; *.docx)| *.txt;*.docx|"
                + "Alle Dateien (*.*)|*.*",
                Title = "Datei zum ÷ffnen ausw‰hlen"

            };

            var ergebnis = sfd.ShowDialog();

            if (ergebnis == DialogResult.OK)
            {
                MessageBox.Show($"{sfd.FileName}");
            }
        }
    }
}
