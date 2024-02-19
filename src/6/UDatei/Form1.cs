// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using static System.Windows.Forms.LinkLabel;

namespace UDatei
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHinzufuegen_Click(object sender, EventArgs e)
        {
            LstListe.Items.Add(TxtStadt.Text);
            TxtStadt.Text = "";
        }

        private void BtnLoeschen_Click(object sender, EventArgs e)
        {
            LstListe.Items.Remove(LstListe.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LstListe.Items.Clear();
        }

        private void BtnBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSpeichern_Click(object sender, EventArgs e)
        {
            List<string> items = new();

            foreach (var item in LstListe.Items)
            {
                items.Add(item.ToString());
            }
            File.WriteAllLines("Datei.txt", items);
        }

        private void BtnListeLaden_Click(object sender, EventArgs e)
        {

            try
            {
                string[] items = File.ReadAllLines("Datei.txt");
                LstListe.Items.Clear();

                foreach (string item in items)
                {
                    LstListe.Items.Add(item);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void ChkSortiert_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSortiert.Checked == true)
            {
                LstListe.Sorted = true;
            }
            
        }
    }
}
