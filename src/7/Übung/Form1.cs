// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Übung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                    throw new FormatException("Fehler Kein Name gefunden !");
                if (textBox2.Text == "")
                    throw new FormatException("Es wird kein Alter eingegeben");
                 if (!int.TryParse(textBox2.Text, out int alter))
                {
                    throw new FormatException("Das alter ist keine gültige Zahl");
                }
                 if (alter <= 18)
                    throw new FormatException("Das alter liegt unter 18 Jahren");
                 if (alter >= 68)
                     throw new FormatException("Das alter liegt über 68");
                if (radioButton1.Checked == true)
                {
                    LblError.ForeColor = Color.Red;
                    LblError.Text = "Falsche Lieblingsfarbe!";
                    throw new FormatException("Falsche Lieblingsfarbe");
                }
                if (LstBox.Items.Count >= 5)
                    throw new FormatException("Das Verein hat schon 5 Mitglieder");
                if (textBox1.Text == "Peter")
                    throw new FormatException("Peter´s sind NICHT erwünscht");
                LstBox.Items.Add($"{textBox1.Text}, {textBox2.Text} Jahre");
                LblError.ForeColor= Color.Black;
                LblError.Text = "Hinzugefügt";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int index = LstBox.SelectedIndex;

            if (LstBox.Text != "" && index != -1)

                LstBox.Items.RemoveAt(index);
        }

        private void LblError_Click(object sender, EventArgs e)
        {

        }
    }
}



