using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    internal class Square
    {
        private int size;
        public int Perimeter { get { return size*4; } }

        public Square(int size)
        {
            this.size = size;
        }

        public override string? ToString()
        {
            return "Vierkant: Omtrek: "+Perimeter;
        }
    }
}
