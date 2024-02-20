// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.VisualBasic;

namespace ULottozahlen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void CmdZiehung_Click(object sender, EventArgs e)
        {
            Random random = new();
            int zufallszahl = random.Next(1, 50);

            List<int> list = new List<int>();
            list.Add(zufallszahl);

            int counter = 0;
            


            while (list.Count <= 6)
            {
                zufallszahl = random.Next(1, 50);
                list.Add((int)zufallszahl);
                LstZahl.Items.Add(zufallszahl);
                list.Sort();


              

            }
            TxtZusatzzahl.Text = random.Next(1, 50).ToString();

        }
              
    }
}
