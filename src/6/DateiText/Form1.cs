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

        private void CmdSchreiben_Click(object sender, EventArgs e)
        {
            try
            {

                File.WriteAllText("datei.txt", TxtEingabe.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void CmdAnhängen_Click(object sender, EventArgs e)
        {
            try
            {

                File.AppendAllText("datei.txt", Environment.NewLine + TxtEingabe.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void cmdLesen_Click(object sender, EventArgs e)
        {
            try
            {
                TxtEingabe.Text = File.ReadAllText("datei.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }



        }

        private void cmdZeilenWeisenSchreiben_Click(object sender, EventArgs e)
        {
            try
            {   //Ein array von Strings in die Datei schreiben
                // Txt Eingabe.Lines: string[], das die einzelenen Zeilen enthält

                File.WriteAllLines("datei.txt", TxtEingabe.Lines);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
