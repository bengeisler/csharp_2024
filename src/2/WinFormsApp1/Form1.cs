// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CmbBtn1.Items.Add("Zange");
            CmbBtn1.Items.Add("Hammer");
            CmbBtn1.Items.Add("Bohrer");
            CmbBtn1.Items.Add("Schraubendreher");
        }

        private void CmdButton1_Click(object sender, EventArgs e)
        {
            LblAnzeige1.Text = $"Auswahl:{CmbBtn1.Text}";
            //  LblAnzeige1.Text = $"Auswahl:{CmbBtn1.SelectedItem}";
        }

        private void CmbBtn1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblAnzeige1.Text = $"Auswahl:{CmbBtn1.Text}";
        }
    }
}
