namespace HalloWelt;

public partial class form1 : Form
{
    public form1()
    {
        InitializeComponent();
    }

    private void BtnHalloWelt_Click(object sender, EventArgs e)
    {
        LblAnzeige.Text = "Hallo, Welt!";
    }
}
