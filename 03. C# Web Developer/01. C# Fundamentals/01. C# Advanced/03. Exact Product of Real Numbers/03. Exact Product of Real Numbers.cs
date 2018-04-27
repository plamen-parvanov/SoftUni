namespace _03.Exact_Product_of_Real_Numbers
{

    using System;


    public class Problem03
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var product = 1m;

            for (int i = 0; i < n; i++)
            {
                product *= decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(product);
        }
    }
}
