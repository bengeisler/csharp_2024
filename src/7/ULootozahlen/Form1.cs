// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace ULootozahlen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void CmdZiehung_Click(object sender, EventArgs e)
        {
            List<int> liste = new List<int>();
            Random _random = new();
            int zufallszahl = _random.Next(1,50);
            
            Listbox1.Items.Clear();
            
            while (liste.Count < 6 )
            {

                zufallszahl = _random.Next(1, 50);
                
                if (!liste.Contains(zufallszahl))
                {
                    liste.Add(zufallszahl);
                    Listbox1.Items.Add(zufallszahl);
                }
                    
                liste.Sort();
                textBox1.Text = zufallszahl.ToString();


        }

        }
    }
}
