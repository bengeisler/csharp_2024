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

        private void CmdL�schen_Click(object sender, EventArgs e)
        {
            // Ausgew�hlten Eintrag aus der Liste l�schen
            LstSpeisen.Items.Remove(LstSpeisen.SelectedItem);
        }

        private void CmdErsetzenDurch_Click(object sender, EventArgs e)
        {
            // Ausgew�hlten Eintrag ersetzen
            int index = LstSpeisen.SelectedIndex;

            // Pr�fen:
            // - Hat der Benutzer etwas in dem Textfeld eingegeben? (ist nicht leer)
            // - Hat der Benutzer einen Eintrag ausgew�hlt? (index != -1)
            if (TxtErsetzenDurch.Text != "" && index != -1)
            {
                LstSpeisen.Items.RemoveAt(index);
                LstSpeisen.Items.Insert(index, TxtErsetzenDurch.Text);
            }

        }

        private void CmdEinf�gen_Click(object sender, EventArgs e)
        {
            // Methode hier verlassen, falls nichts eingegeben wurde
            // ( Beinhaltet eine if-Anweisung nur eine einzige Zeile Code, so k�nnen
            //   die geschweiften Klammern weggelassen werden. )
            if (TxtEinf�gen.Text == "") return;

            if (OptAnfang.Checked)
            {
                // Am Anfang einf�gen: Index = 0
                LstSpeisen.Items.Insert(0, TxtEinf�gen.Text);
            }
            if (OptVorAusgew�hltemElement.Checked)
            {
                // Vor ausgew�hltem Element einf�gen
                int index = LstSpeisen.SelectedIndex;

                // Index ist -1, falls nichts ausgew�hlt wurde
                // An der Stelle -1 kann kein Item eingef�gt werden!
                if (index != -1)
                {
                    LstSpeisen.Items.Insert(index, TxtEinf�gen.Text);
                }
            }
            if (OptEnde.Checked)
            {
                // Am Ende einf�gen
                LstSpeisen.Items.Add(TxtEinf�gen.Text);
            }
        }

        private void CmdAllesL�schen_Click(object sender, EventArgs e)
        {
            // Alle Eintr�ge l�schen
            LstSpeisen.Items.Clear();
        }
    }
}
