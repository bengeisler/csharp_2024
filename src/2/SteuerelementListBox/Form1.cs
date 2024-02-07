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
            LstSpeisen.Items.Add("Lasagne");
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            //Anzahl der Einträge der ListBox
            LblAnzeige1.Text = $"Anzahl:{LstSpeisen.Items.Count}\n";
            //Aktuell ausgewählten Eintrag anzeigen
            LblAnzeige1.Text += $"Ausgewählter Eintrag:{LstSpeisen.SelectedItem} \n";
            //Nummer des ausgewählten Eintrags
            LblAnzeige1.Text += $"Nummer des ausgewählter Eintrag: {LstSpeisen.SelectedIndex}\n";
            //Alle Einträge anzeien
            LblAnzeige1.Text += "Alle Einträge:\n";
            for (int i = 0; i < LstSpeisen.Items.Count; i++)
            {
                LblAnzeige1.Text += $"{i}:{LstSpeisen.Items[i]}\n";
            }
        }

        private void CmdButton2_Click(object sender, EventArgs e)
        {
            LblAnzeige1.Text = "Alle Einträge mit foreach:\n";
            foreach (var eintrag in LstSpeisen.Items)
            {
                LblAnzeige1.Text += $"{eintrag}\n";
            }
        }

        private void LstSpeisen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Diese Ereignissmethode wird aufgerufen, wenn sich der ausgewählte 
        }
    }
}
