using System;


namespace _01.House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallRoom = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());
            var bathroom = 0.5 * smallRoom;
            var secondRoom = smallRoom + 0.1 * smallRoom;
            var thirdRoom = secondRoom + 0.1 * secondRoom;
            var S = kitchen + bathroom + smallRoom + secondRoom + thirdRoom;
            var totalS = S + 0.05 * S;

            Console.WriteLine("{0:F2}", totalS * price);
        }
    }
}
