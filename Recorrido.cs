using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLudo
{
    internal class Recorrido // clase que representa todo el tablero general (sin las casillas de cada color)
    {

        #region campos y propiedades
        // inicializamos un arreglo que contenga todas las casillas blancas las cuales son 51 (tambien incluye la primer casilla de color de cada color)
        public Celda[] recorrido = new Celda[52];
        #endregion

        #region constructor
        //el constructor se encarga de cargar todos los valores de cada casilla a cada elemento del arreglo
        public Recorrido()
        {
            recorrido[0] = new Celda(8, 244);
            recorrido[1] = new Celda(7, 283);
            recorrido[2] = new Celda(8, 321);
            recorrido[3] = new Celda(47, 323);
            recorrido[4] = new Celda(86, 323);
            recorrido[5] = new Celda(125, 323);
            recorrido[6] = new Celda(164, 323);
            recorrido[7] = new Celda(203, 323);
            recorrido[8] = new Celda(244, 363);
            recorrido[9] = new Celda(244, 403);
            recorrido[10] = new Celda(244, 443);
            recorrido[11] = new Celda(244, 483);
            recorrido[12] = new Celda(244, 523);
            recorrido[13] = new Celda(244, 558);
            recorrido[14] = new Celda(283, 558);
            recorrido[15] = new Celda(323, 558);
            recorrido[16] = new Celda(323, 518);
            recorrido[17] = new Celda(323, 478);
            recorrido[18] = new Celda(323, 438);
            recorrido[19] = new Celda(323, 398);
            recorrido[20] = new Celda(323, 358);
            recorrido[21] = new Celda(363, 325);
            recorrido[22] = new Celda(401, 323);
            recorrido[23] = new Celda(442, 323);
            recorrido[24] = new Celda(481, 324);
            recorrido[25] = new Celda(519, 324);
            recorrido[26] = new Celda(559, 323);
            recorrido[27] = new Celda(559, 283);
            recorrido[28] = new Celda(559, 243);
            recorrido[29] = new Celda(521, 243);
            recorrido[30] = new Celda(481, 244);
            recorrido[31] = new Celda(441, 245);
            recorrido[32] = new Celda(402, 243);
            recorrido[33] = new Celda(362, 244);
            recorrido[34] = new Celda(323, 206);
            recorrido[35] = new Celda(323, 166);
            recorrido[36] = new Celda(323, 126);
            recorrido[37] = new Celda(323, 86);
            recorrido[38] = new Celda(323, 47);
            recorrido[39] = new Celda(323, 6);
            recorrido[40] = new Celda(284, 8);
            recorrido[41] = new Celda(244, 7);
            recorrido[42] = new Celda(244, 47);
            recorrido[43] = new Celda(243, 87);
            recorrido[44] = new Celda(243, 124);
            recorrido[45] = new Celda(244, 164);
            recorrido[46] = new Celda(244, 205);
            recorrido[47] = new Celda(205, 244);
            recorrido[48] = new Celda(166, 244);
            recorrido[49] = new Celda(127, 244);
            recorrido[50] = new Celda(85, 245);
            recorrido[51] = new Celda(47, 243);
        }
        #endregion


        #region metodos

        // el metodo encontrar pieza retorna la posicion de la pieza dentro del arreglo(como ya se evalua antes si las fichas no estan dentro del
        // recorrido del tablero no hace falta retornar un booleano ya que si o si va a estar dentro del tablero)
        public int encontrarPieza(Point pieza)
        {
            bool encontrado = false; //flag de encontrado
            int posicion = 0; // inicializamos la variable posicion
            //recorremos todo el arreglo
            for (int i = 0;i < recorrido.Length;i++) {
                // si la pieza se encuentra dentro del array
                if (recorrido[i].X == pieza.X && recorrido[i].Y == pieza.Y)
                {
                    encontrado = true; // se enciende la banderita de encontrado
                    posicion = i; // guardamos la posicion
                    if(encontrado)
                    {
                        break; // terminamos el bucle en caso de encontrado 
                    }
                }
            }

            return posicion; // retornamos la posicion de la ficha dentro del tablero


        }

        public bool estaEnTablero(Point pieza)
        {
            bool encontrado = false;
            for (int i = 0; i < recorrido.Length; i++)
            {
                // si la pieza se encuentra dentro del array
                if (recorrido[i].X == pieza.X && recorrido[i].Y == pieza.Y)
                {
                    encontrado = true; // se enciende la banderita de encontrado
                    if (encontrado)
                    {
                        break; // terminamos el bucle en caso de encontrado 
                    }
                }
            }
            return encontrado;
        }

        // el metodo mover pieza se encarga de mover el boton dentro del tablero por cada casilla del array
        public void moverPieza(Button pieza, int piezaPosicion, int dado)
        {
            // sumamos la posicion de la pieza que obtuvimos del metodo anterior al numero del dado

            piezaPosicion -= dado;

            //si la posicion es mayor que el tamaño del array
            if (piezaPosicion < 0)
            {
                piezaPosicion += recorrido.Length; // le restamos el tamaño del array asi comienza a contar del 0 de nuevo creado un recorrido circular por el tablero

            }

            // en caso de que la posicion sea menor 
            if(piezaPosicion < recorrido.Length)
            {
                // solo se asigna la nueva posicion y se cambia la locacion del boton a esa posicion
                Point posNueva = new Point(recorrido[piezaPosicion].X, recorrido[piezaPosicion].Y);
                pieza.Location = posNueva;

            }

        }


        #endregion

    }

}
