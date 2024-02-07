// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Aufgabe1Einkaufslise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonAllelöschen_Click(object sender, EventArgs e)
        {
            ListboxTodo.Text = "";


        }

        private void ButtonHinzufügen_Click(object sender, EventArgs e)
        {
            ListboxTodo.Items.Add($"{TxtAnzahl.Text} x {TxtBeschreibung.Text}");

        }

        private void Buttonlöschen_Click(object sender, EventArgs e)
        {
            ListboxTodo.Items.Remove(ListboxTodo.SelectedItem);




        }

        private void ButtonNachRechts_Click(object sender, EventArgs e)
        {
            int summe = 0;
            int Produkte;
            ListboxErledigt.Items.Add(ListboxTodo.SelectedItem);
            ListboxTodo.Items.Remove(ListboxTodo.SelectedItem);
            summe = ListboxTodo.Items.Count + ListboxErledigt.Items.Count;
        Produkte = summe - ListboxTodo.Items.Count;
            LblWievielwurdeeingekauft.Text = $"({Produkte}/{summe}Produkte wurden schon eingekauft.";

        }

        private void ButtonnachLinks_Click(object sender, EventArgs e)
        {
            ListboxTodo.Items.Add(ListboxErledigt.SelectedItem);
            ListboxErledigt.Items.Remove(ListboxErledigt.SelectedItem);

        }
    }
}
