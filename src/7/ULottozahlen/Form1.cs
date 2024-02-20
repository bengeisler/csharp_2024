// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace ULottozahlen
{
    public partial class FrmLottozahlen : Form
    {
        public FrmLottozahlen()
        {
            InitializeComponent();
        }
        private Random r = new Random();

        private void FrmLottozahlen_Load(object sender, EventArgs e)
        {

        }

        private void CmdZiehung_Click(object sender, EventArgs e)
        {
            LstLottozahlen.Items.Clear();

            var AArray = new int[6];
            var neu = 0;

            for (int i = 0; i < AArray.Length; i++)
            {
                do
                {
                    neu = r.Next(1, 50);
                }
                while (AArray.Contains(neu));
                AArray[i] = neu;
            }
                Array.Sort(AArray);
                foreach (int Eintrag in AArray)

            {
                LstLottozahlen.Items.Add(Eintrag);   
            }

                var zusatzzahl = r.Next(1, 50);
                TxtZusatzzahl.Text = $"{zusatzzahl}";



        }
    }
}
