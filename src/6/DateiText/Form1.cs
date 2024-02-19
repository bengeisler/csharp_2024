// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace DateiText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdButton1_Click(object sender, EventArgs e)
        {
            //Gesamten Text in Datei schreiben
            LstBox.Items.Add($"{TxtBox}");

        }

        private void CmdButton2_Click(object sender, EventArgs e)
        {
            //Gesamten Text in Datei Schreiben
            try
            {
                File.AppendAllText("datei.txt", /*Environment.NewLine oder auch "\r\n"*/ "\r\n" + TxtBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmdButton3_Click(object sender, EventArgs e)
        {
            try
            {
                TxtBox.Text = File.ReadAllText("Datei.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
