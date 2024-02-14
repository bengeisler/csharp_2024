// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.Metrics;

namespace UComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int counterToDo;
        private int counterErledigt;
        private int counter;

        private void BtnHinzufuegen_Click(object sender, EventArgs e)
        {
            string anzahl = TxtAnzahl.Text;
            string beschreibung = TxtBeschreibung.Text;

            LstToDo.Items.Add($"{anzahl}x {beschreibung}");

            //counterToDo = LstToDo.Items.Count;

            counter++;

            LblAusgabe.Text = $"{counterErledigt.ToString()}/{counter.ToString()}";

        }

        private void BtnLoeschen_Click(object sender, EventArgs e)
        {
            int ausgewählt = LstToDo.SelectedIndex;

            if (ausgewählt != -1)
            {
                LstToDo.Items.Remove(LstToDo.SelectedItem);
                counterToDo = LstToDo.Items.Count;
                counter--;
                counterErledigt = LstErledigt.Items.Count;
                LblAusgabe.Text = $"{counterErledigt.ToString()}/{counter.ToString()}";
            }
        }

        private void BtnAllesLoeschen_Click(object sender, EventArgs e)
        {

            counterToDo = LstToDo.Items.Count;

            counter = counter - counterToDo;
            LstToDo.Items.Clear();
            LblAusgabe.Text = $"{counterErledigt.ToString()}/{counter.ToString()}";
        }

        private void BtnRechts_Click(object sender, EventArgs e)
        {
            int ausgewählt = LstToDo.SelectedIndex;

            if (ausgewählt != -1)
            {
                LstErledigt.Items.Add(LstToDo.SelectedItem);
                LstToDo.Items.Remove(LstToDo.SelectedItem);

                //counterToDo = LstToDo.Items.Count;
                counterErledigt = LstErledigt.Items.Count;
                LblAusgabe.Text = $"{counterErledigt.ToString()}/{counter.ToString()}";
            }

        }

        private void BtnLinks_Click(object sender, EventArgs e)
        {

            int ausgewählt = LstErledigt.SelectedIndex;

            if (ausgewählt != -1)
            {
                LstToDo.Items.Add(LstErledigt.SelectedItem);
                LstErledigt.Items.Remove(LstErledigt.SelectedItem);

                //counterToDo = LstToDo.Items.Count;
                counterErledigt = LstErledigt.Items.Count;
                LblAusgabe.Text = $"{counterErledigt.ToString()}/{counter.ToString()}";
            }

        }

        private void BtnBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
