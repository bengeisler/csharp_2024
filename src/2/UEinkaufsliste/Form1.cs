// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UEinkaufsliste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstToDo.Items.Add("Milch");
            LstToDo.Items.Add("Brot");
            LstErledigt.Items.Add("Nuddeln");
        }

        private void LstErledigt_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (string s in LstToDo.SelectedItems)
                LstErledigt.Items.Add(s);
            for (int i = LstToDo.SelectedItems.Count - 1; i >= 0; i--)
                LstToDo.Items.RemoveAt(LstToDo.SelectedIndices[i]);
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnAllesLoeschen_Click(object sender, EventArgs e)
        {
            LstToDo.Items.Clear();
            LstErledigt.Items.Clear();

        }

        private void btnHinzufügen_Click(object sender, EventArgs e)
        {
            if (txtAnzahl.Text == "") ;
            return;
                LstToDo.Items.Insert(0, tx)
        }

        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            int x = LstToDo.SelectedIndex;
            if (x != -1)
                LstToDo.Items.RemoveAt(x);


        }

        private void txtAnzahl_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRechts_Click(object sender, EventArgs e)
        {
            foreach (string s in LstErledigt.SelectedItems)
                LstToDo.Items.Add(s);
            for (int i = LstErledigt.SelectedItems.Count - 1; i >= 0; i--)
                LstErledigt.Items.RemoveAt(LstErledigt.SelectedIndices[i]);
        }

        private void txtBezeichnung_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
