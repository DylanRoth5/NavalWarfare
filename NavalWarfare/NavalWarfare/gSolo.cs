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
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void btSoloBack_Click(object sender, EventArgs e)
        {

        }

        private void gSolo_Load(object sender, EventArgs e)
        {

        }

        private void btSoloClose_Click(object sender, EventArgs e)
        {
            Hide();
            Program.mainMenu.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void btnCoord_Click(object sender, EventArgs e)
        {
            // Obtener el botón que activó el evento
            var btn = (Button)sender;
            
            // Extraer las coordenadas del nombre del botón
            var temp = btn.Name.Split(';');
            int[] coords = { int.Parse(temp[0]),int.Parse(temp[1]) };
            
            // Verificar si el botón pertenece al panel del enemigo
            if (btn.Parent == ePanel)
            {
                // Lanzar un misil en las coordenadas especificadas en el mapa del enemigo
                eMap = IMap.LaunchMisile(coords[0], coords[1], eMap);  
                
                // Actualizar la representación visual del mapa del enemigo
                foreach (Button butn in ePanel.Controls)
                {
                    var temp2 = butn.Name.Split(';');
                    int[] coords2 = { int.Parse(temp2[0]),int.Parse(temp2[1]) };
                    
                    // Cambiar el color del botón según el valor en la matriz del mapa del enemigo
                    if (eMap.Matrix[coords2[0], coords2[1]] == Ship.Here)
                    {
                        butn.BackColor = Color.Cyan;
                    }
                    else if (eMap.Matrix[coords2[0], coords2[1]] == Missile.Hit)
                    {
                        butn.BackColor = Color.Red;
                        butn.Enabled = false;
                    }
                    else if (eMap.Matrix[coords2[0], coords2[1]] == Missile.Sunk)
                    {
                        butn.BackColor = Color.Blue;
                        butn.Enabled = false;
                    }
                    else
                    {
                        butn.BackColor = Color.Cyan;
                    }
                }
                
                // Generar coordenadas aleatorias para el lanzamiento de misiles del enemigo
                var r = new Random();
                var eX = r.Next(0, eMap.Size);
                var eY = r.Next(0, eMap.Size);
                // Verificar que no se haya lanzado un misil previamente en esas coordenadas
                var attempt=0;
                var bombed = IMap.isBombed(eX, eY, pMap);
                while (bombed)
                { 
                    eX = r.Next(0, eMap.Size-1);
                    eY = r.Next(0, eMap.Size-1);
                    bombed = IMap.isBombed(eX, eY, pMap);
                    attempt++;
                    
                    // Salir del bucle si se encuentra una posición válida o después de 50 intentos
                    if (!bombed) break;
                    if (attempt>50) break;
                }
                
                // Lanzar un misil en las coordenadas aleatorias en el mapa del jugador
                pMap = IMap.LaunchMisile(eX, eY, pMap);

                // Actualizar la representación visual del mapa del jugador
                foreach (Button butn in pPanel.Controls)
                {
                    var temp2 = butn.Name.Split(';');
                    int[] coords2 = { int.Parse(temp2[0]),int.Parse(temp2[1]) };
                    
                    // Cambiar el color del botón según el valor en la matriz del mapa del jugador
                    if (pMap.Matrix[coords2[0], coords2[1]] == Ship.Here)
                    {
                        butn.BackColor = Color.Black;
                    }
                    else if (pMap.Matrix[coords2[0], coords2[1]] == Missile.Hit)
                    {
                        butn.BackColor = Color.Red;
                        butn.Enabled = false;
                    }
                    else if (pMap.Matrix[coords2[0], coords2[1]] == Missile.Sunk)
                    {
                        butn.BackColor = Color.Blue;
                        butn.Enabled = false;
                    }
                    else
                    {
                        butn.BackColor = Color.Cyan;
                    }
                }
            }
            // Manejar la lógica de ubicación de barcos si el botón pertenece al panel del jugador
            else if (btn.Parent == pPanel)
            {
                // ... (código para la colocación de barcos)
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
                    if (pMap.Matrix[coords2[0], coords2[1]] == Ship.Here)
                        butn.BackColor = Color.Black;
                    else if (pMap.Matrix[coords2[0], coords2[1]] == Missile.Hit)
                        butn.BackColor = Color.Red;
                    else if (pMap.Matrix[coords2[0], coords2[1]] == Missile.Sunk)
                        butn.BackColor = Color.Blue;
                    else
                        butn.BackColor = Color.Cyan;
                }
                if (biggerShip == 0 && bigShip == 0 && normalShip == 0 && smolShip == 0)
                {
                    button7.Enabled = true;
                    button6.Enabled = false;
                }
            }
            
            // Habilitar/deshabilitar botones de colocación de barcos según la disponibilidad de barcos
            button2.Enabled = smolShip != 0;
            button3.Enabled = normalShip != 0;
            button4.Enabled = bigShip != 0;
            button5.Enabled = biggerShip != 0;
            
            // Habilitar el panel de barcos si no se está atacando
            if (!atacking) shipPanel.Enabled = true;
            if (!atacking) return;
            // Verificar el resultado del juego
            if (IMap.HasShips(eMap))
            {
                if (!IMap.HasShips(pMap))
                {
                    // El jugador perdió
                    // ... (código para el mensaje de fin de juego)
                    shipPanel.Visible = false;
                    ePanel.Visible = false;
                    pPanel.Visible = false;
                    label7.Visible = true;
                    label7.Text = "You Lost";
                    button1.Text = "Reset";
                }
            }
            else
            {
                if (IMap.HasShips(pMap))
                { 
                    // El jugador ganó
                    // ... (código para el mensaje de fin de juego)
                    shipPanel.Visible = false;
                    ePanel.Visible = false;
                    pPanel.Visible = false;
                    label7.Visible = true;
                    label7.Text = "You Won";
                    button1.Text = "Reset";
                }
                else
                { 
                    // Empate
                    // ... (código para el mensaje de fin de juego)
                    shipPanel.Visible = false;
                    ePanel.Visible = false;
                    pPanel.Visible = false;
                    label7.Visible = true;
                    label7.Text = "Both Lost";
                    button1.Text = "Reset";
                }
            }
        }
        
        // Mapas para el jugador y el enemigo
        static public Map eMap;
        static public Map pMap;

        // Variable que indica si la orientación de los barcos es horizontal
        public static bool isHorizontal = true;
        
        // Contadores para el número de barcos de diferentes tamaños
        public static int smolShip;
        public static int normalShip;
        public static int bigShip;
        public static int biggerShip;
        
        // Variables que indican si se está colocando un barco de cierto tamaño
        public static bool placingSmal;
        public static bool placingNormal;
        public static bool placingBig;
        public static bool placingBigger;
        
        // Variable que indica si se está llevando a cabo un ataque
        public static bool atacking;
        
        // Variable que indica si el juego está en curso
        public static bool gaming;

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear nuevos mapas para el enemigo y el jugador con el tamaño seleccionado
            eMap = new Map(int.Parse(numericUpDown1.Value.ToString()));
            pMap = new Map(int.Parse(numericUpDown1.Value.ToString()));
            
            // Limpiar los mapas recién creados
            eMap = IMap.CleanMap(eMap);
            pMap = IMap.CleanMap(pMap);
            
            // Configuración inicial de la interfaz gráfica
            ePanel.Visible = true;
            pPanel.Visible = true;
            label7.Visible = false;
            shipPanel.Visible = true;
            
            // Configurar el tamaño de los paneles según el tamaño de los mapas
            var height = Size.Width/ (17+eMap.Size);
            var width = Size.Width/(17+eMap.Size);
            ePanel.Size = new Size(width * eMap.Size+ 20, height * eMap.Size + 20);
            pPanel.Left = ePanel.Left +width * eMap.Size + 20;
            pPanel.Size = new Size(width * pMap.Size+ 20, height * pMap.Size + 20);
            
            // Inicializar contadores de barcos según los valores de los controles numericos
            smolShip = int.Parse(numericUpDown2.Value.ToString());
            normalShip = int.Parse(numericUpDown3.Value.ToString());
            bigShip = int.Parse(numericUpDown4.Value.ToString());
            biggerShip = int.Parse(numericUpDown5.Value.ToString());
            
            // Verificar si el juego aún no ha comenzado
            if (!gaming)
            {
                // Configuración de la interfaz para el inicio del juego
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
                
                // Configuración de la interfaz para el mapa del enemigo
                var top = 10;
                var left = 10;
                for (var i = 0; i < eMap.Size; i++)
                {
                    for (var j = 0; j < eMap.Size; j++)
                    {
                        // Crear y configurar botón del mapa del enemigo
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
                        ePanel.Controls.Add(button); // Agregar botón al panel
                        top += button.Height;
                    }
                    left += width;
                    top -= height * eMap.Size;
                }
                // Configuración de la interfaz para el mapa del jugador
                top = 10;
                left = 10;
                for (var i = 0; i < eMap.Size; i++)
                {
                    for (var j = 0; j < eMap.Size; j++)
                    {
                        // Crear y configurar botón del mapa del jugador
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
                        pPanel.Controls.Add(button); // Agregar botón al panel
                        top += button.Height;
                    }
                    left += width;
                    top -= height * pMap.Size;
                }
            }
            else
            {
                // Configuración de la interfaz para el final del juego
                ePanel.Visible = false;
                pPanel.Visible = false;
                shipPanel.Visible = false;
                button1.Text = "Start";
                gaming = false;
                atacking = false;
                
                // Limpiar los controles de los paneles
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
            // Deshabilitar la capacidad de colocar barcos en el panel del jugador
            pPanel.Enabled = false;
            
            // Habilitar la capacidad de atacar en el panel del enemigo
            ePanel.Enabled = true;
            
            // Deshabilitar el panel de barcos
            shipPanel.Enabled = false;
            
            // Establecer la bandera de ataque a verdadera
            atacking = true;
            
            // Crear un generador de números aleatorios
            var r = new Random();
            
            // Variables para determinar la orientación de los barcos
            bool horisontal;
            int eX;
            int eY;
            int attempt;
            
            // Colocar barcos en el mapa del enemigo
            for (var i = 0; i < int.Parse(numericUpDown2.Value.ToString()); i++)
            {
                // Determinar aleatoriamente la orientación del barco (horizontal o vertical)
                horisontal = r.Next(0, 1) == 0; // 0 o 1 para determinar horizontal o vertical
                
                // Obtener coordenadas aleatorias para la posición del barco
                eX = r.Next(0, eMap.Size);
                eY = r.Next(0, eMap.Size);
                // Inicializar contador de intentos y verificar si la posición está ocupada
                attempt=0;
                var occupied = IMap.isOccupied(eX, eY,2,horisontal, eMap);
                // Repetir hasta encontrar una posición no ocupada o superar un límite de intentos
                while (occupied)
                { 
                    eX = r.Next(0, eMap.Size);
                    eY = r.Next(0, eMap.Size);
                    occupied = IMap.isOccupied(eX, eY,2,horisontal, eMap);
                    attempt++;
                    if (!occupied) break;
                    if (attempt>50) break;
                }
                // Colocar el barco en la posición encontrada
                eMap = IMap.placeShip(eX, eY, 2, horisontal, eMap);
            }
            // Repetir el proceso para los otros tamaños de barco
            for (var i = 0; i < int.Parse(numericUpDown3.Value.ToString()); i++)
            {
                horisontal = r.Next(0, 1) == 0;
                eX = r.Next(0, eMap.Size);
                eY = r.Next(0, eMap.Size);
                attempt=0;
                var occupied = IMap.isOccupied(eX, eY,3,horisontal, eMap);
                while (occupied)
                { 
                    eX = r.Next(0, eMap.Size);
                    eY = r.Next(0, eMap.Size);
                    occupied = IMap.isOccupied(eX, eY,3,horisontal, eMap);
                    attempt++;
                    if (!occupied) break;
                    if (attempt>50) break;
                }
                eMap = IMap.placeShip(eX, eY, 3, horisontal, eMap);
            }
            for (var i = 0; i < int.Parse(numericUpDown4.Value.ToString()); i++)
            {
                horisontal = r.Next(0, 1) == 0;
                eX = r.Next(0, eMap.Size);
                eY = r.Next(0, eMap.Size);
                attempt=0;
                var occupied = IMap.isOccupied(eX, eY,4,horisontal, eMap);
                while (occupied)
                { 
                    eX = r.Next(0, eMap.Size);
                    eY = r.Next(0, eMap.Size);
                    occupied = IMap.isOccupied(eX, eY,4,horisontal, eMap);
                    attempt++;
                    if (!occupied) break;
                    if (attempt>50) break;
                }
                eMap = IMap.placeShip(eX, eY, 4, horisontal, eMap);
            }
            for (var i = 0; i < int.Parse(numericUpDown5.Value.ToString()); i++)
            {
                horisontal = r.Next(0, 1) == 0;
                eX = r.Next(0, eMap.Size);
                eY = r.Next(0, eMap.Size);
                attempt=0;
                var occupied = IMap.isOccupied(eX, eY,5,horisontal, eMap);
                while (occupied)
                { 
                    eX = r.Next(0, eMap.Size);
                    eY = r.Next(0, eMap.Size);
                    occupied = IMap.isOccupied(eX, eY,5,horisontal, eMap);
                    attempt++;
                    if (!occupied) break;
                    if (attempt>50) break;
                }
                eMap = IMap.placeShip(eX, eY, 5, horisontal, eMap);
            }
            
            // Actualizar la representación visual en el panel del enemigo
            foreach (Button btn in ePanel.Controls) btn.BackColor = Color.Cyan;
        }
    }


}
