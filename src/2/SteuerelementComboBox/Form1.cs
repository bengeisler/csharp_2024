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

        private void BtnAnzeigen1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CmbBox.Items.Add("Zange");
            CmbBox.Items.Add("Hammer");
            CmbBox.Items.Add("Bohrer");
            CmbBox.Items.Add("Schraubendreher");
        }

        private void CmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblAnzeigen1.Text = $"Auswahl: {CmbBox.Text}";
        }
    }
}
