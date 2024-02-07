namespace GrundlagenListbox3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige3_Click(object sender, EventArgs e)
        {

        }

        private void LstSpeisen_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblAnzeige1.Text = $"{LstSpeisen.SelectedItem}";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstSpeisen.Items.Add("Spagehtti");
            LstSpeisen.Items.Add("Grüne Nudeln");
            LstSpeisen.Items.Add("Tortelini");
            LstSpeisen.Items.Add("Pizza");
            LstSpeisen.Items.Add("Lasagne");
        }
    }
}
