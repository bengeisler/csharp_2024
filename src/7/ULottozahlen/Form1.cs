// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace ULottozahlen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void BtnZiehen_Click(object sender, EventArgs e)
        {
            Random _random = new();
            List<int> _list = new();

            int i = 0;

            _list.Clear();
            LstBox.Items.Clear();

            do
            {
                int zufallszahl = _random.Next(1, 50);
                //zahlen.Add(zufallszahl);
                if (!_list.Contains(zufallszahl))
                {
                    _list.Add(zufallszahl);
                    //LstBox.Items.Add(zufallszahl);
                    i++;
                }
            } while (i < 6);

            TxtZusatzZahl.Text = _random.Next(1, 50).ToString();

            _list.Sort();

            foreach (var item in _list)
            {
                LstBox.Items.Add(item);
            }
        }
    }
}
