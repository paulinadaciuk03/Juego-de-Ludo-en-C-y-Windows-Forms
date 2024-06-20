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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            botonVolveraJugar.Visible = false; //ocultar el boton volver a jugar
            desactivarVerde(); //desactivar todos los botones verdes ya que mas tarde se van a activar los necesarios
            desactivarRojo();
            desactivarAzul();
            desactivarAmarillo();
        }



        #region asignacion de campos

        private int turno = 1; //1: verde 2: Rojo 3:amarillo 4:azul
        private int contVerde = 0; //contador de veces que jugo cada color
        private int contRojo = 0;
        private int contAmarillo = 0;
        private int contAzul = 0;
        #endregion

        #region instancias de clases
        private Recorrido tablero = new Recorrido(); //el tablero completo
        //cada recorrido de cada meta 
        private RecorridoVerde verde = new RecorridoVerde();
        private RecorridoRojo rojo = new RecorridoRojo();
        private RecorridoAmarillo amarillo = new RecorridoAmarillo();
        private RecorridoAzul azul = new RecorridoAzul();
        #endregion

        #region logica del juego
        private async void button2_Click(object sender, EventArgs e)
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
            numDado.Text = Convert.ToString(num); //mostrar el numero del dado en el form
            await Task.Delay(1000);
            if (turno == 1) //turno VERDE
            {
                //se desactivan los botones de los demas jugadores
                desactivarAmarillo();
                desactivarAzul();
                desactivarRojo();
                if (contVerde == 0) //si es la primera vez jugando se asigna directamente la primer ficha en la primer posicion
                {
                    if (numDado.Text == "6")
                    {
                        pieza1Verde.Location = new Point(47, 243);

                    }
                    else
                    {
                        desactivarVerde();
                        turno = 2;
                        turnoColor.Text = "Turno ROJO";
                        turnoColor.BackColor = Color.Red;
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

            //misma logica anterior para los demas colores
            if (turno == 2)
            {
                desactivarVerde();
                desactivarAmarillo();
                desactivarAzul();
                if (contRojo == 0)
                {
                    if (numDado.Text == "6")
                    {
                        pieza1Rojo.Location = new Point(323, 47);

                    }
                    else
                    {
                        desactivarRojo();
                        turno = 3;
                        turnoColor.Text = "Turno AMARILLO";
                        turnoColor.BackColor = Color.Yellow;
                        numDado.Text = "Lance el dado";
                        dadoBoton.Enabled = true;
                        await Task.Delay(500000);
                    }

                }
                if (numDado.Text == "6")
                {
                    if (contRojo == 0)
                    {
                        pieza1Rojo.Location = new Point(323, 47);
                        numDado.Text = "Lance el dado";
                        dadoBoton.Enabled = true;
                        contRojo++;
                        await Task.Delay(500000);
                    }
                    else
                    {
                        pieza1Rojo.BackColor = Color.LightCoral;
                        pieza2Rojo.BackColor = Color.LightCoral;
                        pieza3Rojo.BackColor = Color.LightCoral;
                        pieza4Rojo.BackColor = Color.LightCoral;
                        activarRojo();
                    }


                }
                else
                {
                    Point p = pieza1Rojo.Location;
                    if (p.X != 422 && p.Y != 106)
                    {
                        pieza1Rojo.BackColor = Color.LightCoral;
                        pieza1Rojo.Enabled = true;

                    }
                    p = pieza2Rojo.Location;
                    if (p.X != 460 && p.Y != 145)
                    {
                        pieza2Rojo.BackColor = Color.LightCoral;
                        pieza2Rojo.Enabled = true;


                    }
                    p = pieza3Rojo.Location;
                    if (p.X != 501 && p.Y != 106)
                    {
                        pieza3Rojo.BackColor = Color.LightCoral;
                        pieza3Rojo.Enabled = true;


                    }
                    p = pieza4Rojo.Location;
                    if (p.X != 460 && p.Y != 65)
                    {
                        pieza4Rojo.BackColor = Color.LightCoral;
                        pieza4Rojo.Enabled = true;


                    }
                }

                dadoBoton.Enabled = false;


            } //turno del rojo

            if (turno == 3)
            {
                desactivarRojo();
                desactivarVerde();
                desactivarAzul();
                if (contAmarillo == 0)
                {
                    if (numDado.Text == "6")
                    {
                        pieza1Amarillo.Location = new Point(244, 523);
                    }
                    else
                    {
                        desactivarAmarillo();
                        turno = 4;
                        turnoColor.Text = "Turno Azul";
                        turnoColor.BackColor = Color.Blue;
                        numDado.Text = "Lance el dado";
                        dadoBoton.Enabled = true;
                        await Task.Delay(500000);

                    }

                }
                if (numDado.Text == "6")
                {
                    if (contAmarillo == 0)
                    {
                        pieza1Amarillo.Location = new Point(244, 523);
                        dadoBoton.Enabled = true;
                        contAmarillo++;
                        await Task.Delay(500000);
                    }
                    else
                    {
                        pieza1Amarillo.BackColor = Color.LightYellow;
                        pieza2Amarillo.BackColor = Color.LightYellow;
                        pieza3Amarillo.BackColor = Color.LightYellow;
                        pieza4Amarillo.BackColor = Color.LightYellow;
                        activarAmarillo();
                    }

                }
                else
                {
                    Point p = pieza1Amarillo.Location;
                    if (p.X != 145 && p.Y != 460)
                    {
                        pieza1Amarillo.BackColor = Color.LightYellow;
                        pieza1Amarillo.Enabled = true;

                    }
                    p = pieza2Amarillo.Location;
                    if (p.X != 106 && p.Y != 421)
                    {
                        pieza2Amarillo.BackColor = Color.LightYellow;
                        pieza2Amarillo.Enabled = true;


                    }
                    p = pieza3Amarillo.Location;
                    if (p.X != 106 && p.Y != 500)
                    {
                        pieza3Amarillo.BackColor = Color.LightYellow;
                        pieza3Amarillo.Enabled = true;


                    }
                    p = pieza4Amarillo.Location;
                    if (p.X != 66 && p.Y != 460)
                    {
                        pieza4Amarillo.BackColor = Color.LightYellow;
                        pieza4Amarillo.Enabled = true;


                    }
                }
                dadoBoton.Enabled = false;

            } //turno del amarillo

            if (turno == 4)
            {
                desactivarAmarillo();
                desactivarRojo();
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
                        desactivarAzul();
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

        private void botonVolveraJugar_Click(object sender, EventArgs e) //evento del boton para volver a iniciar el juego(solo se activa si uno gana)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        #endregion

        #region movimiento de piezas
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
                desactivarAmarillo();
                desactivarAzul();
                desactivarRojo();
                desactivarVerde();
                dadoBoton.Enabled = false;
                // hace visible el boton de volver a jugar
                botonVolveraJugar.Visible = true;
            }

        } //movimiento de fichas azules

        //MISMA LOGICA PARA TODAS LAS PIEZAS COMENTADO EN pieza1Azul__Click !
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
            turnoColor.Text = "Turno ROJO";
            turnoColor.BackColor = Color.Red;
            numDado.Text = "Lance el dado";
            dadoBoton.Enabled = true;


            contVerde++;
            turno = 2;


            if (contadorVerde.Text == "4")
            {
                numDado.Text = "Ganador: VERDE!";
                numDado.BackColor = Color.Green;
                desactivarAmarillo();
                desactivarAzul();
                desactivarRojo();
                desactivarVerde();
                dadoBoton.Enabled = false;
                botonVolveraJugar.Visible = true;
            }

        } //verdes

        private async void pieza1Rojo_Click(object sender, EventArgs e)
        {
            pieza1Rojo.BackColor = Color.Red;
            pieza2Rojo.BackColor = Color.Red;
            pieza3Rojo.BackColor = Color.Red;
            pieza4Rojo.BackColor = Color.Red;


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

            if ((p.X == 422 && p.Y == 106) || (p.X == 460 && p.Y == 145) || (p.X == 501 && p.Y == 106) || (p.X == 460 && p.Y == 65))
            {
                pieza.Location = new Point(323, 47);
                if (numDado.Text == "6")
                {
                    numDado.Text = "Lance el dado";
                    dadoBoton.Enabled = true;
                    contRojo++;
                    await Task.Delay(500000);
                }
            }
            else if (rojo.Meta(pieza))
            {
                rojo.moverPieza(pieza, dado);
            }
            else
            {
                tablero.moverPieza(pieza, pos, dado);
            }

            rojo.contarPuntos(pieza, contadorRojo);

            desactivarRojo();
            contRojo++;
            turno = 3;
            turnoColor.Text = "Turno: AMARILLO";
            turnoColor.BackColor = Color.Gold;

            numDado.Text = "Lance el dado";
            dadoBoton.Enabled = true;


            if (contadorRojo.Text == "4")
            {
                numDado.Text = "Ganador: ROJO!";
                numDado.BackColor = Color.Red;
                desactivarAmarillo();
                desactivarAzul();
                desactivarRojo();
                desactivarVerde();
                dadoBoton.Enabled = false;
                botonVolveraJugar.Visible = true;
            }
        } //rojas 

        private async void pieza1Amarillo_Click(object sender, EventArgs e)
        {
            pieza1Amarillo.BackColor = Color.Yellow;
            pieza2Amarillo.BackColor = Color.Yellow;
            pieza3Amarillo.BackColor = Color.Yellow;
            pieza4Amarillo.BackColor = Color.Yellow;


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

            if (p.X == 106 && p.Y == 421 || p.X == 145 && p.Y == 460 || p.X == 106 && p.Y == 500 || p.X == 66 && p.Y == 460)
            {
                pieza.Location = new Point(244, 523);
                if (numDado.Text == "6")
                {
                    numDado.Text = "Lance el dado";
                    dadoBoton.Enabled = true;
                    contAmarillo++;
                    await Task.Delay(500000);
                }
            }
            else if (amarillo.Meta(pieza))
            {
                amarillo.moverPieza(pieza, dado);
            }
            else
            {
                tablero.moverPieza(pieza, pos, dado);
            }

            amarillo.contarPuntos(pieza, contadorAmarillo);

            desactivarAmarillo();
            contAmarillo++;
            turno = 4;
            turnoColor.Text = "Turno: AZUL";
            turnoColor.BackColor = Color.Blue;

            numDado.Text = "Lance el dado";
            dadoBoton.Enabled = true;


            if (contadorAmarillo.Text == "4")
            {
                numDado.Text = "Ganador: AMARILLO!";
                numDado.BackColor = Color.Yellow;
                desactivarAmarillo();
                desactivarAzul();
                desactivarRojo();
                desactivarVerde();
                dadoBoton.Enabled = false;
                botonVolveraJugar.Visible = true;
            }
        } //amarillas

        #endregion

        #region botones
        public void desactivarRojo()
        {
            pieza1Rojo.Enabled = false;
            pieza2Rojo.Enabled = false;
            pieza3Rojo.Enabled = false;
            pieza4Rojo.Enabled = false;

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

        public void desactivarAmarillo()
        {
            pieza1Amarillo.Enabled = false;
            pieza2Amarillo.Enabled = false;
            pieza3Amarillo.Enabled = false;
            pieza4Amarillo.Enabled = false;
        }

        public void activarRojo()
        {
            pieza1Rojo.Enabled = true;
            pieza2Rojo.Enabled = true;
            pieza3Rojo.Enabled = true;
            pieza4Rojo.Enabled = true;

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

        public void activarAmarillo()
        {
            pieza1Amarillo.Enabled = true;
            pieza2Amarillo.Enabled = true;
            pieza3Amarillo.Enabled = true;
            pieza4Amarillo.Enabled = true;
        }

        #endregion



    }
}


