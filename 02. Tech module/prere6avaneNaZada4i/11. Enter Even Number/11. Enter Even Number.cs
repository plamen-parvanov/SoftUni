using System;


namespace _11.Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            do
            {
                try
                {
                    Console.Write("Enter even number: ");
                    n = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid number!");
                }

            } while (n % 2 != 0);
            Console.WriteLine("Even number entered: {0}", n);
        }
    }
}
