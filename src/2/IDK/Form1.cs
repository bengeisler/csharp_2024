// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace IDK
{
    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();

        }
        private decimal x = 0M,y = 0M, z = 0M;
        

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            
            x=x + 0.1M;
            y =y+ 0.1m;
            LblAnzeige.Text = $"x:{x}\n  y:{y}";
        }
        
        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            
            z =z+ 0.1m;
            
            x=x + 0.1M;
            LblAnzeige.Text = $"x:{x}\n  z:{z}";
        }
    }
}
