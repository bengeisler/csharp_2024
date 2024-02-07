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

        private void CmdPr�fen_Click(object sender, EventArgs e)
        {
            if (OptRot.Checked) LabelPruefen.Text = "Rot";
            else if (OptGr�n.Checked) LabelPruefen.Text = "Gr�n";
            else if (OptBlau.Checked) LabelPruefen.Text = "Blau";
            else LabelPruefen.Text = "Nichts ausgew�hlt";






        }

        private void CmdAusw�hlen_Click(object sender, EventArgs e)
        {
            OptRot.Checked = true;
        }

        private void OptRot_CheckedChanged(object sender, EventArgs e)
        {
            LabelAuswahl.Text = "Rot";
        }

        private void OptGr�n_CheckedChanged(object sender, EventArgs e)
        {
            LabelAuswahl.Text = "Gr�n";

        }

        private void OptBlau_CheckedChanged(object sender, EventArgs e)
        {
            LabelAuswahl.Text = "Blau";
        }
    }
}
