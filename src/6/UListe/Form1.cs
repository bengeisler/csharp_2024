// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Data;
using System.Net.Mail;

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

        private void CmdHinzufügen_Click(object sender, EventArgs e)
        {
            LstListe.Items.Add(TxtEingabe.Text);
        }

        private void CmdSpeichern_Click(object sender, EventArgs e)
        {
            // SaveFileDialog
            SaveFileDialog sfd = new()
            {
                InitialDirectory = Environment.SpecialFolder.Desktop.ToString(),
                Filter = "Textdateien|*.txt;*.docx",
                Title = "Datei speichern..."
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                List<string> list = new();
                foreach (var item in LstListe.Items)
                    list.Add(item.ToString());

                try
                {
                    File.WriteAllLines(sfd.FileName, list);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                
        }

        private void CmdLaden_Click(object sender, EventArgs e)
        {
            // OpenFileDialog erstellen
            OpenFileDialog ofd = new()
            {
                InitialDirectory = Environment.SpecialFolder.Desktop.ToString(),
                Filter = "Textdateien|*.txt;*.docx",
                Title = "Datei öffnen..."
            };

            // Anzeigen
            var result = ofd.ShowDialog();

            // Wenn Benutzer auf öffnen geklickt hat
            if (result == DialogResult.OK)
            {
                try
                {
                    // Datei einlesen
                    // Pfad: ofd.FileName
                    var items = File.ReadAllLines(ofd.FileName);

                    // Zur Liste hinzufügen
                    LstListe.Items.Clear();
                    foreach (var item in items)
                        LstListe.Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }        
        }

        private void CmdLöschen_Click(object sender, EventArgs e)
        {
            LstListe.Items.Remove(LstListe.SelectedItem);
        }

        private void CmdAlleLöschen_Click(object sender, EventArgs e)
        {
            LstListe.Items.Clear();
        }

        private void CmdBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
