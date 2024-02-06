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
            // Status der CheckBox anzeigen
            // Ternärer Operator
            LblPruefen.Text = ChkSchalter.Checked ? "Ein" : "Aus";

            // Alternativ: mit if/else
            //if (ChkSchalter.Checked)
            //{
            //    LblPruefen.Text = "Ein";
            //}
            //else
            //{
            //    LblPruefen.Text = "Aus";
            //}

            // Alternativ: als switch-Ausdruck
            //LblPruefen.Text = ChkSchalter.Checked switch
            //{
            //    false => "Aus",
            //    _ => "Ein"
            //};
        }

        private void ChkSchalter_CheckedChanged(object sender, EventArgs e)
        {
            LblSchalter.Text = ChkSchalter.Checked ? "Ein" : "Aus";
        }

        private void CmdUmschalten_Click(object sender, EventArgs e)
        {
            ChkSchalter.Checked = !ChkSchalter.Checked;
        }
    }
}
