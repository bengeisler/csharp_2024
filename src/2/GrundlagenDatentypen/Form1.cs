// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenDatentypen
{
    public partial class Form1 : Form
    {
        private const double V = 2852.55;

        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {

            double b = 14;
            string c = "09445";
            int alter = 34;
            decimal DE = 2855.55m;

            LblAnzeigen.Text = $"Adresse:\nPavel Pekin\nBergstraﬂe {b}\n{c} Brunnstadt\n\nAlter: {alter}\nGehalt: {DE}"; 
                      
         
        }
    }
}
