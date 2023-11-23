using NavalWarfareV3;
using System.Drawing;

namespace NavalWarfareV3.Forms;

public partial class MainMenu : Form
{
    public MainMenu()
    {
        InitializeComponent();
        WindowState = FormWindowState.Maximized;

        btCoop.BackColor = Color.FromArgb(128, Color.Black);
        btSolo.BackColor = Color.FromArgb(128, Color.Black);
    }

    private void lbTitle_Click(object sender, EventArgs e)
    {
    }

    private void btSolo_Click(object sender, EventArgs e)
    {
        //Program.Classic!.Show();
        time_Rush();

        //Hide();
    }

    private void time_Rush()
    {
        plSolo.Visible = true;
        plSolo.Dock = DockStyle.Fill;

        // Crear un nuevo Bitmap para el panel principal
        Bitmap bitmap = new Bitmap(plSolo.Width, plSolo.Height);

        using (Graphics graphics = Graphics.FromImage(bitmap))
        {
            // Cargar la imagen desde un archivo (reemplaza con tu ruta de archivo)
            Image image = Image.FromFile("Fondo1.jpg");

            // Dibujar la imagen en el Bitmap
            graphics.DrawImage(image, new Point(0, 0));
        }

        // Establecer el fondo del panel principal con el Bitmap creado
        plSolo.BackgroundImage = bitmap;

        plJuego.Parent = plSolo; // Importante para que la transparencia funcione correctamente

        plJuego.Location = new Point((plSolo.Width - plJuego.Width) / 2, (plSolo.Height - plJuego.Height) / 2);
        plTools.Parent = plSolo;

    }

    private void classic()
    {
        plCoop.Visible = true;
        plCoop.Dock = DockStyle.Fill;

        // Crear un nuevo Bitmap para el panel principal
        Bitmap bitmap = new Bitmap(plCoop.Width, plCoop.Height);

        using (Graphics graphics = Graphics.FromImage(bitmap))
        {
            // Cargar la imagen desde un archivo (reemplaza con tu ruta de archivo)
            Image image = Image.FromFile("Fondo1.jpg");

            // Dibujar la imagen en el Bitmap
            graphics.DrawImage(image, new Point(0, 0));
        }

        // Establecer el fondo del panel principal con el Bitmap creado
        plCoop.BackgroundImage = bitmap;

        plPlayer1.Parent = plCoop;
        plPlayer2.Parent = plCoop;// Importante para que la transparencia funcione correctamente

        plToolsCoop.Parent = plCoop;
    }

    private void btCoop_Click(object sender, EventArgs e)
    {
        classic();
        //Program.TimeRush!.Show();
        //Hide();
    }

    private void btPause_Click(object sender, EventArgs e)
    {
        menuPause();

    }

    private void menuPause()
    {
        plPause.Visible = true;
        plPause.BringToFront();
    }

    private void btPauseCoop_Click(object sender, EventArgs e)
    {
        menuPause();
    }

    private void btBackToGame_Click(object sender, EventArgs e)
    {
        plPause.Visible = false;
    }

    private void btSave_Click(object sender, EventArgs e)
    {
        plCoop.Visible = false;
        plSolo.Visible = false;
    }
}