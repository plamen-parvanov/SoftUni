using System;


namespace Problem_01___Cake_Tycoon
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var f = uint.Parse(Console.ReadLine());
            var t = uint.Parse(Console.ReadLine());
            var p = uint.Parse(Console.ReadLine());


            if (n <= Math.Floor(f / c))
            {
                Console.WriteLine("All products available, price of a cake: {0:f2}", (long)t * p * 1.25 / n);
            }
            else
            {
                Console.WriteLine("Can make only {0} cakes, need {1:f2} kg more flour",
                    Math.Floor(f / c), n * c - f);
            }



        }
    }
}
