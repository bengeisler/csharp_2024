// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UListe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdBeenden_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void CmdHinzufuegen_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText("datei.txt", TxtStadt.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void CmdAllesLoeschen_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();

        }

        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            lstBox.Items.Remove(lstBox.SelectedItem);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstBox.Items.Add("München");
            lstBox.Items.Add("Hamburg");
            lstBox.Items.Add("Berlin");
            lstBox.Items.Add("Frankfurt");
            lstBox.Items.Add("Hannover");

        }

        private void TxtStadt_TextChanged(object sender, EventArgs e)
        {
            if (TxtStadt.Text == "") return;


        }

        private void CmdLaden_Click(object sender, EventArgs e)
        {
            // Ansatz1 Alle Zeilen der Datei einlesen und dann
            // Zeile für Zeile der Liste hinzufügen
            var items = File.ReadAllLines("liste.txt");
            lstBox.Items.Clear();
            foreach (var item in items) lstBox.Items.Add(item);


        }

        private void CmdSpeichern_Click(object sender, EventArgs e)
        {
            List<string> items = new List<string>();

            foreach (var item in lstBox.Items)
            {
                items.Add(item.ToString());
            }
            File.WriteAllLines("Datei.txt", items);

            // Ansatz 2: StreamWriter
            var fs = new FileStream("liste.txt", FileMode.Open);
            var sw = new StreamWriter(fs);
            foreach (var item in lstBox.Items) sw.WriteLine(item);
            sw.Close();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lstBox.Sorted = checkBox1.Checked;

        }
    }
}
