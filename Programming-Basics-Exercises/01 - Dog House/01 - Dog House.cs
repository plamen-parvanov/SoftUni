using System;


namespace _01___Dog_House
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            var stranici = 2 * a * a * 0.5;
            var back = 0.5 * a * 0.5 * a + (b - 0.5 * a) * 0.5 * a * 0.5;
            var front = back - 0.2 * a * 0.2 * a;
            var green = (stranici + back + front) / 3d;

            var red = 2 * a * 0.5 * a / 5d;

            Console.WriteLine("{0:f2}\n{1:f2}", green, red);
        }
    }
}
