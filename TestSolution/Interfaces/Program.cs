using ClassLibrary;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();
            animals.Add(new Fish(5));
            animals.Add(new Duck() { Age = 9});
            animals.Add(new Duck() { Age = 3});
            animals.Add(new Dog(5));

            animals.ForEach(animal => {
                var sound = animal as IMakeSound;
                if(sound != null)
                    sound.MakeSound();
                var swim = animal as IAmAWaterAnimal;
                if(swim != null)
                    swim.Swim();
            });
            Console.ReadLine();
        }
    }
}