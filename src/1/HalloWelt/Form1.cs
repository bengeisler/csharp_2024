namespace HalloWelt;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void BtnHalloWelt_Click(object sender, EventArgs e)
    {
        LblAnzeige.Text = "Hallo,Welt!";
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void BtnBeenden_Click(object sender, EventArgs e)
    {
        // Programm beenden
        Close();

    }
}
