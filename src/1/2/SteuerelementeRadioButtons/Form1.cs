// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementeRadioButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdPrüfen_Click(object sender, EventArgs e)
        {
            // Nach dem if/else steht nur eine Anweisung, deswegen
            // kann auf die geschweifte Klammern verzichtet werden.
            if (OptRot.Checked) LblAnzeigen1.Text = "Rot";
            else if (OptGruen.Checked) LblAnzeigen1.Text = "Grün";
            else if (OptBlau.Checked) LblAnzeigen1.Text = "Blau";
            else LblAnzeigen1.Text = "Nichts ausgewählt";
        }

        private void cmdAuswählen_Click(object sender, EventArgs e)
        {
            OptRot.Checked = true;
        }

        private void OptRot_CheckedChanged(object sender, EventArgs e)
        {
            LblAnzeigen2.Text = OptRot.Text;
        }

        private void OptGruen_CheckedChanged(object sender, EventArgs e)
        {
            LblAnzeigen2.Text = OptGruen.Text;
        }

        private void OptBlau_CheckedChanged(object sender, EventArgs e)
        {
            LblAnzeigen2.Text = OptBlau.Text;
        }
    }
}
