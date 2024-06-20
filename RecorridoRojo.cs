using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLudo
{
    internal class RecorridoRojo // clase recorridoRojo sirve para que las fichas ROJAS se muevan dentro de su meta
    {
        #region campos y propiedades
        private Celda[] recorridoRojo = new Celda[7]; // asigno un array de 7 caracteres (son 7 celdas)
        public int posicionEnMeta { get; set; }

        #endregion

        #region constructor
        public RecorridoRojo()
        {
            //inicializo los valores con los valores de cada celda dentro del tablero
            recorridoRojo[0] = new Celda(284, 8);
            recorridoRojo[1] = new Celda(284, 45);
            recorridoRojo[2] = new Celda(284, 85);
            recorridoRojo[3] = new Celda(283, 124);
            recorridoRojo[4] = new Celda(284, 165);
            recorridoRojo[5] = new Celda(285, 206);
            recorridoRojo[6] = new Celda(283, 245);

        }

        #endregion

        #region metodos
        //el metodo meta devuelve un booleano que nos dice si la ficha esta en la meta o no (si no esta en la meta esta en el tablero o en su posicion inicial)
        public bool Meta(Button pieza)
        {
            //pasamos la locacion de la pieza a un objeto point para comparar los valores X e Y
            Point p = pieza.Location;
            bool encontrado = false; //inicializo flag de si se encontro la pieza o no
            // recorremos el arreglo de la meta ROJA
            for (int i = 0; i < recorridoRojo.Length; i++)
            {
                // si la locacion de la ficha coincide con alguna dentro de la meta
                if (p.X == recorridoRojo[i].X && p.Y == recorridoRojo[i].Y)
                {
                    //se activa la flag si se encuentra
                    encontrado = true;
                    //se guarda su posicion en el array
                    posicionEnMeta = i;
                    if (encontrado) // sale del bucle si lo encuentra
                    {
                        break;

                    }
                }
            }

            return encontrado; // retorna si se encontro o no
        }

        // el metodo mover pieza mueve la pieza DENTRO de su meta, no del tablero en general
        public void moverPieza(Button pieza, int dado)
        { 
            // como guardamos la posicion en meta en el metodo anterior, le sumamos el valor del dado
            // por lo tanto si la posicion era 2, y el dado dio 5, la posicion nueva va a ser 7
            posicionEnMeta += dado;

            // en caso de que la posicion sea menor que 7 (7 es hasta donde llega el tablero en la meta)
            if (posicionEnMeta < 7)
            {
                // asigna una nueva posicion con la posicion calculada mas el dado
                Point posNueva = new Point(recorridoRojo[posicionEnMeta].X, recorridoRojo[posicionEnMeta].Y);
                //cambia la locacion de la pieza
                pieza.Location = posNueva;
            }
            else // en el caso de que el dado y la posicion sumados se pasen de la meta 
            {
                // solo asigna la locacion al final del recorrido
                pieza.Location = new Point(recorridoRojo[6].X, recorridoRojo[6].Y);
            }

        }

        // el metodo contar puntos sirve para contar cuantas fichas guardo el jugador en la meta
        public void contarPuntos(Button pieza1, Label contador)
        {
            //la locacion se guarda en un point
            Point p1 = pieza1.Location;
            // inicializamos la variable PUNTOS
            int puntos = 0;
            try
            {
                 puntos = int.Parse(contador.Text); // el contador se encuentra en cada meta con un 0 para cada color

            } catch (Exception e)
            {

            }

            // si la pieza se encuentra en el final del recorrido quiere decir que llego a la meta
            if (p1.X == recorridoRojo[6].X && p1.Y == recorridoRojo[6].Y)
            {
                //invisibilizamos el boton asi no se tapa el contador
                pieza1.Visible = false;
                /// sumamos un punto al contador
                puntos += 1;
                // lo mostramos en el form al nuevo puntaje
                contador.Text = Convert.ToString(puntos);
            }


        }
        #endregion
    }
}
