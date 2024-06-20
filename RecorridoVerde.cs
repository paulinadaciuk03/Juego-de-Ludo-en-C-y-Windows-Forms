using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLudo
{
    internal class RecorridoVerde // LA LOGICA DE ESTA CLASE ESTA EXPLICADA EN LA CLASE RecorridoRojo YA QUE ES LA MISMA SOLO CAMBIAN
                                  // LAS POSICIONES DE CADA CELDA PARA CADA COLOR
    {
        #region campos
        private Celda[] recorridoVerde = new Celda[7];
        #endregion
        
        #region propiedades
        public int posicionEnMeta { get; set; }

        #endregion

        #region constructor
        public RecorridoVerde()
        {
            recorridoVerde[0] = new Celda(7, 283);
            recorridoVerde[1] = new Celda(47, 282);
            recorridoVerde[2] = new Celda(86, 285);
            recorridoVerde[3] = new Celda(125, 284);
            recorridoVerde[4] = new Celda(164, 283);
            recorridoVerde[5] = new Celda(203, 282);
            recorridoVerde[6] = new Celda(246, 283);

        }
        #endregion

        #region metodos
        public bool Meta(Button pieza)
        {
            Point p = pieza.Location;
            bool encontrado = false;
            for(int i = 0; i < recorridoVerde.Length; i++)
            {
                if (p.X == recorridoVerde[i].X && p.Y == recorridoVerde[i].Y)
                {
                    encontrado = true;
                    posicionEnMeta = i;
                    if (encontrado)
                    {
                        break;

                    }
                }
            }

            return encontrado;
        }
        public void moverPieza(Button pieza, int dado)
        {
            posicionEnMeta += dado;

            if (posicionEnMeta < 7)
            {
                Point posNueva = new Point(recorridoVerde[posicionEnMeta].X, recorridoVerde[posicionEnMeta].Y);
                pieza.Location = posNueva;
            }
            else
            {
                pieza.Location = new Point(recorridoVerde[6].X, recorridoVerde[6].Y);
            }

        }


        public void contarPuntos(Button pieza1, Label contador)
        {
            Point p1 = pieza1.Location;

            int puntos = 0;
            try
            {
                puntos = int.Parse(contador.Text);

            }
            catch (Exception e)
            {

            }
            
            if (pieza1.Visible == false)
            {
                return;
            } else if (p1.X == recorridoVerde[6].X && p1.Y == recorridoVerde[6].Y)
            {
                pieza1.Visible = false;
                puntos += 1;
                contador.Text = Convert.ToString(puntos);
            }


        }
        #endregion
    }
}
