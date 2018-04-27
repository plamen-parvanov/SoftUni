using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            string[] parameters = line.Split();
            long amount = long.Parse(parameters[0]);
            string type = parameters[1];
            Console.WriteLine(amount);
            Console.WriteLine(type);

            var number = int.MaxValue;
            Console.WriteLine(number);
            

            var pro4etiDuma = Console.ReadLine();
            var otgovor = pro4etiDuma == "VIP" ? "Very Important Person" : "ne e VIP";
            Console.WriteLine(otgovor);

            var n = 0.0;
            n = n / 2d;
            Console.WriteLine(n);
        }

        //var ticketPrice = category == "VIP" ? 499.99 : 249.99;    tova e za 4isla

        
    }
}
