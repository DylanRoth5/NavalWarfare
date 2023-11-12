namespace NavalWarfareV2;

public partial class MainMenu : Form
{
    public MainMenu()
    {
        InitializeComponent();
        WindowState = FormWindowState.Maximized;
    }
    private void lbTitle_Click(object sender, EventArgs e)
    {

    }

    private void btSolo_Click(object sender, EventArgs e)
    {
     Program.clasic.Show();
     Hide();
    }

    private void btCoop_Click(object sender, EventArgs e)
    {
     Program.timeRush.Show();
     Hide();
    }
}