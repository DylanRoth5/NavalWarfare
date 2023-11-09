using NavalWarfare.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavalWarfare
{
    public partial class gSolo : Form
    {
        public gSolo()
        {
            InitializeComponent();
        }
        private void btSoloBack_Click(object sender, EventArgs e)
        {

        }

        private void gSolo_Load(object sender, EventArgs e)
        {

        }

        private void btSoloClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainMenu.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Button btn(int i, int j)
        {
            Button b = new Button();
            b.Width = 50;
            b.Height = 50;
            b.Name = i.ToString();
            b.Text = i.ToString();
            b.Click += bClick;
            return b;
        }

        private void bClick(object sender, EventArgs e) { }

        private void btStart_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            int mapsize = int.Parse(numericUpDown1.Value.ToString());
            Map pmap = new Map(mapsize);
            Map emap = new Map(mapsize);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; i < 3; j++)
                {
                    panel1.Controls.Add(btn(i, j));
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }


}
