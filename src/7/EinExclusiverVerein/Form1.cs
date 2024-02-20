// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace EinExclusiverVerein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_Beenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdÜbernahme_Click(object sender, EventArgs e)
        {

            LblFehler.Text = "";


            string name = TxtName.Text.Trim();
            string alterText = TxtAlter.Text.Trim();
            string lieblingsfarbe = RadioRot.Checked ? "Rot" : (RadioBlau.Checked ? "Blau" : "");


            if (string.IsNullOrEmpty(name))
            {
                LblFehler.Text = "Name muss angegeben werden.";
            }
            else if (string.IsNullOrEmpty(alterText) || !int.TryParse(alterText, out int alter))
            {
                LblFehler.Text = "Das Alter muss eine gültige Zahl sein.";
            }
            else if (alter < 18)
            {
                LblFehler.Text = "Kinder werden nicht akzeptiert.";
            }
            else if (alter > 68)
            {
                LblFehler.Text = "Rentner sind zu alt.";
            }
            else if (string.IsNullOrEmpty(lieblingsfarbe))
            {
                LblFehler.Text = "Lieblingsfarbe muss angegeben werden.";
            }
            else if (lieblingsfarbe.ToLower() != "blau" && lieblingsfarbe.ToLower() != "rot")
            {
                LblFehler.Text = "Nur die Lieblingsfarben Blau oder Rot sind erlaubt.";
            }
            else if (LstMitglieder.Items.Count >= 5)
            {
                LblFehler.Text = "Der Verein hat bereits fünf Mitglieder. Keine weiteren Aufnahmen möglich.";
            }
            else if (name.ToLower() == "peter")
            {
                LblFehler.Text = "Personen mit dem Namen 'Peter' sind nicht zugelassen.";
            }
            else
            {

                LstMitglieder.Items.Add($"{name}, {alter} Jahre");


                TxtName.Text = "";
                TxtAlter.Text = "";


                TxtName.Focus();
            }
        }

        private void CmdMitgliedLöschen_Click(object sender, EventArgs e)
        {
            LstMitglieder.Items.Remove(LstMitglieder.SelectedItem);
        }
    }
}
