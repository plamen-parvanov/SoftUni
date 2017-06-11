using System;


namespace _02.Number_Checker
{
    class NumberChecker

    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());

            if (number - (long)number == 0)
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
