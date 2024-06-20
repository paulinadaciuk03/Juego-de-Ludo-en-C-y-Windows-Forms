using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLudo
{
    internal class Ludo
    {
        public Tablero Tablero { get; set; }
        public List<Jugador>Jugadores { get; set; }
        public Jugador JugadorActual { get; set; }
        public int Dado { get; set; }

    }
}
