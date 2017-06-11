using System;


namespace _03_operations_with_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double a = 0;
            string evenOdd = "odd";

            if (operation == "+")
            {
                a = N1 + N2;
                if (a % 2 == 0)
                {
                    evenOdd = "even";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", N1, operation, N2, a, evenOdd);
            }
            else if (operation == "-")
            {
                a = N1 - N2;
                if (a % 2 == 0)
                {
                    evenOdd = "even";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", N1, operation, N2, a, evenOdd);
            }
            else if (operation == "*")
            {
                a = N1 * N2;
                if (a % 2 == 0)
                {
                    evenOdd = "even";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", N1, operation, N2, a, evenOdd);
            }
            
            

            else if (operation == "/")
            {
                if (N2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
                else
                {
                    a = (double)N1 / N2;
                    Console.WriteLine("{0} / {1} = {2:f2}", N1, N2, a);
                }
            }
            else if (operation == "%")
            {
                if (N2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
                else
                {
                    a = N1 % N2;
                    Console.WriteLine("{0} % {1} = {2}", N1, N2, a);
                }
            }
        }
      }
    }
