// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace DateiText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdSchreiben_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText("datei.txt", TxtBox.Text);
            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);

            }



        }

        private void CmdLesen_Click(object sender, EventArgs e)
        {
            try
            {
                TxtBox.Text = File.ReadAllText("datei.txt");
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);


            }
        }

        private void CmdAnhaengen_Click(object sender, EventArgs e)
        {
            try
            {
                File.AppendAllText("datei.txt", "\n" + TxtBox.Text);
            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);

            }
        }

        private void CmdZeilenweiseSchreiben_Click(object sender, EventArgs e)
        {
            try
            {       //EIn Array von Strings in die Datei schreiben
                    // TxtBox.lines: string [] , das die einzelnen Zeilen enthält
                File.WriteAllLines("datei.txt", TxtBox.Lines);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                
            }
        }
    }
}
