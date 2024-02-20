// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Security.Cryptography;
using System.Windows.Forms;

namespace ÜbungUnbekannt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdButton1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();

                var ergebnis = ofd.ShowDialog();
                if (ergebnis == DialogResult.OK)
                {
                    var pfad = ofd.FileName;
                    var text = File.ReadAllLines(pfad);
                    foreach (var item in text) LstBox1.Items.Add(item);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            


        }
        private void CmdButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new()
            {
                InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(),
                Filter = "Tabellen (*.xlsx)|*.xlsx|"
                + "Texte (*.txt; *.docx| *.txt;*docx|"
                + "Alle Dateien (*.*)|(*.*)",
                Title = "Datei zum Öffnen auswählen"
            };
        }
    }
}
