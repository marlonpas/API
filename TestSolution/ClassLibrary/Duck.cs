using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Duck:Animal, IMakeSound, IAmAWaterAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("kwak kwak , ik ben " + Age + " jaar");
        }
        public void Swim()
        {
            Console.WriteLine("de eend zwemt");
        }
    }
}
