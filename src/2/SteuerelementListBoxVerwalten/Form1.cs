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
            LstSpeisen.Items.Add("Gr�ne Nudeln");
            LstSpeisen.Items.Add("Tortellini");
            LstSpeisen.Items.Add("Pizza");
            LstSpeisen.Items.Add("Lasagne");
        }

        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            // Ausgw�hlten Eintrag aus der Liste l�schen
            LstSpeisen.Items.Remove(LstSpeisen.SelectedItem);
        }

        private void CmdErsetztendurch_Click(object sender, EventArgs e)
        {
            // Ausgew�hlten Eintrag ersetzten
            int index = LstSpeisen.SelectedIndex;

            // Pr�fen:
            // - Hat der Benutzr etwas in dem Textfeld eingegben?= (ist nicht leer)
            // - Hat der Benutzer einen Eintrag ausgew�hlt? (index != -1)

            if (txtErsetztendurch.Text != "" && index != -1)
            {
                LstSpeisen.Items.RemoveAt(index);
                LstSpeisen.Items.Insert(index, txtErsetztendurch.Text);

            }




        }

        private void CmdEinfuegen_Click(object sender, EventArgs e)
        {
            if (TxtEinf�gen.Text == "") return;

            if (OptAmAnfangderListe.Checked)
            {
                // Am Anfang einf�gen

                LstSpeisen.Items.Insert(0, TxtEinf�gen.Text);


            }
            if (OptVorElement.Checked)
            {   // Vor ausgew�hltem Elemnt einf�gen
                int index = LstSpeisen.SelectedIndex;

                if (index != -1)
                {
                    LstSpeisen.Items.Insert(index, TxtEinf�gen.Text);

                }
            }
            if (OptAmEndederliste.Checked)
            {
                // Am ende einf�gen
                LstSpeisen.Items.Add(TxtEinf�gen.Text);

            }

        }

        private void CmdAllesloeschen_Click(object sender, EventArgs e)
        {
            // Alle Eintr�ge l�schen

            LstSpeisen.Items.Clear();

        }

        private void LstSpeisen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
