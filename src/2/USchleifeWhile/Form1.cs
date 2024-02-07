// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace USchleifeWhile
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            double summe = Convert.ToDouble(TxtBox.Text);
            double v = 0.5;
            double Erstes = Convert.ToDouble(summe * v);

            LblAnzeigen.Text = Erstes.ToString();


            do
            {

                
                LblAnzeigen.Text += $"{Erstes * v}\n";


            } while (Erstes <= 0.01);


        }
    }
}
