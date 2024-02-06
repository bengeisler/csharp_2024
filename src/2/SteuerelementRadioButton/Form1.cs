// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdPruefen_Click(object sender, EventArgs e)
        {
            // Nach dem if/else steht nur eine Anweisung, deswegen
            // kann auf die geschweiften Klammern verzichtet werden.
            if (OptRot.Checked) LblPruefen.Text = "Rot";
            else if (OptGruen.Checked) LblPruefen.Text = "Grün";
            else if (OptBlau.Checked) LblPruefen.Text = "Blau";
            else LblPruefen.Text = "Nichts ausgewählt";
        }

        private void CmdAuswahl_Click(object sender, EventArgs e)
        {
            OptRot.Checked = true;
        }

        private void OptRot_CheckedChanged(object sender, EventArgs e)
        {
            LblAuswahl.Text = "Rot";
        }

        private void OptGruen_CheckedChanged(object sender, EventArgs e)
        {
            LblAuswahl.Text = "Grün";
        }

        private void OptBlau_CheckedChanged(object sender, EventArgs e)
        {
            LblAuswahl.Text = "Blau";
        }
    }
}
