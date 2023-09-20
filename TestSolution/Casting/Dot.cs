using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    internal class Dot
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Dot(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string? ToString()
        {
            return $"Punt: ({X},{Y})";
        }
    }
}
