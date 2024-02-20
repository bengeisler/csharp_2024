// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.Eventing.Reader;

namespace UVerein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdÜbernahme_Click(object sender, EventArgs e)
        {


            int Alter = Convert.ToInt32(TxtAlter.Text);
            var Mitglieder = TxtName.Text + ", " + " " + TxtAlter.Text + " " + "Jahre";


            if (TxtName.Text == "")
                LblFarbe.Text = "Geben Sie einen Namen ein";

            else if (TxtAlter.Text == "")
                LblFarbe.Text = "Geben Sie einen Alter ein";

            else if (Alter < 18)
                LblFarbe.Text = "Es werden keine Kinder angenommen.";

            else if (Alter > 68)
                LblFarbe.Text = "Es werden keine Rentner angenommen.";

            else if (ChkBlau.Checked != true && ChkRot.Checked != true)
                LblFarbe.Text = "Es wurde keine Farbe ausgewählt";

            else if (ChkBlau.Checked == false)
                LblFarbe.Text = "Falsche Lieblingsfarbe!";

            else if (LstMitglieder.Items.Count >= 5)
                LblFarbe.Text = "Es werden nicht mehr als 5 Mitglieder angenommen";

            else if (TxtName.Text == "Peter")
                LblFarbe.Text = "Der Name Peter wird nicht gestattet";

            else
                LstMitglieder.Items.Add(Mitglieder);
            TxtAlter.Text = "";
                TxtName.Text = "";
            TxtName.Focus();

        }

        private void LblFarbe_Click(object sender, EventArgs e)
        {

        }

        private void CmdMitgliedLöschen_Click(object sender, EventArgs e)
        {
            LstMitglieder.Items.Remove(LstMitglieder.SelectedItem);
        }

        private void CmdBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
