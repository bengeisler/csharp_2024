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

        private void Cmdpruefen_Click(object sender, EventArgs e)
        {
            if (OptRot.Checked) Lblpruefen.Text = "Rot";
            else if (OptGruen.Checked) Lblpruefen.Text = "Grün";
            else if (OptBlau.Checked) Lblpruefen.Text = "Blau";
            else Lblpruefen.Text = "Nichts ausgewählt";


        }

        private void OptRot_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
