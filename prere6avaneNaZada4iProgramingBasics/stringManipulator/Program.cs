using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());

            var toHex = a.ToString("X");

            var toBinary = Convert.ToString(a, 2);

            Console.WriteLine(toBinary.PadLeft(10, '0').Substring(0, 10));
            Console.WriteLine(toBinary);


            var str = "123456789";
            var result = str.Substring(5, -1);
            Console.WriteLine(result);
           
        }
    }
}
