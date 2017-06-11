using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.totalTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstTime = int.Parse(Console.ReadLine());
            var secondTime = int.Parse(Console.ReadLine());
            var thirdTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime + secondTime + thirdTime;


            if (totalTime >= 120)
            {
                totalTime = totalTime - 120;
                if (totalTime < 10)
                    Console.WriteLine("2:0" + totalTime);
                else
                    Console.WriteLine("2:" + totalTime);


            }

            else if (totalTime >= 60)
            {
                totalTime = totalTime - 60;
                if (totalTime < 10)
                    Console.WriteLine("1:0" + totalTime);
                else
                    Console.WriteLine("1:" + totalTime);
            }

            else if (totalTime < 60)
            {
                if (totalTime < 10)
                    Console.WriteLine("0:0" + totalTime);
                else
                Console.WriteLine("0:" + totalTime);
            }
        }
    }
}
