// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            //Variable Deklarieren
            int x = 42;
            // Das funktioniert nicht:
            //LblAnzeigentext=x;
            //Variable in String mwandeln und der text.Eigenschaft zuweisen
            LblAnzeige.Text = x.ToString();
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int x = 42;

            //Ausgebe mit String Interpolation
            //Wert : 42

            //Ausgabe {x}wird angezeigt
            LblAnzeige.Text = $"{x}";

            //Wert 42 wird angezeigt
            //Wert in geschwiften Klammern wird in sting umgewandelt
            LblAnzeige.Text = $"{x}";
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int a = 25, b = 17;
            // c = a + b;
            // \n =zeilenumbruch
            LblAnzeige.Text = $"Ergebnis der Berechnung: \n {a} + {b} = {a + b}";
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            int a=25,b=17,c=17;
            
            //ausgabe der berechung in einer messagebox
           
            MessageBox.Show($"Ergebnis der Berechnung: \n {a} + {b} = {a + b}");
            
            LblAnzeige.Text = "Ende";
        }
    }
}
