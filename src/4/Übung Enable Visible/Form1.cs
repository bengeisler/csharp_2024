// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Übung_Enable_Visible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // CmdButton.Enabled = LstBox.SelectedItem is null ? false : true;

            if (LstBox.Items.Count < 1)
            {
                CmdButton.Enabled = false;
            }
            else
            {
                CmdButton.Enabled = true;
            }
        }

        private void CmdButton_Click(object sender, EventArgs e)
        {
            LstBox.Items.Remove(LstBox.SelectedItem);
            if (LstBox.SelectedItem == null)
                CmdButton.Enabled = false;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstBox.Items.Add("Liechtenstein");
            LstBox.Items.Add("Malta");
            LstBox.Items.Add("Andorra");
            LstBox.Items.Add("San Marino");
            LstBox.Items.Add("Monaco");
            
        }


        

        private void CmdButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
