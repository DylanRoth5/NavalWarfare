using NavalWarfare.Controllers;
using NavalWarfare.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NavalWarfare.HelperSeal;

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        static bool gaming;

        public void btnCoord_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var temp = btn.Name.Split(';');
            int[] coords = { int.Parse(temp[0]),int.Parse(temp[1]) };
            if (btn.Parent == ePanel)
            {
                eMap = IMap.LaunchMisile(coords[0], coords[1], eMap);  
                foreach (Button butn in ePanel.Controls)
                {
                    var temp2 = butn.Name.Split(';');
                    int[] coords2 = { int.Parse(temp2[0]),int.Parse(temp2[1]) };
                    switch (eMap.Matrix[coords2[0], coords2[1]])
                    {
                        case 1:
                            butn.BackColor = Color.Cyan;
                            break;
                        case 2:
                            butn.BackColor = Color.Red;
                            butn.Enabled = false;
                            break;
                        case 3:
                            butn.BackColor = Color.Blue;
                            butn.Enabled = false;
                            break;
                        default:
                            butn.BackColor = Color.Cyan;
                            break;
                    }
                }
                var r = new Random();
                var eX = r.Next(0, eMap.Size);
                var eY = r.Next(0, eMap.Size);
                // chequeo que no haya mandado ya a ese lugar un misil
                var attempt=0;
                var bombed = IMap.isBombed(eX, eY, pMap);
                while (bombed)
                { // este sistema no es muy bueno y la posibilidad de ganar del enemigo asi es basicamente nula
                    eX = r.Next(0, eMap.Size-1);
                    eY = r.Next(0, eMap.Size-1);
                    bombed = IMap.isBombed(eX, eY, pMap);
                    attempt++;
                    if (!bombed) break;
                    if (attempt>50) break;
                }
                Tools.WriteLine(attempt+"");
                pMap = IMap.LaunchMisile(eX, eY, pMap);

                foreach (Button butn in pPanel.Controls)
                {
                    var temp2 = butn.Name.Split(';');
                    int[] coords2 = { int.Parse(temp2[0]),int.Parse(temp2[1]) };
                    switch (pMap.Matrix[coords2[0], coords2[1]])
                    {
                        case 1:
                            butn.BackColor = Color.Black;
                            break;
                        case 2:
                            butn.BackColor = Color.Red;
                            butn.Enabled = false;
                            break;
                        case 3:
                            butn.BackColor = Color.Blue;
                            butn.Enabled = false;
                            break;
                        default:
                            butn.BackColor = Color.Cyan;
                            break;
                    }
                }
            }
            else if (btn.Parent == pPanel)
            {
                if (placingSmal)
                {
                    switch (isHorizontal)
                    {
                        case true when coords[0] < pMap.Size - 1:
                            pMap = IMap.placeShip(coords[0], coords[1], 2, isHorizontal, pMap);
                            smolShip--;
                            placingSmal = false;
                            break;
                        case false when coords[1] < pMap.Size - 1:
                            pMap = IMap.placeShip(coords[0], coords[1], 2, isHorizontal, pMap);
                            smolShip--;
                            placingSmal = false;
                            break;
                    }
                }
                if (placingNormal)
                {
                    switch (isHorizontal)
                    {
                        case true when coords[0] < pMap.Size - 2:
                            pMap = IMap.placeShip(coords[0], coords[1], 3, isHorizontal, pMap);
                            normalShip--;
                            placingNormal = false;
                            break;
                        case false when coords[1] < pMap.Size - 2:
                            pMap = IMap.placeShip(coords[0], coords[1], 3, isHorizontal, pMap);
                            normalShip--;
                            placingNormal = false;
                            break;
                    }
                }
                if (placingBig)
                {
                    switch (isHorizontal)
                    {
                        case true when coords[0] < pMap.Size - 3:
                            pMap = IMap.placeShip(coords[0], coords[1], 4, isHorizontal, pMap);
                            bigShip--;
                            placingBig = false;
                            break;
                        case false when coords[1] < pMap.Size - 3:
                            pMap = IMap.placeShip(coords[0], coords[1], 4, isHorizontal, pMap);
                            bigShip--;
                            placingBig = false;
                            break;
                    }
                }
                if (placingBigger)
                {
                    switch (isHorizontal)
                    {
                        case true when coords[0]<pMap.Size-4:
                            pMap = IMap.placeShip(coords[0], coords[1], 5, isHorizontal, pMap);
                            biggerShip--;
                            placingBigger = false;
                            break;
                        case false when coords[1]<pMap.Size-4:
                            pMap = IMap.placeShip(coords[0], coords[1], 5, isHorizontal, pMap);
                            biggerShip--;
                            placingBigger = false;
                            break;
                    }
                }
                foreach (Button butn in pPanel.Controls)
                {
                    var temp2 = butn.Name.Split(';');
                    int[] coords2 = { int.Parse(temp2[0]),int.Parse(temp2[1]) };
                    butn.BackColor = pMap.Matrix[coords2[0], coords2[1]] switch
                    {
                        1 => Color.Black,
                        2 => Color.Red,
                        _ => Color.Cyan
                    };
                }
                if (biggerShip == 0 && bigShip == 0 && normalShip == 0 && smolShip == 0)
                {
                    button7.Enabled = true;
                    button6.Enabled = false;
                }
            }
            // Tools.WriteLine($"{smolShip} {normalShip} {bigShip} {biggerShip}");
            button2.Enabled = smolShip != 0;
            button3.Enabled = normalShip != 0;
            button4.Enabled = bigShip != 0;
            button5.Enabled = biggerShip != 0;
            if (!atacking) shipPanel.Enabled = true;
            if (!atacking) return;
            if (IMap.HasShips(eMap))
            {
                if (!IMap.HasShips(pMap))
                { // enemigo tiene barcos y vos no
                    shipPanel.Visible = false;
                    ePanel.Visible = false;
                    pPanel.Visible = false;
                    label7.Visible = true;
                    label7.Text = "You Lost";
                    button1.Text = "Reset";
                    //You Lose
                }
            }
            else
            {
                if (IMap.HasShips(pMap))
                { // enemigo no tiene barcos y vos si
                    shipPanel.Visible = false;
                    ePanel.Visible = false;
                    pPanel.Visible = false;
                    label7.Visible = true;
                    label7.Text = "You Won";
                    button1.Text = "Reset";
                    //You win
                }
                else
                { // enemigo no tiene barcos y vos tampoco
                    shipPanel.Visible = false;
                    ePanel.Visible = false;
                    pPanel.Visible = false;
                    label7.Visible = true;
                    label7.Text = "Both Lost";
                    button1.Text = "Reset";
                    //empate
                }
            }
        }
        static public Map eMap;
        static public Map pMap;

        public static bool isHorizontal = true;
        public static int smolShip;
        public static int normalShip;
        public static int bigShip;
        public static int biggerShip;
        public static bool placingSmal;
        public static bool placingNormal;
        public static bool placingBig;
        public static bool placingBigger;
        public static bool atacking;

        private void button1_Click(object sender, EventArgs e)
        {
            eMap = new Map(int.Parse(numericUpDown1.Value.ToString()));
            pMap = new Map(int.Parse(numericUpDown1.Value.ToString()));
            eMap = IMap.CleanMap(eMap);
            pMap = IMap.CleanMap(pMap);
            ePanel.Visible = true;
            pPanel.Visible = true;
            label7.Visible = false;
            shipPanel.Visible = true;
            int height = 40;
            int width = 40;
            ePanel.Size = new Size(width * eMap.Size+ 20, height * eMap.Size + 20);
            pPanel.Size = new Size(width * pMap.Size+ 20, height * pMap.Size + 20);
            smolShip = int.Parse(numericUpDown2.Value.ToString());
            normalShip = int.Parse(numericUpDown3.Value.ToString());
            bigShip = int.Parse(numericUpDown4.Value.ToString());
            biggerShip = int.Parse(numericUpDown5.Value.ToString());
            

            if (!gaming)
            {
                button1.Text = "End Game";
                ePanel.Enabled = false;
                pPanel.Enabled = true;
                shipPanel.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                gaming = true;
                int top = 10;
                int left = 10;
                for (int i = 0; i < eMap.Size; i++)
                {
                    for (int j = 0; j < eMap.Size; j++)
                    {
                        var button = new Button();
                        button.Left = left;
                        button.Top = top;
                        button.Width = width;
                        button.Height = height;
                        button.Margin = new Padding(0,0,0,0);
                        button.FlatStyle = FlatStyle.Flat;
                        button.Location = new Point(left, top);
                        button.Name = i + ";" + j;
                        button.Text = i + ";" + j;
                        button.Click += btnCoord_Click;
                        button.BackColor = Color.Cyan;
                        ePanel.Controls.Add(button); // here
                        top += button.Height;
                    }
                    left += width;
                    top -= height * eMap.Size;
                }
                top = 10;
                left = 10;
                for (int i = 0; i < eMap.Size; i++)
                {
                    for (int j = 0; j < eMap.Size; j++)
                    {
                        var button = new Button();
                        button.Left = left;
                        button.Top = top;
                        button.Width = width;
                        button.Height = height;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Location = new Point(left, top);
                        button.Name = i + ";" + j;
                        button.Text = i + ";" + j;
                        button.Click += btnCoord_Click;
                        button.BackColor = Color.Cyan;
                        pPanel.Controls.Add(button); // here
                        top += button.Height;
                    }
                    left += width;
                    top -= height * pMap.Size;
                }
            }
            else
            {
                ePanel.Visible = false;
                pPanel.Visible = false;
                shipPanel.Visible = false;
                button1.Text = "Start";
                gaming = false;
                atacking = false;
                while (ePanel.Controls.Count > 0)
                    foreach (Button button in ePanel.Controls)
                        ePanel.Controls.Remove(button);
                while (pPanel.Controls.Count > 0)
                    foreach (Button button in pPanel.Controls)
                        pPanel.Controls.Remove(button);
            }

        }

        private void gmPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gSolo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            Program.mainMenu.Show();
        }

        private void gSolo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Program.mainMenu.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "Horizontal")
            {
                button6.Text = "Vertical";
                isHorizontal = false;
            }
            else
            {
                button6.Text = "Horizontal";
                isHorizontal = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (smolShip > 0)
            {
                placingSmal = true;
                shipPanel.Enabled = false;
            }
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (normalShip > 0)
            {
                placingNormal = true;
                shipPanel.Enabled = false;
            }
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bigShip > 0)
            {
                placingBig = true;
                shipPanel.Enabled = false;
            }
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (biggerShip > 0)
            {
                placingBigger = true;
                shipPanel.Enabled = false;
            }
            button5.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pPanel.Enabled = false;
            ePanel.Enabled = true;
            shipPanel.Enabled = false;
            atacking = true;
            var r = new Random();
            bool horisontal;
            for (int i = 0; i < int.Parse(numericUpDown2.Value.ToString()); i++)
            {
                horisontal = r.Next(0, 1) == 0;
                eMap = IMap.placeShip(r.Next(0, eMap.Size - 2), r.Next(0, eMap.Size - 2), 2, horisontal, eMap);
            }
            for (int i = 0; i < int.Parse(numericUpDown3.Value.ToString()); i++)
            {
                horisontal = r.Next(0, 1) == 0;
                eMap = IMap.placeShip(r.Next(0, eMap.Size - 3), r.Next(0, eMap.Size - 3), 3, horisontal, eMap);
            }
            for (int i = 0; i < int.Parse(numericUpDown4.Value.ToString()); i++)
            {
                horisontal = r.Next(0, 1) == 0;
                eMap = IMap.placeShip(r.Next(0, eMap.Size - 4), r.Next(0, eMap.Size - 4), 4, horisontal, eMap);
            }
            for (int i = 0; i < int.Parse(numericUpDown5.Value.ToString()); i++)
            {
                horisontal = r.Next(0, 1) == 0;
                eMap = IMap.placeShip(r.Next(0, eMap.Size - 5), r.Next(0, eMap.Size - 5), 5, horisontal, eMap);
            }

            foreach (Button btn in ePanel.Controls)
            {
                var temp = btn.Name.Split(';');
                int[] coords = { int.Parse(temp[0]),int.Parse(temp[1]) };
                if (eMap.Matrix[coords[0], coords[1]] == 1)
                {
                    btn.BackColor = Color.Cyan;
                }else btn.BackColor = Color.Cyan;
            }
        }
    }


}
