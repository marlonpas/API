using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    public class Person
    {
        private DateTime birthDate;
        private string firstName,lastName;
        private static int instanceCount;

        public int Age { get { int age = Convert.ToInt32(DateTime.Today.Year - this.birthDate.Year); ; return age; } }
        public string FullName { get { return firstName + " " + lastName; } }
        public int InstanceCount { get { return instanceCount; } }


        public Person(DateTime birthDate, string firstName, string lastName)
        {
            this.birthDate = birthDate;
            this.firstName = firstName;
            this.lastName = lastName;
            instanceCount += 1;
        }

        public override string? ToString()
        {
            return $" {FullName} is {Age} jaar.\n Aantal instanties: {InstanceCount}";
        }
    }
}
