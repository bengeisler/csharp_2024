// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementeRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPruefen_Click(object sender, EventArgs e)
        {
            if (RbRot.Checked) LblAusgabe1.Text = "Rot";
            else if (RbGruen.Checked) LblAusgabe1.Text = "Grün";
            else if (RbBlau.Checked) LblAusgabe1.Text = "Blau";
            else LblAusgabe1.Text = "Nichts ausgewählt";

        }

        private void BtnRotaus_Click(object sender, EventArgs e)
        {
            RbRot.Checked = true;
        }

        private void RbRot_CheckedChanged(object sender, EventArgs e)
        {
            LblAusgabe2.Text = "Rot";
        }

        private void RbGruen_CheckedChanged(object sender, EventArgs e)
        {
            LblAusgabe2.Text = "Grün";
        }

        private void RbBlau_CheckedChanged(object sender, EventArgs e)
        {
            LblAusgabe2.Text = "Blau";
        }
    }
}
