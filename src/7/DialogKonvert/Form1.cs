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


                    //MessageBox.Show(file);
                    string[] items = File.ReadAllLines(file);

                    IstWerte.Items.Clear();
                    foreach (string item in items)
                    {

                        try
                        {
                            double zahl = Convert.ToDouble(item);
                            IstWerte.Items.Add($"{zahl: 0.00}");
                        }
                        catch (Exception)
                        {

                            IstFehler.Items.Add(item);
                        }

                    }

                }


            }

            else
            {
                MessageBox.Show("Abbruch");
            }




        }

        private void BtnSchreiben_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new()
            {
                InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(),
                Filter = "Texte (*.txt; *.docx)|*.txt; *.docx|" +
                "Alle Dateien (*.*)|*.*",
                Title = "Zum Speichern ein Ort auswählen"
            };

            var ergebnis = sfd.ShowDialog();

            if(ergebnis == DialogResult.OK)
            {
                List<string> items = new();

                foreach (var item in IstWerte.Items)
                {
                    items.Add(item.ToString());

                }
                File.WriteAllLines($"{sfd.FileName}",items);

            }

        }
    }
}
