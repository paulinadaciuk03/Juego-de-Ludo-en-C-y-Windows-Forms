namespace PruebaLudo
{
    internal class RecorridoAzul // LA LOGICA DE ESTA CLASE ESTA EXPLICADA EN LA CLASE RecorridoRojo YA QUE ES LA MISMA SOLO CAMBIAN
                                 // LAS POSICIONES DE CADA CELDA PARA CADA COLOR
    {
        #region campos
        private Celda[] recorridoAzul = new Celda[7];
        #endregion

        #region propiedades
        public int posicionEnMeta { get; set; }
        #endregion

        #region constructor
        public RecorridoAzul()
        {
            recorridoAzul[0] = new Celda(559, 283);
            recorridoAzul[1] = new Celda(520, 284);
            recorridoAzul[2] = new Celda(481, 284);
            recorridoAzul[3] = new Celda(442, 285);
            recorridoAzul[4] = new Celda(402, 282);
            recorridoAzul[5] = new Celda(363, 283);
            recorridoAzul[6] = new Celda(320, 282);

        }
        #endregion

        #region metodos
        public bool Meta(Button pieza)
        {
            Point p = pieza.Location;
            bool encontrado = false;
            for (int i = 0; i < recorridoAzul.Length; i++)
            {
                if (p.X == recorridoAzul[i].X && p.Y == recorridoAzul[i].Y)
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
                Point posNueva = new Point(recorridoAzul[posicionEnMeta].X, recorridoAzul[posicionEnMeta].Y);
                pieza.Location = posNueva;
            }
            else
            {
                pieza.Location = new Point(recorridoAzul[6].X, recorridoAzul[6].Y);
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

            if (p1.X == recorridoAzul[6].X && p1.Y == recorridoAzul[6].Y)
            {
                pieza1.Visible = false;
                puntos += 1;
                contador.Text = Convert.ToString(puntos);
            }


        }

        #endregion
    }
}