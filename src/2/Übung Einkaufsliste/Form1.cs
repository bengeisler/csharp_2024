// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Übung_Einkaufsliste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdButtonAdd_Click(object sender, EventArgs e)
        {
            //Möglichkeit 1:
            //   Mit "+" strings verknüpfen
            //  var neues Item = Numbox.Text + x + TxtBox.Text;
            //Möglichkeit 2:
            // Var neuesItem = $"{


            LstBoxToDo.Items.Add($"{NumBox.Text}x {TxtBox.Text}");

            StatusAktualisieren();
        }




        private void CmdButtonRdy_Click(object sender, EventArgs e)
        {

            //  int index = LstBoxToDo.SelectedIndex;
            if (LstBoxToDo.SelectedItem is not null)
            {
                LstBoxRdy.Items.Add(LstBoxToDo.SelectedItem);
                LstBoxToDo.Items.Remove(LstBoxToDo.SelectedItem);
            }
            StatusAktualisieren();
        }

        private void CmdButtonToDo_Click(object sender, EventArgs e)
        {
            if (LstBoxToDo.SelectedItem is not null)
            {
                LstBoxToDo.Items.Add(LstBoxRdy.SelectedItem);
                LstBoxRdy.Items.Remove(LstBoxRdy.SelectedItem);
            }
            StatusAktualisieren();
        }

        private void CmdButtonDelAll_Click(object sender, EventArgs e)
        {
            LstBoxToDo.Items.Clear();
            LstBoxRdy.Items.Clear();
            StatusAktualisieren();
        }

        private void CmdButtonDel_Click(object sender, EventArgs e)
        {
            LstBoxToDo.Items.Remove(LstBoxToDo.SelectedItem);
            LstBoxRdy.Items.Remove(LstBoxRdy.SelectedItem);
            StatusAktualisieren();
        }

        private void CmdButtonShut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LstBoxToDo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void StatusAktualisieren()
        {
            var itemsErledigt = LstBoxRdy.Items.Count;
            var itemsGesamt = itemsErledigt + LstBoxToDo.Items.Count;
            LblAnzeigeProd.Text = $"{itemsErledigt} / {itemsGesamt}";

        }

    }
}
