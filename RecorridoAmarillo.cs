namespace PruebaLudo
{
    internal class RecorridoAmarillo // LA LOGICA DE ESTA CLASE ESTA EXPLICADA EN LA CLASE RecorridoRojo YA QUE ES LA MISMA SOLO CAMBIAN
                                    // LAS POSICIONES DE CADA CELDA PARA CADA COLOR
    {
        #region campos y propiedades
        private Celda[] recorridoAmarillo = new Celda[7];
        public int posicionEnMeta { get; set; }

        #endregion

        #region constructor
        public RecorridoAmarillo()
        {
            recorridoAmarillo[0] = new Celda(283, 558);
            recorridoAmarillo[1] = new Celda(283, 520);
            recorridoAmarillo[2] = new Celda(284, 480);
            recorridoAmarillo[3] = new Celda(283, 441);
            recorridoAmarillo[4] = new Celda(283, 402);
            recorridoAmarillo[5] = new Celda(282, 362);
            recorridoAmarillo[6] = new Celda(283, 319);

        }
        #endregion

        #region metodos
        public bool Meta(Button pieza)
        {
            Point p = pieza.Location;
            bool encontrado = false;
            for (int i = 0; i < recorridoAmarillo.Length; i++)
            {
                if (p.X == recorridoAmarillo[i].X && p.Y == recorridoAmarillo[i].Y)
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
                Point posNueva = new Point(recorridoAmarillo[posicionEnMeta].X, recorridoAmarillo[posicionEnMeta].Y);
                pieza.Location = posNueva;
            }
            else
            {
                pieza.Location = new Point(recorridoAmarillo[6].X, recorridoAmarillo[6].Y);
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

            if (p1.X == recorridoAmarillo[6].X && p1.Y == recorridoAmarillo[6].Y)
            {
                pieza1.Visible = false;
                puntos += 1;
                contador.Text = Convert.ToString(puntos);
            }


        }
        #endregion
    }
}