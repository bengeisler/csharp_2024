// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UEinkaufsliste
{
    public partial class FrmEinkaufsliste : Form
    {
        public FrmEinkaufsliste()
        {
            InitializeComponent();
        }

        private void CmdHinzufuegen_Click(object sender, EventArgs e)
        {

            var rein = TxtAnzahl.Text;

            if (TxtAnzahl.Text == "" || TxtBeschreibung.Text == "") return;

            if (TxtAnzahl.Text != "")
            {

                rein += $"x {TxtBeschreibung.Text}";

                LstToDo.Items.Add(rein);
                rein = "";
            }


        }

        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            LstToDo.Items.Remove(LstToDo.SelectedItem);
        }

        private void CmdAlleLoeschen_Click(object sender, EventArgs e)
        {
            LstToDo.Items.Clear();
        }

        private void CmdBeenden_Click(object sender, EventArgs e)
        {

        }

        private void CmdRechts_Click(object sender, EventArgs e)
        {
            int x = LstToDo.SelectedIndex.


            if (x == -1)
            {
                int index = LstToDo.SelectedIndex;

                LstErledigt.Items.Insert(index, LstToDo.Text);
                LstToDo.Items.RemoveAt(index);


            }

           

        }

        private void CmdLinks_Click(object sender, EventArgs e)
        {
            int index = LstErledigt.SelectedIndex;

            LstToDo.Items.Insert(index, LstErledigt.Text);
            LstErledigt.Items.RemoveAt(index);
        }

        private void label1_Click(object sender, EventArgs e)
        {

            int Vorne = LstToDo.Items.Count;
            int Hinten = LstErledigt.Items.Count;



            label1.Text = $"{Vorne} / {Hinten} Produkte wurden schon eingekauft.";




        }
    }
}
