// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CmdWerkzeuge.Items.Add("Zange");
            CmdWerkzeuge.Items.Add("Hammer");
            CmdWerkzeuge.Items.Add("Bohrer");
            CmdWerkzeuge.Items.Add("Schreibendreher");

        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            LblAusgabe.Text = $"Auswahl: {CmdWerkzeuge.Text}";
            //LblAusgabe.Text = $"Auswahl: {CmdWerkzeuge.SelectedItem}";
        }

        private void CmdWerkzeuge_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblAusgabe.Text = $"Auswahl: {CmdWerkzeuge.Text}";
        }
    }
}
