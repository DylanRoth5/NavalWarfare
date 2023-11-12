using NavalWarfareV2;

namespace NavalWarfare2._0.Forms;

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
        Program.classic!.Show();
        Hide();
    }

    private void btCoop_Click(object sender, EventArgs e)
    {
        Program.timeRush!.Show();
        Hide();
    }
}