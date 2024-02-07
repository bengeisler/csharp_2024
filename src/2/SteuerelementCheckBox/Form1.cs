// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdPruefen_Click(object sender, EventArgs e)
        {
            LblPruefen.Text = ChkSchalter.Checked ? "Ein" : "Aus";


        }

        private void ChkSchalter_CheckedChanged(object sender, EventArgs e)
        {
            LblPruefen.Text = ChkSchalter.Checked ? "Ein" : "Aus";
        }

        private void CmdUmschalten_Click(object sender, EventArgs e)
        {
            ChkSchalter.Checked = !ChkSchalter.Checked;
        }
    }
}
