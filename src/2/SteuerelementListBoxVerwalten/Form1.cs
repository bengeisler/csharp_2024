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
            // Ausgwählten Eintrag aus der Liste löschen
            LstSpeisen.Items.Remove(LstSpeisen.SelectedItem);
        }

        private void CmdErsetztendurch_Click(object sender, EventArgs e)
        {
            // Ausgewählten Eintrag ersetzten
            int index = LstSpeisen.SelectedIndex;

            // Prüfen:
            // - Hat der Benutzr etwas in dem Textfeld eingegben?= (ist nicht leer)
            // - Hat der Benutzer einen Eintrag ausgewählt? (index != -1)

            if (txtErsetztendurch.Text != "" && index != -1)
            {
                LstSpeisen.Items.RemoveAt(index);
                LstSpeisen.Items.Insert(index, txtErsetztendurch.Text);

            }




        }

        private void CmdEinfuegen_Click(object sender, EventArgs e)
        {
            if (TxtEinfügen.Text == "") return;

            if (OptAmAnfangderListe.Checked)
            {
                // Am Anfang einfügen

                LstSpeisen.Items.Insert(0, TxtEinfügen.Text);


            }
            if (OptVorElement.Checked)
            {   // Vor ausgewähltem Elemnt einfügen
                int index = LstSpeisen.SelectedIndex;

                if (index != -1)
                {
                    LstSpeisen.Items.Insert(index, TxtEinfügen.Text);

                }
            }
            if (OptAmEndederliste.Checked)
            {
                // Am ende einfügen
                LstSpeisen.Items.Add(TxtEinfügen.Text);

            }

        }

        private void CmdAllesloeschen_Click(object sender, EventArgs e)
        {
            // Alle Einträge löschen

            LstSpeisen.Items.Clear();

        }

        private void LstSpeisen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
