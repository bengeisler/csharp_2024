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

        private void BtnOhneException_Click(object sender, EventArgs e)
        {

            try
            {
                int x = Convert.ToInt32(TxtEingabe1.Text);
                int y = Convert.ToInt32(TxtEingabe2.Text);
                int z = x / y;
                LblAusgabe.Text = $"Ergebniss: {z}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitte nur gültige Zahlen eingeben!");
            }
        }

        private void BtnMitException_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(TxtEingabe1.Text);
                int y = Convert.ToInt32(TxtEingabe2.Text);
                int z = x / y;
                LblAusgabe.Text = $"Ergebniss: {z}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitte nur gültige Zahlen eingeben!");
            }
        }

        private void BtnAusnahme_Click(object sender, EventArgs e)
        {
            try
            {
                //TryParse:
                //Rückgabewerte: true|false => Umwandeln erfolgreich ja/nein
                //Argument 1: string, der in double umgewandelt werden soll
                //Argument 2: Ausgabeparameter, in dem das Ergebnis der Umwandlung steht
                bool erfolgreich = double.TryParse(TxtEingabe1.Text, out double ergebnis);

                //Ausname auslösen, falls Umwandlung nicht funktioniert hat
                if (!erfolgreich)
                {
                    throw new FormatException("Es wurde keine gültige Zahl eingegeben.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
