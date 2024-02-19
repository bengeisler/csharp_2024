// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UListe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChkSortieren_CheckedChanged(object sender, EventArgs e)
        {
            LstListe.Sorted = ChkSortieren.Checked;
        }

        private void CmdHinzuf�gen_Click(object sender, EventArgs e)
        {
            LstListe.Items.Add(TxtEingabe.Text);
            TxtEingabe.Text = "";
        }

        private void CmdSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                // Ansatz 1: �ber Hilfs-Liste zum Zwischenspeichern der Eintr�ge
                List<string> items = [];
                foreach (var item in LstListe.Items)
                {
                    items.Add(item.ToString());
                }
                File.WriteAllLines("liste.txt", items);

                // Ansatz 2: StreamWriter

                // Filestream erstellen, der die Datei �ffnet
                var fs = new FileStream("liste.txt", FileMode.Open);
                // StreamWriter erstellen, um in den Stream zu schreiben
                var sw = new StreamWriter(fs);
                // Alle Eintr�ge der Liste in den Stream schreiben
                foreach (var item in LstListe.Items) sw.WriteLine(item);
                // StreamWriter schlie�en
                sw.Close();

                // Ansatz 3: String erstellen
                string zeilen = "";
                foreach (var eintrag in LstListe.Items)
                {
                    zeilen += eintrag.ToString() + Environment.NewLine;
                }
                File.WriteAllText("liste.txt", zeilen);

                // Ansatz 4: Umwandlung der Eintr�ge in strings
                File.WriteAllLines("liste.txt", LstListe.Items.Cast<string>());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmdLaden_Click(object sender, EventArgs e)
        {
            try
            {
                // Ansatz 1: Alle Zeilen der Datei einlesen und dann
                //           Zeile f�r Zeile der Liste hinzuf�gen
                var items = File.ReadAllLines("liste.txt");
                LstListe.Items.Clear();
                foreach (var item in items) LstListe.Items.Add(item);

                // Ansatz 2: StreamReader

                // Filestream erstellen, der die Datei �ffnet
                var fs = new FileStream("liste.txt", FileMode.Open);
                // StreamReader erstellen, um aus dem Stream zu lesen
                var sr = new StreamReader(fs);
                // Schleife wird solange durchlaufen, bis das Ende des Streams erreicht ist
                while (sr.Peek() != -1)
                {
                    LstListe.Items.Add(sr.ReadLine());
                }
                // StreamReader schlie�en
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmdL�schen_Click(object sender, EventArgs e)
        {
            LstListe.Items.Remove(LstListe.SelectedItem);
        }

        private void CmdAlleL�schen_Click(object sender, EventArgs e)
        {
            LstListe.Items.Clear();
        }

        private void CmdBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
