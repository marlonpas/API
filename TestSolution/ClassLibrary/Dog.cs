using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Dog:Animal, IMakeSound
    {
        public Dog(int age) : base(age)
        {
        }

        public void MakeSound()
        {
            Console.WriteLine("waf waf, ik ben "+ Age +" jaar");
        }
    }
}
