// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenFormulare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Eigenschaft
        public bool istOk;

        private void CmdButton_Click(object sender, EventArgs e)
        {
            //Unterformular Anzeigen
            // Neues Objekt von Typ "Form2" erzeugen
            Form2 unterformular = new();

            //Eigenschaften zusweisen
            unterformular.AnzeigeText = TxtBox.Text;

            //-Unterformular anzeigen
            unterformular.ShowDialog();

           
        }
        
    }
}
