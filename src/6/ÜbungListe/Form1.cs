// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace ÜbungListe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdHinzufügen_Click(object sender, EventArgs e)
        {
            LstBox.Items.Add(TxtEingabe.Text);
            TxtEingabe.Text = "";
        }

        private void CmdLöschen_Click(object sender, EventArgs e)
        {
            LstBox.Items.Remove(LstBox.SelectedItem);
        }

        private void CmdAlleLöschen_Click(object sender, EventArgs e)
        {
            LstBox.Items.Clear();
        }

        private void CmdSpeichern_Click(object sender, EventArgs e)
        {
            List<string> items = new List<string>();

            foreach (var item in LstBox.Items)
            {
                items.Add(item.ToString());
            }
            File.WriteAllLines("Datei.txt", items);

        }

        private void CmdBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdLaden_Click(object sender, EventArgs e)
        {
            // Ansatz 1: Alle Zeilen der Datei einlesen und dann
            //           Zeile für Zeile der Liste hinzufügen
            string[] items = File.ReadAllLines("Datei.txt");
            LstBox.Items.Clear();
            foreach (var item in items) LstBox.Items.Add(item);

        }

        private void chkSortiert_CheckedChanged(object sender, EventArgs e)
        {
            LstBox.Sorted = chkSortiert.Checked;
        }
    }
}
