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
    }


}
