// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.Metrics;

namespace UVerein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int anzahl = 0;

        private void BtnÜbernehmen_Click(object sender, EventArgs e)
        {

            string Name = null;
            string Alter = null;

            LblAusgabe.Text = "";

            if (anzahl <= 4)
            {
                try
                {
                    string Eingabe = TxtName.Text;

                    if (Eingabe == "")
                    {
                        MessageBox.Show("Bitte gebe einen Namen ein");
                        TxtName.Text = "";
                        return;
                    }
                    else if (Eingabe == "Peter")
                    {
                        MessageBox.Show("Peter ist nicht zugelassen");
                        TxtName.Text = "";
                        return;
                    }
                    else Name = Eingabe;
                }
                catch (Exception ex)
                {
                    TxtName.Text = "";
                    MessageBox.Show(ex.Message);
                    return;
                }


                try
                {
                    int Eingabe = Convert.ToInt32(TxtAlter.Text);

                    if (Eingabe <= 18)
                    {
                        MessageBox.Show("Kinder werden nicht akzeptiert");
                        TxtAlter.Text = "";
                        return;
                    }
                    else if (Eingabe >= 68)
                    {
                        MessageBox.Show("Rentner sind zu alt");
                        TxtAlter.Text = "";
                        return;
                    }
                    else Alter = Convert.ToString(Eingabe);
                }
                catch (Exception ex)
                {
                    TxtAlter.Text = "";
                    MessageBox.Show(ex.Message);
                    return;
                }


                if (!optBlau.Checked && !optRot.Checked)
                {
                    MessageBox.Show("Es wurde keine Farbe ausgewählt");
                    return;
                }
                else if (!optBlau.Checked)
                {
                    LblAusgabe.Text = "Lieblingsfarbe ist nicht blau";
                    LblAusgabe.ForeColor = Color.Red;
                }

                TxtAlter.Text = "";
                TxtName.Text = "";
                TxtName.Focus();
                optBlau.Checked = false;
                optRot.Checked = false;
                anzahl += 1;
                LstBox.Items.Add($"{Name}, {Alter} Jahre");

            }
            else MessageBox.Show("Verein hat schon fünf Mitglieder");
        }

        private void BtnLöschen_Click(object sender, EventArgs e)
        {
            LstBox.Items.Remove(LstBox.SelectedItem);
        }
    }
}
