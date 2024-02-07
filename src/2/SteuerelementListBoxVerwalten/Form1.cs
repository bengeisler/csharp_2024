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

        private void CmdLöschen_Click(object sender, EventArgs e)
        {
            // Ausgewählten Eintrag aus der Liste löschen
            LstSpeisen.Items.Remove(LstSpeisen.SelectedItem);
        }

        private void CmdErsetzenDurch_Click(object sender, EventArgs e)
        {
            // Ausgewählten Eintrag ersetzen
            int index = LstSpeisen.SelectedIndex;

            // Prüfen:
            // - Hat der Benutzer etwas in dem Textfeld eingegeben? (ist nicht leer)
            // - Hat der Benutzer einen Eintrag ausgewählt? (index != -1)
            if (TxtErsetzenDurch.Text != "" && index != -1)
            {
                LstSpeisen.Items.RemoveAt(index);
                LstSpeisen.Items.Insert(index, TxtErsetzenDurch.Text);
            }

        }

        private void CmdEinfügen_Click(object sender, EventArgs e)
        {
            // Methode hier verlassen, falls nichts eingegeben wurde
            // ( Beinhaltet eine if-Anweisung nur eine einzige Zeile Code, so können
            //   die geschweiften Klammern weggelassen werden. )
            if (TxtEinfügen.Text == "") return;

            if (OptAnfang.Checked)
            {
                // Am Anfang einfügen: Index = 0
                LstSpeisen.Items.Insert(0, TxtEinfügen.Text);
            }
            if (OptVorAusgewähltemElement.Checked)
            {
                // Vor ausgewähltem Element einfügen
                int index = LstSpeisen.SelectedIndex;

                // Index ist -1, falls nichts ausgewählt wurde
                // An der Stelle -1 kann kein Item eingefügt werden!
                if (index != -1)
                {
                    LstSpeisen.Items.Insert(index, TxtEinfügen.Text);
                }
            }
            if (OptEnde.Checked)
            {
                // Am Ende einfügen
                LstSpeisen.Items.Add(TxtEinfügen.Text);
            }
        }

        private void CmdAllesLöschen_Click(object sender, EventArgs e)
        {
            // Alle Einträge löschen
            LstSpeisen.Items.Clear();
        }
    }
}
