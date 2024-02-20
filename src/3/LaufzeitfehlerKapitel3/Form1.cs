// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace LaufzeitfehlerKapitel3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cmdohne_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtEingabe1.Text);

            int y = Convert.ToInt32(TxtEingabe2.Text);
            int z = x / y;
            LblAusgabe.Text = $"Ergebnis:{z}";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                bool erfolgreich = double.TryParse(TxtEingabe1.Text, out double ergebnis);
                if (!erfolgreich)
                {

                }
                throw new FormatException("es wurde keine gültige Zahl eingegeben.");
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);

            }

            



            

        }
    }
}
