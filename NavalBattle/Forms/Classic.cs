﻿using NavalBattle.Controlers;
using NavalBattle.Entities;

namespace NavalBattle.Forms;

public partial class Classic : Form
{
    public Classic()
    {
        InitializeComponent();
        // WindowState = FormWindowState.Maximized;
        if (!Program.NewMatch)
        {
            ConfigPanel.Enabled = false;
            ConfigPanel.Visible = false;
            shipPanel.Enabled = false;
            shipPanel.Visible = false;
            ePanel.Visible = true;
            pPanel.Visible = true;

            Match = IMatch.getAll().Find(match => match.Player.Id == Program.CurrentUser.Id && match.Finished == false);
            
            // Configurar el tamaño de los paneles según el tamaño de los mapas
            var height = Size.Width / (17 + Match.EnemyMap.Size);
            var width = Size.Width / (17 + Match.EnemyMap.Size);
            ePanel.Size = new Size(width * Match.EnemyMap.Size + 20, height * Match.EnemyMap.Size + 20);
            pPanel.Left = ePanel.Left + width * Match.EnemyMap.Size + 20;
            pPanel.Size = new Size(width * Match.PlayerMap.Size + 20, height * Match.PlayerMap.Size + 20);
        }
    }

    // Mapas para el jugador y el enemigo
    private static Match? Match;

    // Variable que indica si la orientación de los barcos es horizontal
    private static bool _isHorizontal = true;

    // Contadores para el número de barcos de diferentes tamaños
    private static int _smolShip;
    private static int _normalShip;
    private static int _bigShip;
    private static int _biggerShip;

    // Variables que indican si se está colocando un barco de cierto tamaño
    private static bool _placingSmal;
    private static bool _placingNormal;
    private static bool _placingBig;
    private static bool _placingBigger;

    // Variable que indica si se está llevando a cabo un ataque
    private static bool _atacking;

    // Variable que indica si el juego está en curso
    private static bool _gaming;

    private void gSolo_Load(object sender, EventArgs e)
    {
    }

