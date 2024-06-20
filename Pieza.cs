using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLudo
{
    internal class Pieza
    {
        //celda donde se encuentra la pieza
        public Celda CeldaActual {get; set;}
        //color del jugador al que le toca la pieza
        public Jugador Color {get; set;}
        //para saber si la pieza esta en la fila final
        public bool PiezaLineaFinal { get; set;}
        //para saber si la pieza termino el juego 
        public bool PiezaTermina { get; set;}
        //para saber si la pieza esta dentro de la base del color (situacion inicial)
        public bool PiezaEnBase { get; set;}

        
    }
}
