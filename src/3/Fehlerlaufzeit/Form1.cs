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
    }
}

