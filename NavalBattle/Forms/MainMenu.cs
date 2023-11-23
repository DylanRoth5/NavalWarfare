namespace NavalBattle.Forms;

public partial class MainMenu : Form
{
    public MainMenu()
    {
        InitializeComponent();
        // WindowState = FormWindowState.Maximized; 
    }

    private void lbTitle_Click(object sender, EventArgs e)
    {
    }

    private void btSolo_Click(object sender, EventArgs e)
    {
        Program.NewMatch = true;
        Program.Classic!.Show();
        Hide();
    }

    private void btCoop_Click(object sender, EventArgs e)
    {
        Program.TimeRush!.Show();
        Hide();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        Program.NewMatch = false;
        Program.Classic!.Show();
        Hide();
    }
}