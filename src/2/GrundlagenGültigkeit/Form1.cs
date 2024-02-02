// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace GrundlagenGültigkeit
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
        private int Mx = 0;
        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int x = 0;
            x++;

            Mx++;

            LblAnzeigen.Text = $"x:{x}, Mx: {Mx}";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int x = 0;

            Mx++;

            LblAnzeigen.Text = $"x:{x}, Mx: {Mx}";
        }
    }
}

