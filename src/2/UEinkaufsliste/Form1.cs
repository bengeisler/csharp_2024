// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UEinkaufsliste
{
    public partial class FormEinkaufsliste : Form
    {
        public FormEinkaufsliste()
        {
            InitializeComponent();
        }

        private void Cmdlöschen_Click(object sender, EventArgs e)
        {
            lstToDo.Items.Remove(lstToDo.SelectedItem);
        }

        private void CmdAlleLöschen_Click(object sender, EventArgs e)
        {
            lstToDo.Items.Clear();
            lstErledigt.Items.Clear();

        }

        private void CmdBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdHinzufügen_Click(object sender, EventArgs e)
        {

            lstToDo.Items.Add(txtBoxAnzahl.Text + "x " + TxtBoxBeschreibung.Text);








        }

        private void Cmdnachrechts_Click(object sender, EventArgs e)
        {
            int index = lstToDo.SelectedIndex;

            if (index != -1)
            {
                lstErledigt.Items.Add(lstToDo.SelectedItem);
                lstToDo.Items.Remove(lstToDo.SelectedItem);

            }


        }

        private void Cmdnachlinks_Click(object sender, EventArgs e)
        {
            int index = lstErledigt.SelectedIndex;

            if (index != -1)
            {
                lstToDo.Items.Add(lstErledigt.SelectedItem);
                lstErledigt.Items.Remove(lstErledigt.SelectedItem);


            }

        }
    }
}
