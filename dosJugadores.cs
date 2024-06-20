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
    public partial class dosJugadores : Form
    {
        int turno = 1;
        int contVerde = 0;
        int contAzul = 0;

        Recorrido tablero = new Recorrido();
        RecorridoVerde verde = new RecorridoVerde();
        RecorridoAzul azul = new RecorridoAzul();


        public dosJugadores()
        {
            InitializeComponent();
            botonVolveraJugar.Visible = false; //ocultar el boton volver a jugar
            desactivarVerde(); //desactivar todos los botones verdes ya que mas tarde se van a activar los necesarios
            desactivarAzul();
        }

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
            //mostrar el numero del dado en el form
            if (turno == 1) //turno VERDE
            {
                //se desactivan los botones de los demas jugadores
                desactivarAzul();
                if (contVerde == 0) //si es la primera vez jugando se asigna directamente la primer ficha en la primer posicion
                {
                    if (int.Parse(numDado.Text) == 6)
                    {
                        pieza1Verde.Location = new Point(47, 243);

                    }
                    else
                    {
                        desactivarVerde();
                        turno = 2;
                        turnoColor.Text = "Turno AZUL";
                        turnoColor.BackColor = Color.Blue;
                        numDado.Text = "Lance el dado";
                        dadoBoton.Enabled = true;
                        await Task.Delay(500000);

                    }

                }
                if (numDado.Text == "6") //si el dado da 6 se puede mover cualquier ficha por lo tanto se iluminan y se activan
                {
                    if (contVerde == 0)
                    {
                        pieza1Verde.Location = new Point(47, 243);
                        numDado.Text = "Lance el dado";
                        dadoBoton.Enabled = true;
                        contVerde++;
                        await Task.Delay(500000);

                    }
                    else
                    {
                        pieza1Verde.BackColor = Color.LightGreen;
                        pieza2Verde.BackColor = Color.LightGreen;
                        pieza3Verde.BackColor = Color.LightGreen;
                        pieza4Verde.BackColor = Color.LightGreen;
                        activarVerde();

                    }

                }
                else //si el dado no es 6
                {
                    Point p = pieza1Verde.Location;
                    if (p.X != 106 && p.Y != 146) // si cada pieza NO esta dentro de su casita al inicio
                                                  // o sea en el tablero, se puede mover, por lo tanto se ilumina y se activa
                    {
                        pieza1Verde.BackColor = Color.LightGreen;
                        pieza1Verde.Enabled = true;
                    }
                    p = pieza2Verde.Location;
                    if (p.X != 145 && p.Y != 106)
                    {
                        pieza2Verde.BackColor = Color.LightGreen;
                        pieza2Verde.Enabled = true;


                    }
                    p = pieza3Verde.Location;
                    if (p.X != 106 && p.Y != 65)
                    {
                        pieza3Verde.BackColor = Color.LightGreen;
                        pieza3Verde.Enabled = true;


                    }
                    p = pieza4Verde.Location;
                    if (p.X != 66 && p.Y != 106)
                    {
                        pieza4Verde.BackColor = Color.LightGreen;
                        pieza4Verde.Enabled = true;


                    }
                }

                dadoBoton.Enabled = false; //se desactiva el boton del dado asi se evita que se tire mas de una vez 


            } //turno del verde
            if (turno == 2)
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
                        desactivarAzul();
                        turno = 1;
                        turnoColor.Text = "Turno Verde";
                        turnoColor.BackColor = Color.Green;
                        numDado.Text = "Lance el dado";
                        dadoBoton.Enabled = true;
                        await Task.Delay(500000);

                    }
                }
                if (numDado.Text == "6")
                {
                    if (contAzul == 0)
                    {
                        pieza1Azul.Location = new Point(519, 324);
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
                        pieza1Azul.Enabled = true;
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

            } //turno del azul

        }


        private async void pieza1Verde_Click(object sender, EventArgs e)
        {
            pieza1Verde.BackColor = Color.ForestGreen;
            pieza2Verde.BackColor = Color.ForestGreen;
            pieza3Verde.BackColor = Color.ForestGreen;
            pieza4Verde.BackColor = Color.ForestGreen;

            Button pieza = (Button)sender;
            Point p = pieza.Location;
            int dado = 0;
            int cont = 0;
            int pos = 0;

            pos = tablero.encontrarPieza(p);

            try
            {
                dado = int.Parse(numDado.Text);
            }
            catch (Exception ex)
            {

            }

            if (p.X == 106 && p.Y == 145 || p.X == 145 && p.Y == 106 || p.X == 106 && p.Y == 65 || p.X == 66 && p.Y == 106)
            {
                pieza.Location = new Point(47, 243);
                if (numDado.Text == "6")
                {
                    numDado.Text = "Lance el dado";
                    dadoBoton.Enabled = true;
                    contVerde++;
                    await Task.Delay(500000);
                }
            }
            else if (verde.Meta(pieza))
            {
                verde.moverPieza(pieza, dado);
            }
            else
            {
                tablero.moverPieza(pieza, pos, dado);
            }


            verde.contarPuntos(pieza, contadorVerde);

            desactivarVerde();
            turnoColor.Text = "Turno AZUL";
            turnoColor.BackColor = Color.Blue;
            numDado.Text = "Lance el dado";
            dadoBoton.Enabled = true;


            contVerde++;
            turno = 2;

            if (contadorVerde.Text == "4")
            {
                numDado.Text = "Ganador: VERDE!";
                numDado.BackColor = Color.Green;
                desactivarAzul();
                desactivarVerde();
                dadoBoton.Enabled = false;
                botonVolveraJugar.Visible = true;
            }
        }

        private async void pieza4Azul_Click(object sender, EventArgs e)
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
            turnoColor.Text = "Turno VERDE";//cambia el turno a verde
            turnoColor.BackColor = Color.Green;
            numDado.Text = "Lance el dado"; //cambia el texto a lance el dado en vez de el numero del dado
            dadoBoton.Enabled = true; // activa el boton de dado
            contAzul++; // incrementa el contador de turnos jugados
            turno = 1; //el turno vuelve al 1. verde

            if (contadorAzul.Text == "4") // si las fichas dentro de la meta son 4 significa que es el ganador
            {
                numDado.Text = "Ganador: AZUL!";
                numDado.BackColor = Color.Blue;
                desactivarAzul();
                desactivarVerde();
                dadoBoton.Enabled = false;
                // hace visible el boton de volver a jugar
                botonVolveraJugar.Visible = true;
            }
        }



        public void desactivarAzul()
        {
            pieza1Azul.Enabled = false;
            pieza2Azul.Enabled = false;
            pieza3Azul.Enabled = false;
            pieza4Azul.Enabled = false;
        }

        public void desactivarVerde()
        {
            pieza2Verde.Enabled = false;
            pieza3Verde.Enabled = false;
            pieza1Verde.Enabled = false;
            pieza4Verde.Enabled = false;
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
    }
}
