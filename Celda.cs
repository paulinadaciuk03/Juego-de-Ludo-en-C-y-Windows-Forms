using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLudo
{
    internal class Celda
    {
        public int X { get; set; }
        public int Y { get; set; }  

        // valores x e y de cada celda
        public Celda(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
