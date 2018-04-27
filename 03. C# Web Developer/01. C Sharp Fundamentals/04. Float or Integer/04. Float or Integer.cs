namespace _04.Float_or_Integer
{

    using System;

    public class Problem04
    {

        public static void Main()
        {
            var num = double.Parse(Console.ReadLine());

            if (num % 1 == 0)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine(Math.Round(num));
            }
        }
    }
}
