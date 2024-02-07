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

        private void cmdLoeschen_Click(object sender, EventArgs e)
        {
            // Ausgewählten Eintrag aus der Liste löschen
            LstSpeisen.Items.Remove(LstSpeisen.SelectedItem);
        }

        private void cmdErsetzen_Click(object sender, EventArgs e)
        {
            // Ausgewählten Eintrag ersetzen
            int index = LstSpeisen.SelectedIndex;

            // Prüfen
            // - Hat der Benutzer etwas in dem Textfeld eingegeben? (ist nicht leer)
            // - Hat der Benutzer einen Eintrag ausegwählt (index != -1)
            if (txtErsetzen.Text != "" && index != -1)
            {
                LstSpeisen.Items.RemoveAt(index);
                LstSpeisen.Items.Insert(index, txtErsetzen.Text);
            }

        }

        private void cmdEinfuegen_Click(object sender, EventArgs e)
        {
            if (optAnfang.Checked)
            {
                // Am Anfang einfügen: Index = 0
                LstSpeisen.Items.Insert(0, txtElement.Text);
            }
            if (optEnde.Checked)
            {
                // Am Ende einfügen
                LstSpeisen.Items.Add(txtElement.Text);
            }
            if (optAusgewaehlt.Checked)
            {
                // Vor ausgewähltem Element einfügen
                int index = LstSpeisen.SelectedIndex;

                // Index ist -1, alls nichts ausgewählt wurde
                // An der Stelle -1 kann kein Item eingefügt werden!
                if (index != -1)
                {
                    LstSpeisen.Items.Insert(index, txtElement.Text);
                }

            }
        }

        private void cmdAllesLoeschen_Click(object sender, EventArgs e)
        {
            // Alle Einträge löschen
            LstSpeisen.Items.Clear();
        }
    }
}
