// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Ugueltigkeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private decimal x = 0.0M;
        

        private void CmdAnzeige1_Click(object sender, EventArgs e)
        {
           decimal y = 0.0M;
            x = x + 0.1M;
            y = y + 0.1M;
            LblAusgabe.Text = $"x:{x} \ny: {y}";


            
        } 
    }
}
