using NavalWarfareV3;

namespace NavalWarfareV3.Forms;

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
        Program.Classic!.Show();
        Hide();
    }

    private void btCoop_Click(object sender, EventArgs e)
    {
        Program.TimeRush!.Show();
        Hide();
    }
}