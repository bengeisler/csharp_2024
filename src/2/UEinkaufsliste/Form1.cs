// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UEinkaufsliste
{
    public partial class Einkaufsliste : Form
    {
        public Einkaufsliste()
        {
            InitializeComponent();
        }

        private void CmdBeenden_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void CmdAllesLoeschen_Click(object sender, EventArgs e)
        {
            LstErledigt.Items.Clear();
            LstToDo.Items.Clear();
        }

        private void TxtAnzahl_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdHinzufügen_Click(object sender, EventArgs e)
        {
            LstToDo.Items.Add($"{TxtAnzahl.Text} x {TxtBeschreibung.Text}");

        }

        private void Cmdloeschen_Click(object sender, EventArgs e)
        {
            LstToDo.Items.Remove(LstToDo.SelectedItem);
        }

        private void CmdToErledigt_Click(object sender, EventArgs e)
        {
            int summe = 0;
            int Produkte;
            LstErledigt.Items.Add(LstToDo.SelectedItem);
            LstToDo.Items.Remove(LstToDo.SelectedItem);
            summe = LstToDo.Items.Count + LstErledigt.Items.Count;
            Produkte = summe - LstToDo.Items.Count;
            LblAnzeigen.Text = $"({Produkte}/{summe} Produkte wurden schon eingekauft)";
        }


        private void CmdToDo_Click(object sender, EventArgs e)
        {
            LstToDo.Items.Add(LstErledigt.SelectedItem);
            LstErledigt.Items.Remove(LstErledigt.SelectedItem);

        }
    }
}
