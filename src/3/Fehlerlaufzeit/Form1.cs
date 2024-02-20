// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Fehlerlaufzeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdOhne_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txt1.Text);
            int y = Convert.ToInt32(txt2.Text);
            int z = x / y;
            LblAusgabe.Text = $"Ergebnis: {z}";

        }

        private void cmdMit_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txt1.Text);
                int y = Convert.ToInt32(txt2.Text);
                int z = x / y;
                LblAusgabe.Text = $"Ergebnis: {z}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitte nur gültige Zahlen eingeben!");



            }

        }

        private void cmdErweitert_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txt1.Text);
                int y = Convert.ToInt32(txt2.Text);
                int z = x / y;
                LblAusgabe.Text = $"Ergebnis: {z}";
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Durch 0 kann nicht geteilt werden!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitte nur gültige Zahlen eingeben!");

            }


        }

        private void CmdAusloesen_Click(object sender, EventArgs e)
        {
            try
            {
                // Rückgabewerte: true | false => erfolgreich ja/nein
                // Argument 1: string, der in double umgewandelt werden soll
                // Argument 2: Ausgabeparameter, in das Ergebnis der Umwandlung steht
                bool erfolgreich = double.TryParse(txt1.Text, out double ergebnis);

                // Ausnahme auslösen, falls Umwandlung nicht funktioniert hat
                if (!erfolgreich)
                    throw new FormatException("Es wurde keine gültige Zahl eingegeben.");
            }
            catch ( Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }

            }
        }
    }
}

