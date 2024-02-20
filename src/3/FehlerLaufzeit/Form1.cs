// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace FehlerLaufzeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdOhne_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtEingabe1.Text);
            int y = Convert.ToInt32(TxtEingabe2.Text);
            int z = x / y;
            LblAnzeige.Text = $"Ergebnis: {z}";
        }

        private void CmdMit_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(TxtEingabe1.Text);
                int y = Convert.ToInt32(TxtEingabe2.Text);
                int z = x / y;
                LblAnzeige.Text = $"Ergebnis: {z}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitte nur g�ltige Zahlen eingeben!");
            }
        }

        private void CmdErweitert_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(TxtEingabe1.Text);
                int y = Convert.ToInt32(TxtEingabe2.Text);
                int z = x / y;
                LblAnzeige.Text = $"Ergebnis: {z}";
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Durch 0 kann nicht geteilt werden!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Die Eingabe ist keine g�ltige Zahl!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Die Eingabe ist zu gro� oder zu klein!");
            }
            catch (Exception)
            {
                MessageBox.Show("Allgemeiner Fehler!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CmdAusl�sen_Click(object sender, EventArgs e)
        {
            try
            {
                // TryParse:
                // R�ckgabewerte: true | false => Umwandlung erfolgreich ja/nein
                // Argument 1: string, der in double umgewandelt werden soll
                // Argument 2: Ausgabeparameter, in dem das Ergebnis der Umwandlung steht
                // Ausnahme ausl�sen, falls Umwandlung nicht funktioniert hat
                if (!double.TryParse(TxtEingabe1.Text, out double ergebnis))
                    throw new FormatException("Es wurde keine g�ltige Zahl eingegeben.");
                if (TxtEingabe1.Text == "")
                    throw new FormatException("Fehler!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
