// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UDateikonverter
{
    public partial class Dateikonverter : Form
    {
        public Dateikonverter()
        {
            InitializeComponent();
        }

        private void BtnSchreiben_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new()
                {
                    Title = "Datei speichern",
                    Filter = "Text-Dateien|*.txt",
                    InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(),
                };

                if (sfd.ShowDialog() != DialogResult.OK) return;

                List<string> werte = [];
                foreach (var wert in LstWert.Items) werte.Add(wert.ToString());
                File.WriteAllLines(sfd.FileName, werte);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

    private void BtnLesen_Click(object sender, EventArgs e)
        {
            try
            {
                LstFehler.Items.Clear();
                LstWert.Items.Clear();

                OpenFileDialog ofd = new()
                {
                    Title = "Datei öffnen",
                    Filter = "Text-Dateien (*.txt)|*.txt",
                    InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(),
                };
                if (ofd.ShowDialog() != DialogResult.OK) return;

                var zeilen = File.ReadAllLines(ofd.FileName);

                foreach (var zeile in zeilen)
                {

                    var isNumeric = double.TryParse(zeile, out double ergebnis);

                    if (isNumeric) LstWert.Items.Add($"{ergebnis:0.00}");
                    else LstFehler.Items.Add(zeile);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
