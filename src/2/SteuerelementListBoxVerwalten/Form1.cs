using System.Diagnostics.Eventing.Reader;

namespace SteuerelementListBoxVerwalten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstSpeisen.Items.Add("Spaghetti");
            LstSpeisen.Items.Add("Grüne Nudeln");
            LstSpeisen.Items.Add("Tortellini");
            LstSpeisen.Items.Add("Pizza");
            LstSpeisen.Items.Add("Lasagne");
        }

        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            LstSpeisen.Items.Remove(LstSpeisen.SelectedItem);
        }

        private void CmdErsetzen_Click(object sender, EventArgs e)
        {
            int index = LstSpeisen.SelectedIndex;


            if (CmdErsetzen.Text != "" && index != -1)
            {
                LstSpeisen.Items.RemoveAt(index);
                LstSpeisen.Items.Insert(index, TxtAusgabe1.Text);
            }


        }

        private void CmdEinfuegen_Click(object sender, EventArgs e)
        {
            if (txtbox2.Text == "") return;


            if (OptAnfang.Checked)
            {
                LstSpeisen.Items.Insert(0, txtbox2.Text);

                if (OptVorElement.Checked)
                {
                    int index = LstSpeisen.SelectedIndex;

                    if (index != -1)
                    {
                        LstSpeisen.Items.Insert(index, txtbox2.Text);
                    }

                }

                if (OptEnde.Checked)
                {
                    LstSpeisen.Items.Add(txtbox2.Text);
                }







            }
        }

        private void CmdAllesLoeschen_Click(object sender, EventArgs e)
        {
            LstSpeisen.Items.Clear();
        }
    }
}
