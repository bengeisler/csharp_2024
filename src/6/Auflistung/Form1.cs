// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;

namespace Auflistung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<string> Städte = new List<string>();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(TxtEingabe.Text);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            // BESTER ANSATZ !!!!!!
            File.WriteAllLines("liste.txt", ListBox1.Items.Cast<string>());




            var fs = new FileStream("liste.txt", FileMode.Open);
            var sw = new StreamWriter(fs);
            //Alle einträge der Liste in den Stream schreiben.
            string zeilen = "";
            foreach (var eintrag in ListBox1.Items)
            {
                zeilen += eintrag.ToString() + Environment.NewLine;

            }
            File.WriteAllText("Datei.txt", zeilen);

            try
            {
                foreach (var item in ListBox1.Items) sw.WriteLine(item.ToString());
                sw.Close();
            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }

        }
        private void CmdBeenden_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void CmdAlleLöschen_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            ListBox1.Sorted = checkBox1.Checked;







        }

        private void CmdListeLaden_Click(object sender, EventArgs e)
        {
            // ALle zeilen der datei einlesen und dann Zeile für zeile der List hinzufügen
            string[] items = File.ReadAllLines("liste.txt");
            ListBox1.Items.Clear();
            foreach (var item in items) ListBox1.Items.Add(item);



        }
    }
}
