using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    internal class Circle
    {
        private int radius;
        public double Area { get { return (radius*2) * Math.PI; } }

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override string? ToString()
        {
            return "Cirkel: Oppervlakte: "+ Area;
        }
    }
}
