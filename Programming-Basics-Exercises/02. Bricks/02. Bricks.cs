using System;


namespace _02.Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var w = int.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());

            Console.WriteLine( Math.Ceiling(x / (w * m)));
        }
    }
}