    private void btSoloClose_Click(object sender, EventArgs e)
    {
        Hide();
        Program.Menu!.Show();
    }

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void btnCoord_Click(object sender, EventArgs e)
    {
        // Obtener el botón que activó el evento
        var btn = (Button)sender;

        // Extraer las coordenadas del nombre del botón
        var temp = btn.Name.Split(';');
        int[] coords = { int.Parse(temp[0]), int.Parse(temp[1]) };

        // Verificar si el botón pertenece al panel del enemigo
        if (btn.Parent == ePanel)
        {
            // Lanzar un misil en las coordenadas especificadas en el mapa del enemigo
            Match.EnemyMap = IMap.launchMissile(coords[0], coords[1], Match.EnemyMap);

            // Actualizar la representación visual del mapa del enemigo
            foreach (Button butn in ePanel.Controls)
            {
                var temp2 = butn.Name.Split(';');
                int[] coords2 = { int.Parse(temp2[0]), int.Parse(temp2[1]) };

                // Cambiar el color del botón según el valor en la matriz del mapa del enemigo
                if (Match.EnemyMap.Matrix[coords2[0], coords2[1]] == Map.Ship)
                {
                    butn.BackColor = Color.Cyan;
                }
                else if (Match.EnemyMap.Matrix[coords2[0], coords2[1]] == Map.WreckedShip)
                {
                    butn.BackColor = Color.Red;
                    butn.Enabled = false; 
                }
                else if (Match.EnemyMap.Matrix[coords2[0], coords2[1]] == Map.FailedMissile)
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
            var eX = r.Next(0, Match.EnemyMap.Size);
            var eY = r.Next(0, Match.EnemyMap.Size);
            // Verificar que no se haya lanzado un misil previamente en esas coordenadas
            var attempt = 0;
            var bombed = IMap.isBombed(eX, eY, Match.PlayerMap);
            while (bombed)
            {
                eX = r.Next(0, Match.EnemyMap.Size - 1);
                eY = r.Next(0, Match.EnemyMap.Size - 1);
                bombed = IMap.isBombed(eX, eY, Match.PlayerMap);
                attempt++;

                // Salir del bucle si se encuentra una posición válida o después de 50 intentos
                if (!bombed) break;
                if (attempt > 50) break;
            }

            // Lanzar un misil en las coordenadas aleatorias en el mapa del jugador
            Match.PlayerMap = IMap.launchMissile(eX, eY, Match.PlayerMap);

            // Actualizar la representación visual del mapa del jugador
            foreach (Button butn in pPanel.Controls)
            {
                var temp2 = butn.Name.Split(';');
                int[] coords2 = { int.Parse(temp2[0]), int.Parse(temp2[1]) };

                // Cambiar el color del botón según el valor en la matriz del mapa del jugador
                if (Match.PlayerMap.Matrix[coords2[0], coords2[1]] == Map.Ship)
                {
                    butn.BackColor = Color.Black;
                }
                else if (Match.PlayerMap.Matrix[coords2[0], coords2[1]] == Map.WreckedShip)
                {
                    butn.BackColor = Color.Red;
                    butn.Enabled = false;
                }
                else if (Match.PlayerMap.Matrix[coords2[0], coords2[1]] == Map.FailedMissile)
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
            if (_placingSmal)
                switch (_isHorizontal)
                {
                    case true when coords[0] < Match.PlayerMap!.Size - 1:
                        Match.PlayerMap = IMap.placeShip(coords[0], coords[1], 2, _isHorizontal, Match.PlayerMap);
                        _smolShip--;
                        _placingSmal = false;
                        break;
                    case false when coords[1] < Match.PlayerMap!.Size - 1:
                        Match.PlayerMap = IMap.placeShip(coords[0], coords[1], 2, _isHorizontal, Match.PlayerMap);
                        _smolShip--;
                        _placingSmal = false;
                        break;
                }

            if (_placingNormal)
                switch (_isHorizontal)
                {
                    case true when coords[0] < Match.PlayerMap!.Size - 2:
                        Match.PlayerMap = IMap.placeShip(coords[0], coords[1], 3, _isHorizontal, Match.PlayerMap);
                        _normalShip--;
                        _placingNormal = false;
                        break;
                    case false when coords[1] < Match.PlayerMap!.Size - 2:
                        Match.PlayerMap = IMap.placeShip(coords[0], coords[1], 3, _isHorizontal, Match.PlayerMap);
                        _normalShip--;
                        _placingNormal = false;
                        break;
                }

            if (_placingBig)
                switch (_isHorizontal)
                {
                    case true when coords[0] < Match.PlayerMap!.Size - 3:
                        Match.PlayerMap = IMap.placeShip(coords[0], coords[1], 4, _isHorizontal, Match.PlayerMap);
                        _bigShip--;
                        _placingBig = false;
                        break;
                    case false when coords[1] < Match.PlayerMap!.Size - 3:
                        Match.PlayerMap = IMap.placeShip(coords[0], coords[1], 4, _isHorizontal, Match.PlayerMap);
                        _bigShip--;
                        _placingBig = false;
                        break;
                }

            if (_placingBigger)
                switch (_isHorizontal)
                {
                    case true when coords[0] < Match.PlayerMap!.Size - 4:
                        Match.PlayerMap = IMap.placeShip(coords[0], coords[1], 5, _isHorizontal, Match.PlayerMap);
                        _biggerShip--;
                        _placingBigger = false;
                        break;
                    case false when coords[1] < Match.PlayerMap!.Size - 4:
                        Match.PlayerMap = IMap.placeShip(coords[0], coords[1], 5, _isHorizontal, Match.PlayerMap);
                        _biggerShip--;
                        _placingBigger = false;
                        break;
                }

            foreach (Button butn in pPanel.Controls)
            {
                var temp2 = butn.Name.Split(';');
                int[] coords2 = { int.Parse(temp2[0]), int.Parse(temp2[1]) };
                if (Match.PlayerMap!.Matrix[coords2[0], coords2[1]] == Map.Ship)
                    butn.BackColor = Color.Black;
                else if (Match.PlayerMap.Matrix[coords2[0], coords2[1]] == Map.WreckedShip)
                    butn.BackColor = Color.Red;
                else if (Match.PlayerMap.Matrix[coords2[0], coords2[1]] == Map.FailedMissile)
                    butn.BackColor = Color.Blue;
                else
                    butn.BackColor = Color.Cyan;
            }

            if (_biggerShip == 0 && _bigShip == 0 && _normalShip == 0 && _smolShip == 0)
            {
                button7.Enabled = true;
                button6.Enabled = false;
            }
        }

        // Habilitar/deshabilitar botones de colocación de barcos según la disponibilidad de barcos
        button2.Enabled = _smolShip != 0;
        button3.Enabled = _normalShip != 0;
        button4.Enabled = _bigShip != 0;
        button5.Enabled = _biggerShip != 0;

        // Habilitar el panel de barcos si no se está atacando
        if (!_atacking) shipPanel.Enabled = true;
        if (!_atacking) return;
        // Verificar el resultado del juego
        if (IMap.hasShips(Match.EnemyMap))
        {
            if (IMap.hasShips(Match.PlayerMap)) return;
            // El jugador perdió
            // ... (código para el mensaje de fin de juego)
            shipPanel.Visible = false;
            ePanel.Visible = false;
            pPanel.Visible = false;
            label7.Visible = true;
            label7.Text = @"You Lost";
            button1.Text = @"Reset";
        }
        else
        {
            if (IMap.hasShips(Match.PlayerMap))
            {
                // El jugador ganó
                // ... (código para el mensaje de fin de juego)
                shipPanel.Visible = false;
                ePanel.Visible = false;
                pPanel.Visible = false;
                label7.Visible = true;
                label7.Text = @"You Won";
                button1.Text = @"Reset";
            }
            else
            {
                // Empate
                // ... (código para el mensaje de fin de juego)
                shipPanel.Visible = false;
                ePanel.Visible = false;
                pPanel.Visible = false;
                label7.Visible = true;
                label7.Text = @"Both Lost";
                button1.Text = @"Reset";
            }
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Match = new Match();
        Match.Player = Program.CurrentUser;
        Match.Finished = false;
        // Crear nuevos mapas para el enemigo y el jugador con el tamaño seleccionado
        Match.EnemyMap = new Map(int.Parse(numericUpDown1.Value.ToString()));
        Match.PlayerMap = new Map(int.Parse(numericUpDown1.Value.ToString()));

        // Limpiar los mapas recién creados
        Match.EnemyMap = IMap.cleanMap(Match.EnemyMap);
        Match.PlayerMap = IMap.cleanMap(Match.PlayerMap);

        // Configuración inicial de la interfaz gráfica
        ePanel.Visible = true;
        pPanel.Visible = true;
        label7.Visible = false;
        shipPanel.Visible = true;

        // Configurar el tamaño de los paneles según el tamaño de los mapas
        var height = Size.Width / (17 + Match.EnemyMap.Size);
        var width = Size.Width / (17 + Match.EnemyMap.Size);
        ePanel.Size = new Size(width * Match.EnemyMap.Size + 20, height * Match.EnemyMap.Size + 20);
        pPanel.Left = ePanel.Left + width * Match.EnemyMap.Size + 20;
        pPanel.Size = new Size(width * Match.PlayerMap.Size + 20, height * Match.PlayerMap.Size + 20);

        // Inicializar contadores de barcos según los valores de los controles numericos
        _smolShip = int.Parse(numericUpDown2.Value.ToString());
        _normalShip = int.Parse(numericUpDown3.Value.ToString());
        _bigShip = int.Parse(numericUpDown4.Value.ToString());
        _biggerShip = int.Parse(numericUpDown5.Value.ToString());

        // Verificar si el juego aún no ha comenzado
        if (!_gaming)
        {
            // Configuración de la interfaz para el inicio del juego
            button1.Text = @"End Game";
            ePanel.Enabled = false;
            pPanel.Enabled = true;
            shipPanel.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            _gaming = true;

            // Configuración de la interfaz para el mapa del enemigo
            var top = 10;
            var left = 10;
            for (var i = 0; i < Match.EnemyMap.Size; i++)
            {
                for (var j = 0; j < Match.EnemyMap.Size; j++)
                {
                    // Crear y configurar botón del mapa del enemigo
                    var button = new Button();
                    button.Left = left;
                    button.Top = top;
                    button.Width = width;
                    button.Height = height;
                    button.Margin = new Padding(0, 0, 0, 0);
                    button.FlatStyle = FlatStyle.Flat;
                    button.Location = new Point(left, top);
                    button.Name = i + ";" + j;
                    button.Text = i + @";" + j;
                    button.Click += btnCoord_Click!;
                    button.BackColor = Color.Cyan;
                    ePanel.Controls.Add(button); // Agregar botón al panel
                    top += button.Height;
                }

                left += width;
                top -= height * Match.EnemyMap.Size;
            }

            // Configuración de la interfaz para el mapa del jugador
            top = 10;
            left = 10;
            for (var i = 0; i < Match.EnemyMap.Size; i++)
            {
                for (var j = 0; j < Match.EnemyMap.Size; j++)
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
                    button.Text = i + @";" + j;
                    button.Click += btnCoord_Click!;
                    button.BackColor = Color.Cyan;
                    pPanel.Controls.Add(button); // Agregar botón al panel
                    top += button.Height;
                }

                left += width;
                top -= height * Match.PlayerMap.Size;
            }
        }
        else
        {
            // Configuración de la interfaz para el final del juego
            ePanel.Visible = false;
            pPanel.Visible = false;
            shipPanel.Visible = false;
            button1.Text = @"Start";
            _gaming = false;
            _atacking = false;

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
        Program.Menu!.Show();
    }

    private void gSolo_FormClosing(object sender, FormClosingEventArgs e)
    {
        Hide();
        Program.Menu!.Show();
    }

    private void button6_Click(object sender, EventArgs e)
    {
        if (button6.Text == @"Horizontal")
        {
            button6.Text = @"Vertical";
            _isHorizontal = false;
        }
        else
        {
            button6.Text = @"Horizontal";
            _isHorizontal = true;
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (_smolShip > 0)
        {
            _placingSmal = true;
            shipPanel.Enabled = false;
        }

        button2.Enabled = false;
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (_normalShip > 0)
        {
            _placingNormal = true;
            shipPanel.Enabled = false;
        }

        button3.Enabled = false;
    }

    private void button4_Click(object sender, EventArgs e)
    {
        if (_bigShip > 0)
        {
            _placingBig = true;
            shipPanel.Enabled = false;
        }

        button4.Enabled = false;
    }

    private void button5_Click(object sender, EventArgs e)
    {
        if (_biggerShip > 0)
        {
            _placingBigger = true;
            shipPanel.Enabled = false;
        }

        button5.Enabled = false;
    }

    private void button7_Click(object sender, EventArgs e)
    {
        IMatch.save(Match);
        
        // Deshabilitar la capacidad de colocar barcos en el panel del jugador
        pPanel.Enabled = false;

        // Habilitar la capacidad de atacar en el panel del enemigo
        ePanel.Enabled = true;

        // Deshabilitar el panel de barcos
        shipPanel.Enabled = false;

        // Establecer la bandera de ataque a verdadera
        _atacking = true;

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
            eX = r.Next(0, Match.EnemyMap!.Size);
            eY = r.Next(0, Match.EnemyMap.Size);
            // Inicializar contador de intentos y verificar si la posición está ocupada
            attempt = 0;
            var occupied = IMap.isOccupied(eX, eY, 2, horisontal, Match.EnemyMap);
            // Repetir hasta encontrar una posición no ocupada o superar un límite de intentos
            while (occupied)
            {
                eX = r.Next(0, Match.EnemyMap.Size);
                eY = r.Next(0, Match.EnemyMap.Size);
                occupied = IMap.isOccupied(eX, eY, 2, horisontal, Match.EnemyMap);
                attempt++;
                if (!occupied) break;
                if (attempt > 50) break;
            }

            // Colocar el barco en la posición encontrada
            Match.EnemyMap = IMap.placeShip(eX, eY, 2, horisontal, Match.EnemyMap);
        }

        // Repetir el proceso para los otros tamaños de barco
        for (var i = 0; i < int.Parse(numericUpDown3.Value.ToString()); i++)
        {
            horisontal = r.Next(0, 1) == 0;
            eX = r.Next(0, Match.EnemyMap!.Size);
            eY = r.Next(0, Match.EnemyMap.Size);
            attempt = 0;
            var occupied = IMap.isOccupied(eX, eY, 3, horisontal, Match.EnemyMap);
            while (occupied)
            {
                eX = r.Next(0, Match.EnemyMap.Size);
                eY = r.Next(0, Match.EnemyMap.Size);
                occupied = IMap.isOccupied(eX, eY, 3, horisontal, Match.EnemyMap);
                attempt++;
                if (!occupied) break;
                if (attempt > 50) break;
            }

            Match.EnemyMap = IMap.placeShip(eX, eY, 3, horisontal, Match.EnemyMap);
        }

        for (var i = 0; i < int.Parse(numericUpDown4.Value.ToString()); i++)
        {
            horisontal = r.Next(0, 1) == 0;
            eX = r.Next(0, Match.EnemyMap!.Size);
            eY = r.Next(0, Match.EnemyMap.Size);
            attempt = 0;
            var occupied = IMap.isOccupied(eX, eY, 4, horisontal, Match.EnemyMap);
            while (occupied)
            {
                eX = r.Next(0, Match.EnemyMap.Size);
                eY = r.Next(0, Match.EnemyMap.Size);
                occupied = IMap.isOccupied(eX, eY, 4, horisontal, Match.EnemyMap);
                attempt++;
                if (!occupied) break;
                if (attempt > 50) break;
            }

            Match.EnemyMap = IMap.placeShip(eX, eY, 4, horisontal, Match.EnemyMap);
        }

        for (var i = 0; i < int.Parse(numericUpDown5.Value.ToString()); i++)
        {
            horisontal = r.Next(0, 1) == 0;
            eX = r.Next(0, Match.EnemyMap!.Size);
            eY = r.Next(0, Match.EnemyMap.Size);
            attempt = 0;
            var occupied = IMap.isOccupied(eX, eY, 5, horisontal, Match.EnemyMap);
            while (occupied)
            {
                eX = r.Next(0, Match.EnemyMap.Size);
                eY = r.Next(0, Match.EnemyMap.Size);
                occupied = IMap.isOccupied(eX, eY, 5, horisontal, Match.EnemyMap);
                attempt++;
                if (!occupied) break;
                if (attempt > 50) break;
            }
            Match.EnemyMap = IMap.placeShip(eX, eY, 5, horisontal, Match.EnemyMap);
        }

        // Actualizar la representación visual en el panel del enemigo
        foreach (Button btn in ePanel.Controls) btn.BackColor = Color.Cyan;
    }
}