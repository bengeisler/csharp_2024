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

        private void CmdUebernehmen_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtName.Text == "")
                    throw new ArgumentException("Bitte Name eingeben");
                if (TxtName.Text == "Peter")
                    throw new ArgumentException("Der Name darf nicht Peter sein!");
                if (TxtName.Text == "")
                    throw new ArgumentException("Bitte Alter eingeben!");
                if (!int.TryParse(TxtAlter.Text, out int alter))
                    throw new ArgumentException("Eine gültige Zahl eingeben!");
                if (alter < 18)
                    throw new ArgumentException("Das Alter ist kleiner als 18 (Kinder werden nicht akzeptiert!");
                if (alter > 68)
                    throw new ArgumentException("Das Alter liegt über 68 Jahren (Rentner sind zu alt!");
                if (OptBlau.Checked == false && OptRot.Checked == false)
                    throw new ArgumentException("Bitte Lieblingsfarbe wählen!");
                if (OptRot.Checked == true)
                    throw new ArgumentException("Falsche Lieblingsfarbe!");
                if (LstMitglieder.Items.Count > 5)
                    throw new ArgumentException("Der Verein hat schon 5 Mitglieder!");

                LstMitglieder.Items.Add($"{TxtName.Text}, {TxtAlter.Text}Jahre");
                TxtName.Text = "";
                TxtAlter.Text = "";
                TxtName.Focus();

            }
            catch (Exception ex)
            {
                LblAnzeige.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LstMitglieder.SelectedIndex == -1) return;
            LstMitglieder.Items.RemoveAt(LstMitglieder.SelectedIndex);


        }
    }
}
