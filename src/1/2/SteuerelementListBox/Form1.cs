// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Diese Ereignismethode wird beim Laden des Formulars aufgerufen

            // Einträge der ListBox befüllen
            LstSpeisen.Items.Add("Spaghetti");
            LstSpeisen.Items.Add("Grüne Nudeln");
            LstSpeisen.Items.Add("Tortellini");
            LstSpeisen.Items.Add("Pizza");
            LstSpeisen.Items.Add("Lasange");
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            // Anzahl der Einträge der ListBox
            LblAnzeigen.Text = $"Anzahl: {LstSpeisen.Items.Count}\n";

            // Aktuell ausgewählten Eintrag anzeigen
            LblAnzeigen.Text += $"Ausgewählter Eintrag: {LstSpeisen.SelectedItem}\n";

            // Nummer des ausgewählten Eintrags
            LblAnzeigen.Text += $"Ausgewählter Eintrag: {LstSpeisen.SelectedIndex}\n";

            // Alle Einträge anzeigen
            LblAnzeigen.Text += "Alle Einträge:\n";
            for (int i = 0; i < LstSpeisen.Items.Count; i++)
            {
                LblAnzeigen.Text += $"{i}: {LstSpeisen.Items[i]}\n";
            }
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            LblAnzeigen.Text = "Alle Einträge mit foreach:\n";
            foreach (var eintrag in LstSpeisen.Items)
            {
                LblAnzeigen.Text += $"{eintrag}\n";
            }

        }

        private void LstSpeisen_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Diese Ereignismethode wird aufgerufen, wenn sich der ausgewählte Eintrag ändert

        }
    }
}
