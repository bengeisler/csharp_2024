// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenIfElse
{
    public partial class GrundlagenIfElse : Form
    {
        public GrundlagenIfElse()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAnzeigen1_Click(object sender, EventArgs e)
        {
            if (NumZahl.Value > 0)
            {
                LblAnzeige.Text = "Positiv";
                //LblAnzeige.ForeColor = Color.Green;
            }
            else
            {
                LblAnzeige.Text = "Negativ";
                //LblAnzeige.ForeColor = Color.Red;
            }
        }

        private void BtnAnzeigen2_Click(object sender, EventArgs e)
        {
            if (NumZahl.Value > 0)
            {
                LblAnzeige.ForeColor = Color.Black;
            }
            else
            {
                LblAnzeige.ForeColor = Color.Red;
            }

            // Ternärer Operator
            LblAnzeige.ForeColor = NumZahl.Value < 0 ? Color.Red : Color.Black;
            //
            //
        }

        private void NumZahl_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
