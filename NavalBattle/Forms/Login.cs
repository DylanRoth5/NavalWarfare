using System.Runtime.InteropServices.JavaScript;
using NavalBattle.Controlers;
using NavalBattle.Entities;

namespace NavalBattle.Forms;

public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();
    }
    private void button1_Click(object sender, EventArgs e)
    {
        if (textBox1.Text.Length <= 0 || textBox2.Text.Length <= 0 || IUser.getAll().Count < 1) return;
        if (!IUser.getAll().Any(user => user.Nick == textBox1.Text && user.Password == textBox2.Text)) return;
        Program.Logged = true;
        Program.Menu!.label1.Text = $@">{textBox1.Text}";
        Program.CurrentUser = IUser.getAll().Find(user => user.Nick == textBox1.Text && user.Password == textBox2.Text);
        if (IMatch.getAll().Any(match => match.Player!.Id == Program.CurrentUser!.Id && match.Finished == false))
        {
            Program.Menu!.button1.Visible = true;
            Program.NewMatch = false;
        }
        else Program.NewMatch = true;
        Close();
    }
    private void label7_Click(object sender, EventArgs e)
    {

    }
    private void label1_Click(object sender, EventArgs e)
    {
        panel2.Visible = true;
        panel1.Visible = false;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (textBox3.Text.Length <= 0 || textBox4.Text.Length <= 0 || textBox5.Text.Length <= 0) return;
        var user = new User
        {
            Nick = textBox4.Text,
            Name = textBox5.Text,
            Password = textBox3.Text
        };
        IUser.save(user);
        panel2.Visible = false;
        panel1.Visible = true;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
        panel2.Visible = false;
        panel1.Visible = true;
    }
}
