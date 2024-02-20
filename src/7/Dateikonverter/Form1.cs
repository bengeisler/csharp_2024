// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.Eventing.Reader;

namespace Dateikonverter
{
    public partial class FrmKonveter : Form
    {
        public FrmKonveter()
        {
            InitializeComponent();
        }

        private void CmdLesen_Click(object sender, EventArgs e)
        {
            try
            {
                Listbox1.Items.Clear();
                Listbox2.Items.Clear();

                OpenFileDialog ofd = new OpenFileDialog();
                var ergebnis = ofd.ShowDialog();
                if (ergebnis == DialogResult.OK)
                {
                    var pfad = ofd.FileName;
                    var text = File.ReadAllLines(pfad);
                    foreach (var line in text)
                    {
                        var isNumeric = double.TryParse(line, out double Zahl);
                        if (isNumeric)
                            Listbox1.Items.Add($"{Zahl:0.00}");
                        else
                        {
                            Listbox2.Items.Add(line);

                        }

                    }
                }  

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

            
       
        }

        private void Listbox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmdSchreiben_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new()
                {

                    Title = "Datei Sspeichern",
                    Filter = "Text-Datein|*.txt",
                    InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(),

                };

                if (sfd.ShowDialog() == DialogResult.OK) return;

                List<string> werte  = [];
                foreach (var wert in Listbox1.Items) werte.Add(wert.ToString());
                File.WriteAllLines(sfd.FileName, werte);



            }


            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            {

             
            }









            }
        }
    }

