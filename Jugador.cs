using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLudo
{
    internal class Jugador
    {
        //color del jugador
        public String Color { get; set; }
        //cuenta de piezas en la base por jugador
        public int PiezasBase { get; set; }
        //cuenta de piezas llegadas al final por jugador
        public int PiezaTerminada { get; set; }
        //lista de piezas
        public List<Pieza> Piezas { get; set; }
        //jugadores maximos 
        public int MaxJugadores = 4;
        //piezas por jugador
        public int PiezaPorJug = 4;
        //piezas de inicio en base
        public int PiezaEnBaseInicio = 4;
        //piezas llegadas al final al comienzo del juego
        public int PiezaTerminadaInicial = 0;

        //constructor
        public Jugador (String color)
        {
            this.Color = color;
            this.PiezasBase = PiezaEnBaseInicio;
            this.PiezaTerminada = PiezaTerminadaInicial;
            //lista de piezas
            this.Piezas = new List<Pieza>();
            for(int i = 0; i < PiezaPorJug; i++) 
            {
                //tdv falta el constructor de Pieza para saber si tiene parametros
                Piezas.Add(new Pieza());
            }

        }

    }
}
