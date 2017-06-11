using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desetici_i_edinici
{
    class zakruglqne
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Desetichni " + a / 10);
            Console.WriteLine("Edenici " + a % 10);
            Console.WriteLine("drugo "+ a % 100);
        }
    }
}
//var number = int.Parse(Console.ReadLine());
//            switch (number)
//            {
//                case 1:
//                    Console.WriteLine("one");
//                    break;