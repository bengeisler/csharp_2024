// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UEinkaufsliste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdAlleLöschen_Click(object sender, EventArgs e)
        {
            LstTodo.Items.Clear();

            StatusAktualisieren();
        }

        private void CmdHinzufügen_Click(object sender, EventArgs e)
        {
            // Eintrag aus den zwei Eingabefeldern zusammenbauen
            // Möglichkeit 1: Mit "+" strings verknüpfen
            // var neuesItem = TxtAnzahl.Text + "x " + TxtBeschreibung.Text;

            // Möglichkeit 2:
            // var neuesItem = $"{TxtAnzahl.Text}x {TxtBeschreibung.Text}";

            // Möglichkeit 3:
            LstTodo.Items.Add($"{TxtAnzahl.Text}x {TxtBeschreibung.Text}");

            StatusAktualisieren();
        }

        private void CmdLöschen_Click(object sender, EventArgs e)
        {
            // Ausgewählten Eintrag löschen
            LstTodo.Items.Remove(LstTodo.SelectedItem);

            StatusAktualisieren();
        }

        private void CmdNachRechts_Click(object sender, EventArgs e)
        {
            // Von Links nach Rechts verschieben

            // Null-Check: Nur wenn etwas ausgewählt ist (SelectedItem ist NICHT null)
            // soll dieser ausgewählte Eintrag rechts hinzugefügt und links gelöscht werden
            // Alternative: Prüfung ob SelectedIndex != -1
            if (LstTodo.SelectedItem is not null)
            {
                LstErledigt.Items.Add(LstTodo.SelectedItem);
                LstTodo.Items.Remove(LstTodo.SelectedItem);
            }

            StatusAktualisieren();
        }

        private void CmdNachLinks_Click(object sender, EventArgs e)
        {
            if (LstErledigt.SelectedItem is not null)
            {
                LstTodo.Items.Add(LstErledigt.SelectedItem);
                LstErledigt.Items.Remove(LstErledigt.SelectedItem);
            }

            StatusAktualisieren();
        }

        private void StatusAktualisieren()
        {
            // Status aktualisieren
            var itemsErledigt = LstErledigt.Items.Count;
            var itemsGesamt = itemsErledigt + LstTodo.Items.Count;
            LblStatus.Text = $"{itemsErledigt} / {itemsGesamt} Produkte wurden schon eingekauft";
        }
    }
}
