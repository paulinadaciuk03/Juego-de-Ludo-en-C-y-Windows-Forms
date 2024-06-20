using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLudo
{
    internal class Dado
    {
        //valor minimo del dado
        public int Min = 1;
        //valor maximo del dado
        public int Max = 6;
        //constructor
        public Dado(int min, int max)
        {
            this.Min = min;
            this.Max = max;
        }
        //funcion que arroja un random entre los 2 valores
        public int Lanzar()
        {
            Random rand = new Random();
            return rand.Next(Min, Max);
        }

    }
}
