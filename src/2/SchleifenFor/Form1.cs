// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SchleifenFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige1_Click(object sender, EventArgs e)
        {
            LabelAnzeige1.Text = "";
            double summe = 0;
            int zaehler = 0;

            {
                double i;
                LabelAnzeige1.Text = "";

                for (i = 35; i >= 20; i -= 2.5)
                {
                    LabelAnzeige1.Text += $"{i}\n";
                    summe += i;
                    zaehler++;

                }
                LabelAnzeige2.Text += $"Summe:{summe}\n";
                LabelAnzeige3.Text += $"Mittelwert:{summe / zaehler}\n";
            }
        }

    }

