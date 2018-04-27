using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int add = 0;
            int multiply = 0;
            Add_Multiply(a, b, ref add, ref multiply);
            Console.WriteLine(add);
            Console.WriteLine(multiply);
        }

        private static void Add_Multiply(int a, int b, ref int add, ref int multiply)
        {
            add = a + b;
            multiply = a * b;
        }
    }
}
