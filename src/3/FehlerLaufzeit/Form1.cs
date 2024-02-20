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

        private void cmdOhneEx_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtBox1.Text);
            int y = Convert.ToInt32(txtBox2.Text);
            int z = x / y;
            LblAnzeigen.Text = $"Ergebnis: {z}";
        }

        private void CmdAusl�sen_Click(object sender, EventArgs e)
        {


            try
            {
                // TryParse:
                // R�ckgabewerte: ture | false => Umwandlung erfolgreich ja/nein
                // Argument 1: string, der in double umgewandelt werden soll
                // Argument 2: Ausgabeparameter, in dem das Ergebnis der Umwandlung steht
                bool erfolgreich = double.TryParse(txtBox1.Text, out double ergebnis);

                // Ausnahme ausl�sen, falls Umwandlung nicht funktioniert hat
                if (!erfolgreich)
                    throw new FormatException("Es wurde keine g�ltige Zahl eingegeben.");

                //Beispiel
                //if (txtBox1.Text == "")
                //    throw new FormatException("Es wurde keine g�ltige Zahl eingegeben.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
