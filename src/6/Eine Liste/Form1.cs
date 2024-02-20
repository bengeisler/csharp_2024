// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Eine_Liste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdHinzufügen_Click(object sender, EventArgs e)
        {
            ListBox.Items.Add(TxtEingabe.Text);
            TxtEingabe.Text = "";

        }

        private void cmdLöschen_Click(object sender, EventArgs e)
        {

            ListBox.Items.Remove(ListBox.SelectedItem);


        }

        private void cmdAlleLöschen_Click(object sender, EventArgs e)
        {
            ListBox.Items.Clear();


        }

        private void cmdBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdListeladen_Click(object sender, EventArgs e)
        {
            try
            {

                File.AppendAllText("datei.txt", Environment.NewLine + ListBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void cmdSpeichern_Click(object sender, EventArgs e)
        {

            List<string> items = new List<string>();

            foreach (var item in ListBox.Items)
            {
                items.Add(item.ToString());
            }
            File.WriteAllLines("Datei.txt", items);













        }

        private void ChkSortiert_CheckedChanged(object sender, EventArgs e)
        {
            ListBox.Sorted = ChkSortiert.Checked;

        }
    }
}
