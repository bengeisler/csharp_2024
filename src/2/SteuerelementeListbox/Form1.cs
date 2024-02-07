// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementeListbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstSpeisen.Items.Add("Spagehetti");
            LstSpeisen.Items.Add("Gr�ne Nudeln");
            LstSpeisen.Items.Add("Tortollini");
            LstSpeisen.Items.Add("Pizza");
            LstSpeisen.Items.Add("Lasagne");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Anzahl der Eintr�ge der ListBox
            LblAusgabe.Text = $"Anzahl: {LstSpeisen.Items.Count}\n";

            //Aktuell ausgew�hlten Eintrag anzeigen
            LblAusgabe.Text += $"Ausgew�hler Eintrag: {LstSpeisen.SelectedItem}/n";


            //Nummer des ausgew�hlten Eintrags
            LblAusgabe.Text += $"Ausgew�hler Eintrag: {LstSpeisen.SelectedIndex}/n";

            //Alle Eintr�ge anzeigen
            LblAusgabe.Text += "Alle Eintr�ge:\n";
            for (int i = 0; i < LstSpeisen.Items.Count; i++)
            {
                LblAusgabe.Text += $"{i}: {LstSpeisen.Items[i]}\n";

            }
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            LblAusgabe.Text = "Alle Eintr�ge mit foreach:\n";
            foreach (var eintrag  in LstSpeisen.Items)
            {
                LblAusgabe.Text += $"{eintrag}\n";

            }
        }
    }
}
