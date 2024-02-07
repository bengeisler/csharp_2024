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

        private void LstSpeisen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // EIntr�ge der Listbox bef�llen
            LstSpeisen.Items.Add("Spagehtti");
            LstSpeisen.Items.Add("Gr�ne Nudeln");
            LstSpeisen.Items.Add("Lasagne");

        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            LblAusgabe.Text = $"Anzahl:{LstSpeisen.Items.Count}";
            LblAusgabe.Text += $"Ausgew�hler Eintrag: {LstSpeisen.SelectedItem}";
            LblAusgabe.Text += $"Nummer des ausgew�hlten Eintrages: {LstSpeisen.SelectedIndex}";


            LblAusgabe.Text += "Alle eintr#ge: \n";
            for (int i = 0; i < LstSpeisen.Items.Count; i++)
            {
                LblAusgabe.Text += $"{i}: {LstSpeisen.Items[i]} \n";



            }
        }

        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {
            LblAusgabe.Text = "Alle Eintr�ge mit  \n ";
            foreach (var eintrag in LstSpeisen.Items)
            {
                LblAusgabe.Text += $"{eintrag}\n";

            }
        }
    }
