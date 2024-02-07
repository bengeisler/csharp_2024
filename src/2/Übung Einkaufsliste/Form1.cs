// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Windows.Forms;

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
            if (TxtBox != "" && Index = -1)
            {
                LstBoxToDo.Items.Add(TxtBox.Text);
            }
        }

        private void CmdButtonRdy_Click(object sender, EventArgs e)
        {
            LstBoxRdy.Items.Add(LstBoxToDo.SelectedItem);
            LstBoxToDo.Items.Remove(LstBoxToDo.SelectedItem);

        }

        private void CmdButtonToDo_Click(object sender, EventArgs e)
        {
            LstBoxToDo.Items.Add(LstBoxRdy.SelectedItem);
            LstBoxRdy.Items.Remove(LstBoxRdy.SelectedItem);
        }

        private void CmdButtonDelAll_Click(object sender, EventArgs e)
        {
            LstBoxToDo.Items.Clear();
            LstBoxRdy.Items.Clear();
        }

        private void CmdButtonDel_Click(object sender, EventArgs e)
        {
            LstBoxToDo.Items.Remove(LstBoxToDo.SelectedItem);
            LstBoxRdy.Items.Remove(LstBoxRdy.SelectedItem);
        }

        private void CmdButtonShut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
