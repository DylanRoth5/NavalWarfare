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
    public partial class gCoop : Form
    {
        public gCoop()
        {
            InitializeComponent();
        }

        private void btCoopClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainMenu.Show();
        }

        private void btCoopStart_Click(object sender, EventArgs e)
        {
            //cree la matriz en el panles con sus respetivos barcos. cuando apretas una posicion te dice si le pegaste a un barco o no
            // si le pegas a todos los barcos en el mapa ganas el juego
        }
    }
}
