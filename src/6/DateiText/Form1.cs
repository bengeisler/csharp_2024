// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Linq.Expressions;

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

        private void CmdAnhaengen_Click(object sender, EventArgs e)
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

        private void CmdLesen_Click(object sender, EventArgs e)
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

        private void CmdReihenweise_Click(object sender, EventArgs e)
        {
            try
            {
                // Ein Array Strings in die Datei schreiben
                // TxtEingabe.Lines: string[], das die einzelnen Zeilen enthält

                File.WriteAllLines("Datei.txt", TxtEingabe.Lines);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
    }
}
