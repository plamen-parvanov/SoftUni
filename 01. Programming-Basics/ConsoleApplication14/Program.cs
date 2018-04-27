using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());

            for (int i = 0, j = h; i <= h || j > 2; i++, j--)
            {
                Console.Write(i);
                Console.WriteLine(j);
            }

        }
    }
}
