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
            cmbWerkzeuge.Items.Add("Zange");
            cmbWerkzeuge.Items.Add("Hammer");
            cmbWerkzeuge.Items.Add("Bohrer");
            cmbWerkzeuge.Items.Add("Schraubendreher");
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            LblAnzeigen1.Text = $"Auswahl: {cmbWerkzeuge.Text}";
        }

        private void cmbWerkzeuge_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblAnzeigen1.Text = $"Auswahl: {cmbWerkzeuge.Text}";
        }
    }
}
