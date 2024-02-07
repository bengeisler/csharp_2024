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
            LstSpeisen.Items.Add("Spaghetti");
            LstSpeisen.Items.Add("Gr�ne Nudeln");
            LstSpeisen.Items.Add("Tortellini");
            LstSpeisen.Items.Add("Pizza");
            LstSpeisen.Items.Add("lasagne");

        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            LblAusgabe.Text = $"Anzahl: {LstSpeisen.Items.Count}\n";
            LblAusgabe.Text += $"Ausgew�hlter Eintrag: {LstSpeisen.SelectedItem}\n";
            LblAusgabe.Text += $"Nummer des ausgew�hlten Eintrag: {LstSpeisen.SelectedIndex}\n";
            LblAusgabe.Text += "Alle Eintr�ge:\n";
            for (int i = 0; i < LstSpeisen.Items.Count; i++)
            {
                LblAusgabe.Text += $"{i}: {LstSpeisen.Items[i]}\n";
            }

        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            LblAusgabe.Text = "Alle Eintr�ge mit foreach:\n";
            foreach (var eintrag in LstSpeisen.Items)
            {
                LblAusgabe.Text += $"{eintrag}\n";
            }
        }

        private void LstSpeisen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
