using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Animal
    {
        public int Age { get; set; }

        protected Animal(int age)
        {
            Age = age;
        }
    }
}
