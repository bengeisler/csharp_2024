// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Dateikonverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdLesen_Click(object sender, EventArgs e)
        {
            try
            {
                // ListBoxen leeren
                LstLesen.Items.Clear();
                LstSchreiben.Items.Clear();

                // OpenFileDialog-Objekt erstellen
                // Über die Initialisierungsliste können dessen Eigenschaften einfach
                // gesetzt werden
                OpenFileDialog ofd = new()
                {
                    Title = "Datei öffnen",
                    Filter = "Text-Dateien (*.txt)|*.txt",
                    InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(),
                };
                // OpenFileDialog anzeigen
                // Falls nicht auf Öffnen geklickt wurde, wird diese Methode hier verlassen
                if (ofd.ShowDialog() != DialogResult.OK) return;

                // Der OpenFileDialog hat die Eigenschaft FileName, die den vom Nutzer
                // ausgewählten Pfad zurückgibt. Dieser kann verwendet werden, um die
                // Datei einzulesen.
                var zeilen = File.ReadAllLines(ofd.FileName);

                foreach (var zeile in zeilen)
                {
                    // Versuchen, die Zeile in double zu konvertieren
                    // isNumeric: true, falls Umwandlung funktioniert, sonst false
                    // out double ergebnis: Variable "ergebnis" vom Typ double deklarieren
                    // und den Wert der Umwandlung zuweisen
                    var isNumeric = double.TryParse(zeile, out double ergebnis);

                    // Fallunterscheidung: Linke oder rechte Liste?
                    // isNumeric = true: Umwandlung war erfolgreich
                    // => in linke Liste, auf zwei Nachkommastellen gerundet
                    if (isNumeric) LstLesen.Items.Add($"{ergebnis:0.00}");
                    // isNumeric = false: Umwandlung war nicht erfolgreich
                    else LstSchreiben.Items.Add(zeile);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }






    
     

        private void CmdSchreiben_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {

                InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(),
                Filter = "Tabellen (*.xlsx)|*.xlsx|"
                + "Texte (*.txt; *.docx)|*.txt;*.docx|"
                + "Alle Dateien (*.*)|*.*",
                Title = "Datei zum öffnen auswählen"

            };

            var ergebnis = 




        }
    }
