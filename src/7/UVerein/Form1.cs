// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UVerein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdHinzuf�gen_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtName.Text == "") throw new ArgumentException("Bitte Name eingeben");
                if (TxtAlter.Text == "") throw new ArgumentException("Bitte Alter eingeben");
                if (!int.TryParse(TxtAlter.Text, out int alter))
                    throw new ArgumentException("Alter muss g�ltige Zahl sein!");
                if (alter < 18) throw new ArgumentException("Kinder werden nicht akzeptiert");
                if (alter > 68) throw new ArgumentException("Rentner werden nicht akzeptiert");
                if (!OptBlau.Checked && !OptRot.Checked)
                    throw new ArgumentException("Bitte Lieblingsfarbe ausw�hlen");
                if (!OptBlau.Checked)
                    throw new ArgumentException("Lieblingsfarbe muss Blau sein");
                if (LstMitglieder.Items.Count >= 5)
                    throw new ArgumentException("Verein hat schon 5 Mitglieder");
                if (TxtName.Text == "Peter")
                    throw new ArgumentException("Peter werden nicht aktzeptiert");

                // Mitglied hinzuf�gen
                LstMitglieder.Items.Add($"{TxtName.Text}, {TxtAlter.Text} Jahre");

                // Eingabefelder leeren
                TxtAlter.Text = "";
                TxtName.Text = "";

                // Fokus in die erste TextBox setzen
                TxtName.Focus();
            }
            catch (Exception ex)
            {
                LblFehler.Text = ex.Message;
            }
        }

        private void CmdL�schen_Click(object sender, EventArgs e)
        {
            LstMitglieder.Items.Remove(LstMitglieder.SelectedItem);
        }

        private void FehlerR�cksetzen(object sender, EventArgs e)
        {
            LblFehler.Text = "";
        }
    }
}
