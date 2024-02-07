// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Drawing.Text;

namespace WinFormsApp1
{
    public partial class CmdButton2 : Form
    {
        public CmdButton2()
        {
            InitializeComponent();
        }



        private void CmdButton1_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Main();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR..\nMissing Logical Nummbers");
            }
        }

        private void CmdButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Main();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Durch 0 Dividiert !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR..\nMissing Logical Nummbers");
            }
               
            
        }
        private void Main()
        {
            int x = Convert.ToInt32(TxtBox1.Text);
            int y = Convert.ToInt32(TxtBox2.Text);
            int z = x / y;
            LblAnzeige1.Text = $"Ergebnis: {z}";
        } 

    }
}
