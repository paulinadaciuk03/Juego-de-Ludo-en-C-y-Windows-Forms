using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaLudo
{
    public partial class LudoUnJugador : Form
    {
        public LudoUnJugador()
        {
            InitializeComponent();
            botonVolveraJugar.Visible = false;
            desactivarAzul();
            desactivarVerde();
        }

        int turno = 1; //azul, jugador
        int contAzul = 0; //turnos jugados jugador
        int contVerde = 0;

        Recorrido tablero = new Recorrido();
        RecorridoAzul azul = new RecorridoAzul();
        RecorridoVerde verde = new RecorridoVerde();

        private async void dadoBoton_Click(object sender, EventArgs e)
        {
            dadoBoton.Enabled = false;
            numDado.Text = "Lanzando.";
            await Task.Delay(500);
            numDado.Text = "Lanzando..";
            await Task.Delay(500);
            numDado.Text = "Lanzando...";
            await Task.Delay(500);
            Dado d = new Dado(1, 7); //instancia de dado
            int num = d.Lanzar();
            numDado.Text = Convert.ToString(num);
            await Task.Delay(1000);
            if (turno == 1)
            {

                desactivarVerde();

                if (contAzul == 0)
                {
                    if (numDado.Text == "6")
                    {
                        pieza1Azul.Location = new Point(519, 324);
                    }
                    else
                    {
                        turno = 1;
                        turnoColor.Text = "Turno COMPUTADORA";
                        turnoColor.BackColor = Color.Green;
                        desactivarVerde();
                        turnoComputadora();
                        await Task.Delay(500000);

                    }
                }
                if (numDado.Text == "6")
                {
                    if (contAzul == 0)
                    {
                        pieza1Azul.Location = new Point(519, 324);
                        numDado.Text = "Lance el dado";
                        dadoBoton.Enabled = true;
                        contAzul++;
                        await Task.Delay(500000);
                    }
                    else
                    {
                        pieza1Azul.BackColor = Color.LightBlue;
                        pieza2Azul.BackColor = Color.LightBlue;
                        pieza3Azul.BackColor = Color.LightBlue;
                        pieza4Azul.BackColor = Color.LightBlue;
                        activarAzul();
                    }
                }
                else
                {
                    Point p = pieza1Azul.Location;
                    if (p.X != 501 && p.Y != 460)
                    {
                        pieza1Azul.BackColor = Color.LightBlue;
                        pieza1Azul.Enabled = true;
                    }
                    p = pieza2Azul.Location;
                    if (p.X != 462 && p.Y != 500)
                    {
                        pieza2Azul.BackColor = Color.LightBlue;
                        pieza2Azul.Enabled = true;
                    }
                    p = pieza3Azul.Location;
                    if (p.X != 422 && p.Y != 460)
                    {
                        pieza3Azul.BackColor = Color.LightBlue;
                        pieza3Azul.Enabled = true;
                    }
                    p = pieza4Azul.Location;
                    if (p.X != 462 && p.Y != 421)
                    {
                        pieza4Azul.BackColor = Color.LightBlue;
                        pieza4Azul.Enabled = true;

                    }
                }

                dadoBoton.Enabled = false;
            }
        }

        private async void turnoComputadora()
        {
            desactivarAzul();
            Button[] botonesCompu = new Button[4];

            botonesCompu[0] = pieza1Verde;
            botonesCompu[1] = pieza2Verde;
            botonesCompu[2] = pieza3Verde;
            botonesCompu[3] = pieza4Verde;

            Random rand = new Random();
            int piezaAleatoria = rand.Next(0, 4);

            Point p = botonesCompu[piezaAleatoria].Location;

            Dado dado = new Dado(1, 7);
            int numeroDado = dado.Lanzar();

            numDado.Text = "Lanzando.";
            await Task.Delay(500);
            numDado.Text = "Lanzando..";
            await Task.Delay(500);
            numDado.Text = "Lanzando...";
            await Task.Delay(500);

            numDado.Text = Convert.ToString(numeroDado);

            await Task.Delay(1000);

            if (contVerde == 0)
            {
                if (numDado.Text == "6")
                {
                    pieza1Verde.Location = new Point(47, 243);
                    contVerde++;
                    turnoComputadora();
                    await Task.Delay(500000);

                }
                else
                {
                    turno = 1;
                    turnoColor.Text = "Turno: JUGADOR";
                    turnoColor.BackColor = Color.Blue;
                    numDado.Text = "Lance el dado";
                    dadoBoton.Enabled = true;
                }
            }
            else
            {
                int pos = tablero.encontrarPieza(p);


                if (numeroDado == 6)
                {
                    if (p.X == 106 && p.Y == 145 || p.X == 145 && p.Y == 106 || p.X == 106 && p.Y == 65 || p.X == 66 && p.Y == 106)
                    {
                        botonesCompu[piezaAleatoria].Location = new Point(47, 243);
                        if (numDado.Text == "6")
                        {
                            turnoComputadora();
                            contVerde++;
                            await Task.Delay(500000);
                        }
                    }
                    else if (verde.Meta(botonesCompu[piezaAleatoria]))
                    {
                        verde.moverPieza(botonesCompu[piezaAleatoria], numeroDado);
                    }
                    else
                    {
                        tablero.moverPieza(botonesCompu[piezaAleatoria], pos, numeroDado);
                    }
                }
                else
                {
                    while ((p.X == 106 && p.Y == 145) || (p.X == 145 && p.Y == 106) || (p.X == 106 && p.Y == 65) || (p.X == 66 && p.Y == 106) || (p.X == 246 && p.Y == 283))
                    {
                        piezaAleatoria = rand.Next(0, 4);
                        p = botonesCompu[piezaAleatoria].Location;
                        pos = tablero.encontrarPieza(p);
                    }

                    if (verde.Meta(botonesCompu[piezaAleatoria]))
                    {
                        verde.moverPieza(botonesCompu[piezaAleatoria], numeroDado);
                    }
                    else
                    {
                        tablero.moverPieza(botonesCompu[piezaAleatoria], pos, numeroDado);
                    }
                }



                contVerde++;

                verde.contarPuntos(botonesCompu[piezaAleatoria], contadorVerde);

                turnoColor.Text = "Turno JUGADOR";
                turnoColor.BackColor = Color.Blue;
                numDado.Text = "Lance el dado";
                dadoBoton.Enabled = true;

                turno = 1;

            }


            if (contadorVerde.Text == "4")
            {
                numDado.Text = "Ganador: COMPUTADORA!"; 
                numDado.BackColor = Color.Green;
                desactivarAzul();
                desactivarVerde();
                dadoBoton.Enabled = false;
                botonVolveraJugar.Visible = true;
            }

        }
        private async void pieza1Azul_Click(object sender, EventArgs e)
        {
            //se vuelven a poner las fichas a su color original cuando se aprieta cualquier ficha
            pieza1Azul.BackColor = Color.Blue;
            pieza2Azul.BackColor = Color.Blue;
            pieza3Azul.BackColor = Color.Blue;
            pieza4Azul.BackColor = Color.Blue;

            //casteamos el boton a pieza
            Button pieza = (Button)sender;
            //asignamos la locacion a un punto especifico
            Point p = pieza.Location;

            //asignacion de el numero del dado, un contador que no se para que puse y la posicion de la pieza en el array del tablero
            int dado = 0;
            int cont = 0;
            int pos = 0;

            pos = tablero.encontrarPieza(p); //encontrarPieza retorna un int que indica en que posicion del array con todas las posiciones del tablero
                                             // se encuentra la pieza

            try
            {
                //ponemos lo que esta en la label del dado dentro de un int
                dado = int.Parse(numDado.Text);
            }
            catch (Exception ex)
            {

            }

            //si la pieza esta en alguna de las posiciones iniciales (en su casita), directamente se le asigna la posicion inicial en el tablero
            // independientemente el numero del dado
            if (p.X == 501 && p.Y == 460 || p.X == 462 && p.Y == 500 || p.X == 422 && p.Y == 460 || p.X == 462 && p.Y == 421)
            {
                pieza.Location = new Point(519, 324);
                if (numDado.Text == "6")
                {
                    numDado.Text = "Lance el dado";
                    dadoBoton.Enabled = true;
                    contAzul++;
                    await Task.Delay(500000);
                }
            }
            else if (azul.Meta(pieza)) // en cambio si la pieza esta en la casilla de meta (si la pieza llega a la casilla de su color).
                                       // el metodo meta devuelve un booleano de si la pieza se encuentra o no dentro de las casillas de su color
            {
                azul.moverPieza(pieza, dado); // en caso de que este en la meta, avanza de otra forma, dentro de un array de las posiciones de las metas de cada color
            }
            else
            {
                tablero.moverPieza(pieza, pos, dado); // en caso de que no este en la meta, esta en el tablero por lo tanto mueve la pieza dentro del array de tablero (no meta)
            }

            azul.contarPuntos(pieza, contadorAzul); //cuenta cuantas fichas tiene en la meta el jugador
                                                    // si hay alguna incrementa el contenido label contadorAzul

            desactivarAzul();
            turnoColor.Text = "Turno COMPUTADORA";
            turnoColor.BackColor = Color.Green;//cambia el turno a LA COMPU
            contAzul++; // incrementa el contador de turnos jugados
            turno = 2; //el turno va al 2
            if (contadorAzul.Text == "4") // si las fichas dentro de la meta son 4 significa que es el ganador
            {
                turnoColor.Text = "Ganador: JUGADOR!";
                turnoColor.BackColor = Color.Blue;// anuncia el ganador en el form
                //desactiva todos los botones
                desactivarVerde();
                dadoBoton.Enabled = false;
                // hace visible el boton de volver a jugar
                botonVolveraJugar.Visible = true;
                await Task.Delay(10000);
                this.Close();
            }

            turnoComputadora();
        }

        #region BOTONES
        public void desactivarVerde()
        {
            pieza2Verde.Enabled = false;
            pieza3Verde.Enabled = false;
            pieza1Verde.Enabled = false;
            pieza4Verde.Enabled = false;
        }

        public void desactivarAzul()
        {
            pieza1Azul.Enabled = false;
            pieza2Azul.Enabled = false;
            pieza3Azul.Enabled = false;
            pieza4Azul.Enabled = false;
        }
        public void activarAzul()
        {
            pieza1Azul.Enabled = true;
            pieza2Azul.Enabled = true;
            pieza3Azul.Enabled = true;
            pieza4Azul.Enabled = true;
        }

        public void activarVerde()
        {
            pieza2Verde.Enabled = true;
            pieza3Verde.Enabled = true;
            pieza1Verde.Enabled = true;
            pieza4Verde.Enabled = true;
        }

        private void botonVolveraJugar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        #endregion
    }

}

