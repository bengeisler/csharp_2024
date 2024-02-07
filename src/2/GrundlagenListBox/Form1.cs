// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAnzeigen_Click(object sender, EventArgs e)
        {
            //Anzahl der Einträge der ListBox
            LblAnzeigen.Text = $"Anzahl: {LstSpeisen.Items.Count}";

            //Aktuell ausgewählten Eintrag anzeigen
            LblAnzeigen.Text += $"Ausgewählter Eintrag: {LstSpeisen.SelectedIndex}";

            //Nummer des ausgwählten Eintrags
            LblAnzeigen.Text += $"Nummer des ausgewählter Eintrag: {LstSpeisen.SelectedIndex}";

            //Alle Einträge anzeigen
            LblAnzeigen.Text += "Alle Einträge:\n";
            for (int i = 0; i < LstSpeisen.Items.Count; i++)
            {
                LblAnzeigen.Text += $"{i}: {LstSpeisen.Items[i]}\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Diese Ereignismethode wird beim Laden des Formulars aufgerufen

            //Einträge der Listbox befülle
            LstSpeisen.Items.Add("Spaghetti");
            LstSpeisen.Items.Add("Grüne Nudeln");
            LstSpeisen.Items.Add("Tortellini");
            LstSpeisen.Items.Add("Pizza");
            LstSpeisen.Items.Add("Lasagne");
            LstSpeisen.Items.Add("Maccheroni");
        }
    }
}
