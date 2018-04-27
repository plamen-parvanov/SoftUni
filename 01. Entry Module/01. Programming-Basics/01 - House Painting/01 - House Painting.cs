using System;


namespace _01___House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var sWalls = 2 * x * y - 2 * 1.5 * 1.5 + 2 * x * x - 2 * 1.2;
            var green = sWalls / 3.4;
            var roof = 2 * x * y + x * h;
            var red = roof / 4.3;

            Console.WriteLine("{0:f2}\n{1:f2}", green, red);
           

        }
    }
}
