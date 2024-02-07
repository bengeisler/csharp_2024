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
            LstSpeisen.Items.Add("Tortollini");
            LstSpeisen.Items.Add("Pizza");
            LstSpeisen.Items.Add("Lasagne");

        }

        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            // Ausgewählten Eintrag aus der Liste löschen
            LstSpeisen.Items.Remove(LstSpeisen.SelectedItem);

        }

        private void CmdErsetzten_Click(object sender, EventArgs e)
        {
            // Ausgewähltem Eintrag ersetzen

            int index = LstSpeisen.SelectedIndex; LstSpeisen.Items.RemoveAt(index);

            // Prüfen :
            // Hat der Benutzer etwas in dem Textfeld eingegeben? (ist nicht leer)
            // Hat der Benutzer einen Eintrag ausgewählt? (index != -1)

            if (txtErsetzenDurch.Text != "" && index != -1)
            {
                LstSpeisen.Items.RemoveAt((int)index);
                LstSpeisen.Items.Insert(index, txtErsetzenDurch.Text);
            }
        }

        private void TxtNeu_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdEinfuegen_Click(object sender, EventArgs e)
        {
            if (TxtEinfuegen.Text == "") return;

            if (OptAnfang.Checked)
            {
                LstSpeisen.Items.Insert(0, TxtEinfuegen.Text);

            }
            if (OptElement.Checked)
            {
                int index = LstSpeisen.SelectedIndex;

                if (index != -1)
                {
                    LstSpeisen.Items.Insert(index, TxtEinfuegen.Text);
                }
            }

            if (OptEnde.Checked)

            {
                LstSpeisen.Items.Add(TxtEinfuegen.Text);

            }
        }

        private void CmdAllesLoeschen_Click(object sender, EventArgs e)
        {
            // Alle Einträge löschen
            LstSpeisen.Items.Clear();

                
                }
    }
}
