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

        private void CmdPrüfen_Click(object sender, EventArgs e)
        {
            if (OptRot.Checked) LabelPruefen.Text = "Rot";
            else if (OptGrün.Checked) LabelPruefen.Text = "Grün";
            else if (OptBlau.Checked) LabelPruefen.Text = "Blau";
            else LabelPruefen.Text = "Nichts ausgewählt";






        }

        private void CmdAuswählen_Click(object sender, EventArgs e)
        {
            OptRot.Checked = true;
        }

        private void OptRot_CheckedChanged(object sender, EventArgs e)
        {
            LabelAuswahl.Text = "Rot";
        }

        private void OptGrün_CheckedChanged(object sender, EventArgs e)
        {
            LabelAuswahl.Text = "Grün";

        }

        private void OptBlau_CheckedChanged(object sender, EventArgs e)
        {
            LabelAuswahl.Text = "Blau";
        }
    }
}
