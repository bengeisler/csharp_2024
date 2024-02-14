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

        private void CmdAlleL�schen_Click(object sender, EventArgs e)
        {
            LstTodo.Items.Clear();

            StatusAktualisieren();
        }

        private void CmdHinzuf�gen_Click(object sender, EventArgs e)
        {
            // Eintrag aus den zwei Eingabefeldern zusammenbauen
            // M�glichkeit 1: Mit "+" strings verkn�pfen
            // var neuesItem = TxtAnzahl.Text + "x " + TxtBeschreibung.Text;

            // M�glichkeit 2:
            // var neuesItem = $"{TxtAnzahl.Text}x {TxtBeschreibung.Text}";

            // M�glichkeit 3:
            LstTodo.Items.Add($"{TxtAnzahl.Text}x {TxtBeschreibung.Text}");

            StatusAktualisieren();
        }

        private void CmdL�schen_Click(object sender, EventArgs e)
        {
            // Ausgew�hlten Eintrag l�schen
            LstTodo.Items.Remove(LstTodo.SelectedItem);

            StatusAktualisieren();
        }

        private void CmdNachRechts_Click(object sender, EventArgs e)
        {
            // Von Links nach Rechts verschieben

            // Null-Check: Nur wenn etwas ausgew�hlt ist (SelectedItem ist NICHT null)
            // soll dieser ausgew�hlte Eintrag rechts hinzugef�gt und links gel�scht werden
            // Alternative: Pr�fung ob SelectedIndex != -1
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
