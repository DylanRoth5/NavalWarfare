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
        List<Button> shipPossitionButtons;

        Random r = new Random();

        System.Windows.Forms.Timer timer;
        TimeSpan tiempoTranscurrido;

        public gCoop()
        {
            InitializeComponent();
            InicializarCronometro();
        }

        private void btCoopClose_Click(object sender, EventArgs e)
        {
            foreach (var button in shipPossitionButtons) { button.Visible = false; }
            ReiniciarCronometro();
            Hide();
            Program.mainMenu.Show();
        }

        private void InicializarCronometro()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; //para que cuente bien los segundos
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Actualizar la visualización del tiempo si es necesario
            tiempoTranscurrido = tiempoTranscurrido.Add(TimeSpan.FromSeconds(1));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //lista con todos los botones que forman la matriz de lugares donde hay barcos
            shipPossitionButtons = new List<Button> { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10 };

            //asigna a 5 botones el tag 'enemyShip' para que haya un barco en ese boton
            for (int i = 0; i < 5; i++)
            {
                int indiceAleatorio = r.Next(shipPossitionButtons.Count);
                shipPossitionButtons[indiceAleatorio].Tag = "enemyShip";
            }

            //los botones estan ocultos antes de clickear start, este foreach los vuelve visibles
            foreach (var button in shipPossitionButtons) { button.Visible = true; }

            //inicia el cronómetro 
            tiempoTranscurrido = new TimeSpan();
            timer.Start();
        }
        private void BotonPosicion_Click(object sender, EventArgs e)
        {
            //verifica si el botón clicado tiene el tag enemyShip
            Button botonClicado = sender as Button;
            if (botonClicado != null && "enemyShip".Equals(botonClicado.Tag))
            {
                //realiza las acciones necesarias cuando se clickea un botón con el tag enemyShip
                MessageBox.Show("¡Encontraste un barco");

                //quita la propiedad para que no se pueda contar más de una vez
                botonClicado.Tag = null;
            }

            //devulve true cuando no haya ningun barco con el tag enemyShip y muestra q termino la partida
            if (!shipPossitionButtons.Any(button => "enemyShip".Equals(button.Tag)))
            {
                timer.Stop();
                MessageBox.Show($"¡Ganaste la partida! Tiempo: {tiempoTranscurrido.ToString(@"mm\:ss")}");
                foreach (var button in shipPossitionButtons) { button.Visible = false; }
                this.Hide();
                Program.mainMenu.Show();
                ReiniciarCronometro();
            }

        }
        private void ReiniciarCronometro()
        {
            tiempoTranscurrido = new TimeSpan();
            timer.Start();
        }

    }
}
