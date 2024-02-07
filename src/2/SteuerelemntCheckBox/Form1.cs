// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelemntCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Status der CheckBox anzeigen
            // Terinärer Operator
            LblPruefen.Text = chkSchalter.Checked ? "Ein" : "Aus";

        }

        private void chkSchalter_CheckedChanged(object sender, EventArgs e)
        {
            LblSchalter.Text = chkSchalter.Checked ? "Ein" : "Aus";
        }

        private void cmdUmschalten_Click(object sender, EventArgs e)
        {
            chkSchalter.Checked = !chkSchalter.Checked;

        }
    }
}
