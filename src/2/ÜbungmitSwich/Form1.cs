// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace ÜbungmitSwich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdButton_Click(object sender, EventArgs e)
        {
            decimal x = Numtext.Value;
            decimal y = 0;

            switch (x)
            {
                case <= 12000:
                    y = x * 0.88M;
                    break;
                case > 12000 and <= 20000:
                        y = x *  0.85M;
                    break;
                case > 20000 and <= 30000:
                    y =x * 0.80M;
                    break;
                default:
                    y =x * 0.75M;
                    break;
                
                    

                   
            }
            Lblanzeige1.Text = $"{y}€";
        }
    }
}
