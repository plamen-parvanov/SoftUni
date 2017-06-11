using System;


namespace _10.Multiplication_Table_2._0
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int sum = 1;

            if (multiplier > 10)
            {
                sum = number * multiplier;
                Console.WriteLine($"{number} X {multiplier} = {sum}");
            }
            else
            {
                for (int i = multiplier; i < 11; i++)
                {
                    sum = number * i;
                    Console.WriteLine($"{number} X {i} = {sum}");
                }
            }
        }
    }
}
