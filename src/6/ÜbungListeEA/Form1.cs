// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics.Eventing.Reader;

namespace ÜbungListeEA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdButton1_Click(object sender, EventArgs e)
        {
            LstBox.Items.Add($"{TxtBox2.Text}");
            TxtBox2.Text = ("");
        }

        private void CmdButton2_Click(object sender, EventArgs e)
        {
            int index = LstBox.SelectedIndex;

            if (LstBox.Text != "" && index != -1)

                LstBox.Items.RemoveAt(index);

        }


        private void CmdButton4_Click(object sender, EventArgs e)
        {
            // try
            // {
            //     LstBox.Items.Add = File.ReadAllText("datei.txt");
            // }
            // catch (Exception ex)
            // {
            //     MessageBox.Show(ex.Message);
            // }

            string[] items = File.ReadAllLines("datei.txt");
            LstBox.Items.Clear();
            foreach (var item in items) LstBox.Items.Add(item);


        }

        private void CmdButton6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdButton3_Click(object sender, EventArgs e)
        {
            LstBox.Items.Clear();
        }

        private void CmdButton5_Click(object sender, EventArgs e)
        {
            //  try
            //  {
            //      File.WriteAllText("datei.txt", LstBox.Items.Cast<string>());
            //  }
            //  catch (Exception ex)
            //  {
            //      MessageBox.Show(ex.Message);
            //  }

            /*try
            {
                var fs = new FileStream("liste.txt", FileMode.Open);
                var sw = new StreamWriter(fs);
                foreach (var item in LstBox.Items) sw.WriteLine(item); sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
            try
            {
                string zeilen = "";
                foreach (var eintrag in LstBox.Items) { zeilen += eintrag.ToString() + Environment.NewLine; }
                File.WriteAllText("datei.txt", zeilen);
            }
            catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);
              }
        }

            private void ChkBox_CheckedChanged(object sender, EventArgs e)
        {
            LstBox.Sorted = ChkBox.Checked;
        }
            
    }
}

