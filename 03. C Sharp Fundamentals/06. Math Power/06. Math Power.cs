namespace _06.Math_Power
{

    using System;


    public class Problem06
    {

        public static void Main()
        {

            var num = double.Parse(Console.ReadLine());
            var pow = int.Parse(Console.ReadLine());

            var result = CalculateNumPower(num, pow);

            Console.WriteLine(result);

        }

        public static double CalculateNumPower(double num, int pow)
        {
            var result = num;

            for (int i = 1; i < pow; i++)
            {
                result *= num;
            }

            return result;
        }
    }
}
