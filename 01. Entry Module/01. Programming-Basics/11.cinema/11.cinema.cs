using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOfProjection = Console.ReadLine();
            var row = int.Parse(Console.ReadLine());
            var col = int.Parse(Console.ReadLine());
            var price = 0.0;

            switch (typeOfProjection)
            {
                case "Premiere":
                    price = 12;
                    break;

                case "Normal":
                    price = 7.5;
                    break;

                case "Discount":
                    price = 5;
                    break;   
            }
            Console.WriteLine("{0:F2} leva", row * col * price);
        }
    }
}
