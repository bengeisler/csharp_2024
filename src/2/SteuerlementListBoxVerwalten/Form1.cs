namespace SteuerlementListBoxVerwalten
{
    public partial class Listbox : Form
    {
        public Listbox()
        {
            InitializeComponent();
        }

        private void Listbox_Load(object sender, EventArgs e)
        {
            LstSpeisen.Items.Add("Spaghetti");
            LstSpeisen.Items.Add("Grüne Nuddeln");
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
            if (TxtErsetzen.Text != "" && index != -1)

            {

                LstSpeisen.Items.RemoveAt(index);
                LstSpeisen.Items.Insert(index, TxtErsetzen.Text);
            }


        }

        private void CmdEinfuegen_Click(object sender, EventArgs e)
        {
            if (TxtNeu.Text =="")  return;    
            if (OptamAnfang.Checked)
            {
                LstSpeisen.Items.Insert(0, TxtNeu.Text);
            }
            if (Optausgewaehlt.Checked)
            {
                int index = LstSpeisen.SelectedIndex;
                if (index != -1)
                {
                    LstSpeisen.Items.Insert(index, TxtNeu.Text);
                }
            }
            if (OptAmEnde.Checked)
            {
                LstSpeisen.Items.Add(TxtNeu.Text);
            }

        }

        private void Cmdallesloeschen_Click(object sender, EventArgs e)
        {
            LstSpeisen.Items.Clear();
        }
    }
}
