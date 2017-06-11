using System;


namespace _06.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double powerOfNumber = double.Parse(Console.ReadLine());

            double result = NumberRaisedToPower(number, powerOfNumber);
            Console.WriteLine(result);
        }
        static double NumberRaisedToPower(double num, double power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
