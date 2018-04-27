using System;


namespace _11.Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (;;)
            {
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: {0}", num);
                        return;
                    }
                }
                catch (FormatException)
                {

                    Console.WriteLine("Invalid Number");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid Number");
                }
                Console.WriteLine("Enter even number:");
            }
        }
    }
}
