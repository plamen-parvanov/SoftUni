using System;


namespace _01.Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = int.Parse(Console.ReadLine());
            var y1 = int.Parse(Console.ReadLine());
            var x2 = int.Parse(Console.ReadLine());
            var y2 = int.Parse(Console.ReadLine());
            var x3 = int.Parse(Console.ReadLine());
            var y3 = int.Parse(Console.ReadLine());

            var a = Math.Abs(x2 - x3);
            var ha = Math.Abs(y3 - y1);
            
            Console.WriteLine(a * ha / 2.0);
        }
    }
}
