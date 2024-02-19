// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
            OpenFileDialog ofd = new()
            {
                Multiselect = true, //Erlaubte Merfachauswahl
                InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(),
                Filter = "Texte (*.txt; *.docx| *.txt;*docx|",
                Title = "Datei zum Öffnen auswählen"
            };
            
            
        }
        private void CmdButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new()
            {
                InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(),
                Filter = "Texte (*.txt; *.docx| *.txt;*docx|",
                Title = "Datei zum Öffnen auswählen"
            };
        }
    }
}
