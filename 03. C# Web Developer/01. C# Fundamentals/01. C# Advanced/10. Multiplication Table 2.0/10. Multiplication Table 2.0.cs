namespace _10.Multiplication_Table_2._0
{

    using System;


    public class Problem10
    {

        public static void Main()
        {

            var n = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());

            if (multiplier > 10)
            {
                Console.WriteLine($"{n} X {multiplier} = {n * multiplier}");
            }
            else
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
            }

        }
    }
}
