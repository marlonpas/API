using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Fish:Animal,IAmAWaterAnimal
    {
        public Fish(int age) : base(age)
        {
        }

        public void Swim()
        {
            Console.WriteLine("de vis zwemt");
        }
    }
}
