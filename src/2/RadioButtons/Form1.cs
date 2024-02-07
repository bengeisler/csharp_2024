// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace RadioButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdPruefen_Click(object sender, EventArgs e)
        {
            //lblPruefen.Text = optRot.Checked ? "Rot"
            //  : optGruen.Checked ? "Grün" : "Blau";
            if (optRot.Checked) lblPruefen.Text = "Rot";
            else if (optGruen.Checked) lblPruefen.Text = "Gruen";
            else if (optBlau.Checked) lblPruefen.Text = "Blau";
            else lblPruefen.Text = "Nichts ausgewählt";


        }

        private void optRot_CheckedChanged(object sender, EventArgs e)
        {
            lblAuswaehlen.Text = "Rot";

        }

        private void optGruen_CheckedChanged(object sender, EventArgs e)
        {
            lblAuswaehlen.Text = "Grün";

        }

        private void optBlau_CheckedChanged(object sender, EventArgs e)
        {
            lblAuswaehlen.Text = "Blau";

        }

        private void CmdAuswahlRot_Click(object sender, EventArgs e)
        {
            optRot.Checked = true;

        }

        private void optFarbe_CheckedChanged(object sender, EventArgs e)
        {
            lblAuswaehlen.Text = optRot.Checked ? "Rot"
                : optGruen.Checked ? "Grün" : "Blau";
        }

        private void lblAuswaehlen_Click(object sender, EventArgs e)
        {

        }
    }
}
