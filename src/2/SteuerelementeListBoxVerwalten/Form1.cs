namespace SteuerelementeListBoxVerwalten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstBox.Items.Add("Spaghetti");
            LstBox.Items.Add("Grüne Nudeln");
            LstBox.Items.Add("Tortellini");
            LstBox.Items.Add("Pizza");
            LstBox.Items.Add("Lasagne");
        }

        private void BtnLoeschen_Click(object sender, EventArgs e)
        {
            LstBox.Items.Remove(LstBox.SelectedItem);
        }

        private void BtnErsetzen_Click(object sender, EventArgs e)
        {
            int index = LstBox.SelectedIndex;

            if (TxtErsetzen.Text != "" && index != -1)
            {
                LstBox.Items.RemoveAt(index);
                LstBox.Items.Insert(index, TxtErsetzen.Text);
            }
        }

        private void BtnEinfuegen_Click(object sender, EventArgs e)
        {

            if (TxtNeuesElement.Text == "")
            {
                return;
            }

            if (OptAnfang.Checked)
            {
                LstBox.Items.Insert(0, TxtErsetzen.Text);
            }



            if (OptAusgewaehlt.Checked)
            {
                //Vor ausgewähltem Element einfügen
                int index = LstBox.SelectedIndex;

                //Index ist -1, falls nichts aufwählt wurde
                //An der Stelle -1 kann kein Item eingefügt werden!
                if (index != -1)
                {
                    LstBox.Items.Insert(index, TxtNeuesElement.Text);
                }
            }

            if (OptEnde.Checked)
            {
                LstBox.Items.Add(TxtNeuesElement.Text);
            }
        }

        private void BtnAllesLoeschen_Click(object sender, EventArgs e)
        {
            LstBox.Items.Clear();
        }
    }
}
