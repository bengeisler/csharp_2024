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
            CmbWerkzeuge.Items.Add("Zange");
            CmbWerkzeuge.Items.Add("Hammer");
            CmbWerkzeuge.Items.Add("Bohrer");
            CmbWerkzeuge.Items.Add("Schraubendreher");

        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            LblAnzeigen.Text = $"Auswahl: {CmbWerkzeuge.Text}";
            // oder:
            //LblAnzeigen.Text = $"Auswahl: {CmbWerkzeuge.SelectedItem}";

        }

        private void CmbWerkzeuge_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblAnzeigen.Text = $"Auswahl: {CmbWerkzeuge.Text}";

        }
    }
}
