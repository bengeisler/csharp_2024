namespace GrundlagenListBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdButton1_Click(object sender, EventArgs e)
        {

        }

        private void LstSpeisen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ereignismethode wird aufgerufen, wenn sich die auswahl ändert
            LblAnzeigen1.Text = $"{LstSpeisen.SelectedItem}";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstSpeisen.Items.Add("Sphagetti");
            LstSpeisen.Items.Add("Grüne Nudeln");
            LstSpeisen.Items.Add("Tortellini");
            LstSpeisen.Items.Add("Pizza");
            LstSpeisen.Items.Add("Lasagne");
        }
    }
}
