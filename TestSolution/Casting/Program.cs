namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new object[4];
            shapes[0] = new Dot(5, 7);
            shapes[1] = new Square(5);
            shapes[2] = new Circle(2);
            shapes[3] = new Square(8);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(shapes[i].ToString());   
            }
            Console.ReadLine();
        }
    }
}