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
            //Anzahl der Eintr�ge der ListBox
            LblAnzeigen.Text = $"Anzahl: {LstSpeisen.Items.Count}";

            //Aktuell ausgew�hlten Eintrag anzeigen
            LblAnzeigen.Text += $"Ausgew�hlter Eintrag: {LstSpeisen.SelectedIndex}";

            //Nummer des ausgw�hlten Eintrags
            LblAnzeigen.Text += $"Nummer des ausgew�hlter Eintrag: {LstSpeisen.SelectedIndex}";

            //Alle Eintr�ge anzeigen
            LblAnzeigen.Text += "Alle Eintr�ge:\n";
            for (int i = 0; i < LstSpeisen.Items.Count; i++)
            {
                LblAnzeigen.Text += $"{i}: {LstSpeisen.Items[i]}\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Diese Ereignismethode wird beim Laden des Formulars aufgerufen

            //Eintr�ge der Listbox bef�lle
            LstSpeisen.Items.Add("Spaghetti");
            LstSpeisen.Items.Add("Gr�ne Nudeln");
            LstSpeisen.Items.Add("Tortellini");
            LstSpeisen.Items.Add("Pizza");
            LstSpeisen.Items.Add("Lasagne");
            LstSpeisen.Items.Add("Maccheroni");
        }
    }
}
