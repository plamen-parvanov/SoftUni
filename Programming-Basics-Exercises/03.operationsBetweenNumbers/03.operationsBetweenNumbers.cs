using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.operationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var N1 = double.Parse(Console.ReadLine());
            var N2 = double.Parse(Console.ReadLine());
            var operation = Console.ReadLine();

            if (operation == "+")
            {
                Console.Write("{0} {1} {2} = {3} ", N1, operation, N2, N1 + N2);

                if ((N1 + N2) % 2 == 0)
                    Console.WriteLine("- even");
                else
                    Console.WriteLine("- odd");
            }

            else if (operation == "-")
            {
                Console.Write("{0} {1} {2} = {3} ", N1, operation, N2, N1 - N2);

                if ((N1 - N2) % 2 == 0)
                    Console.WriteLine("- even");
                else
                    Console.WriteLine("- odd");
            }

            else if (operation == "*")
            {
                Console.Write("{0} {1} {2} = {3} ", N1, operation, N2, N1 * N2);

                if ((N1 * N2) % 2 == 0)
                    Console.WriteLine("- even");
                else
                    Console.WriteLine("- odd");
            }

            else if (operation == "/")

                if (N2 == 0)
                    Console.WriteLine("Cannot divide {0} by zero", N1);

                else
                {
                    
                    Console.WriteLine("{0} {1} {2} = {3:F2} ", N1, operation, N2, N1 / N2);
                }

            else if (operation == "%")
                if (N2 == 0)
                    Console.WriteLine("Cannot divide {0} by zero", N1);

                else

                    Console.WriteLine("{0} {1} {2} = {3} ", N1, operation, N2, N1 % N2);




        }
    }
}
