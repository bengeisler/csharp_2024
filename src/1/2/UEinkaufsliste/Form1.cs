namespace UEinkaufsliste;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void cmdLöschen_Click(object sender, EventArgs e)
    {
        lstToDo.Items.Remove(lstToDo.SelectedItem);
        lstErledigt.Items.Remove(lstErledigt.SelectedItem);
    }

    private void cmdAllesLöschen_Click(object sender, EventArgs e)
    {
        lstToDo.Items.Clear();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    
    }

    private void cmdBeenden_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void cmdHinzufügen_Click(object sender, EventArgs e)
    {

        lstToDo.Items.Add(txtAnzahl.Text + "x " + txtBeschreibung.Text);


    }

    private void cmdrechts_Click(object sender, EventArgs e)
    {
        int index = lstToDo.SelectedIndex;

        if (index != -1)
        {
            lstErledigt.Items.Add(lstToDo.SelectedItem);
            lstToDo.Items.Remove(lstToDo.SelectedItem);
        }

    }

    private void cmdlinks_Click(object sender, EventArgs e)
    {
        int index = lstErledigt.SelectedIndex;

        if (index != -1)
        {
            lstToDo.Items.Add(lstErledigt.SelectedItem);
            lstErledigt.Items.Remove(lstErledigt.SelectedItem);
        }
    }
}
