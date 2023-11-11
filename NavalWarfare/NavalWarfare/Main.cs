namespace NavalWarfare
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void btSolo_Click(object sender, EventArgs e)
        {
            Program.solo.Show();
            Hide();
        }

        private void btCoop_Click(object sender, EventArgs e)
        {
            Program.coop.Show();
            Hide();
        }
    }
}