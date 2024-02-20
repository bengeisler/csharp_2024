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

        private void CmdOhneHandling_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int z = x / y;
            LblAnzeige.Text = $"Ergebnis: {z}";

        }

        private void CmdMitExceptionHandling_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                int z = x / y;
                LblAnzeige.Text = $"Ergebnis: {z}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitte nur gültige Zahlen eingeben!");


            }
        }

        private void CmdMiterweitertenExceptionHandling_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                int z = x / y;
                LblAnzeige.Text = $"Ergebnis: {z}";
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Durch 0 kann nicht geteilt werden! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitte nur gültige Zahlen eingeben!");


            }
        }

        private void CmdAuslösen_Click(object sender, EventArgs e)

        {
            try
            {
                bool erfolgreich = double.TryParse(textBox1.Text, out double ergebnis);


                if (!erfolgreich == false)
                    throw new FormatException("Es wurde keine gültige Zahl eingegeben");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                
            }




            
        }
    }
}
