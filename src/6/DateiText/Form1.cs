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

        private void BtnSchreiben_Click(object sender, EventArgs e)
        {
            try
            {
                //Gesamten Text in Datei schreiben
                File.WriteAllText("Datei.txt", TxtBox.Text);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAnhaengen_Click(object sender, EventArgs e)
        {
            try
            {
                //Gesamten Text in Datei schreiben
                File.AppendAllText("Datei.txt", Environment.NewLine + TxtBox.Text);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLesen_Click(object sender, EventArgs e)
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

        private void BtnZeilenSchreiben_Click(object sender, EventArgs e)
        {
            try
            {
                //Ein Array von Strings in die Datei schreiben
                //TxtEingabe.Lines: string[], das die einzelnen Zeilen enthält
                File.WriteAllLines("Datei.txt", TxtBox.Lines);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
