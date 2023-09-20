using SecondProject;

namespace DateTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Marlon = new Person(Convert.ToDateTime("06/06/2002"), "Marlon", "pas");
            Console.WriteLine(Marlon.ToString());
            Console.ReadLine();
        }
    }
}