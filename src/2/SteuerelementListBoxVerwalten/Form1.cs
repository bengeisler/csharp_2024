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
            LstBox.Items.Add("Sphagetti");
            LstBox.Items.Add("Grüne Nudeln");
            LstBox.Items.Add("Tortellini");
            LstBox.Items.Add("Pizza");
            LstBox.Items.Add("Lasagne");


        }

        private void CmdButton1_Click(object sender, EventArgs e)
        {
            LstBox.Items.Remove(LstBox.SelectedItem);

        }

        private void CmdButton3_Click(object sender, EventArgs e)
        {
            if (RadBtn2.Checked)
            {
                //Mit Inert entscheidest man an welcher stelle der liste man anfängt ( -1,0, 1 etc)
                //Am Anfang einfügen:Index = 0
                LstBox.Items.Insert(0, TxtBtn1.Text);
            }
            if (RadBtn3.Checked)
            {
                //Vorausgewähltem Element einfügen
                int index = LstBox.SelectedIndex;
                //index ist -1, falls nichts ausgewählt wurde
                //an der Stelle -1 kann kein item eingefüft werden!
                if (index != -1)
                {
                    LstBox.Items.Insert(index, TxtBtn1.Text);
                }
            }
            if (RadBtn1.Checked)
            {
                //Am Ende einfügen
                LstBox.Items.Add(TxtBtn1.Text);
            }
        }

        

        private void CmdButton4_Click(object sender, EventArgs e)
        {
            LstBox.Items.Clear();
        }

        private void CmdButton2_Click_1(object sender, EventArgs e)
        {
          //Ausgewählten Eintrag ersetzen
            int index = LstBox.SelectedIndex;
            //Prüfen:
            //Hat der Benutzer etwas in dem Textfeld eingegeben? (ist nicht leer)
            //Hat der Benutzer einen 
            if (TxtBtn2.Text != "" && index != -1)
            {
                LstBox.Items.RemoveAt(index);
                LstBox.Items.Insert(index, TxtBtn2.Text);
            }
        }
    }
}
