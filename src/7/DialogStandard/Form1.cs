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

        private void CmdÖffnen_Click(object sender, EventArgs e)
        {
            // Objekt vom Typ OpenFileDialog erstellen
            OpenFileDialog ofd = new()
            {
                Multiselect = true,
                InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(),
                Filter = "Tabellen (*.xlsx)|*.xlsx|"
                + "Texte (*.txt;*.docx)|*.txt,*.docx|"
                + "Alle Datein (*.*)|*.*",
                Title = "Datei zum öffnen auswählen"

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
            SaveFileDialog sfd = new()
            {
                InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(),
                Filter = "Tabellen (*.xlsx)|*.xlsx|"
                + "Texte (*.txt;*.docx)|*.txt,*.docx|"
                + "Alle Datein (*.*)|*.*",
                Title = "Datei zum öffnen auswählen"



            };

            var ergebnis = sfd.ShowDialog();
            if (ergebnis == DialogResult.OK)
            {
                MessageBox.Show($"{sfd.FileName}");
            }

        }
    }
}
