// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Metrics;

namespace Verein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Beenden_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void CmdMitgliederLöschen_Click(object sender, EventArgs e)
        {
            ListboxMitglieder.Items.Remove(ListboxMitglieder.SelectedItem);



            

        }

        private void CmdÜbernehmen_Click(object sender, EventArgs e)
        {
            string Ausgabe = "";
            

            try
            {
                int Alter = Convert.ToInt32(TxtAlter.Text);
                string Name = TxtName.Text;


                if (Name == "")
                {
                    LblFehlermeldung.Text = "Bitte Name eingeben";

                }
                else if (TxtAlter.Text == "") LblFehlermeldung.Text = "Alter eingeben ";

                else if (!int.TryParse(TxtAlter.Text, out int alter))
                    throw new ArgumentException("Bitte Zahl eingeben");

                else if (Alter < 18)
                {
                    LblFehlermeldung.Text = "Kinder werden nicht akzeptiert";

                }
                else if (Alter > 68)
                {
                    LblFehlermeldung.Text = "Rentner sind zu alt";
                }
                else if (!RadioButtonBlau.Checked) LblFehlermeldung.Text = "Mitglieder der Lieblingsfarbe rot werden nicht gerne gesehen";
                else if (RadioButtonRot.Checked) LblFehlermeldung.Text = "Mitglieder der Lieblingsfarbe rot werden nicht gerne gesehen";
                else if (ListboxMitglieder.Items.Count > 4) LblFehlermeldung.Text = "Verein hat schon 5 Member alle weiteren werden abgelehnt";
                else if (!RadioButtonBlau.Checked && !RadioButtonRot.Checked) LblFehlermeldung.Text = "Es wurde keine Lieblingsfarbe ausgewählt";
                else if (Name == "Peter") LblFehlermeldung.Text = "Wir mögen keine Peter";
                else
                {
                    Ausgabe = Name + "," + Alter + " Jahre";
                    //ListboxMitglieder.Items.Clear();
                    ListboxMitglieder.Items.Add(Ausgabe);
                }


            }
                


            catch (Exception)
            {

                
            }

            


        }
    }    }
