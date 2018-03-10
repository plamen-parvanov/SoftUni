namespace _01.Wormtest
{
    using System;

    public class Problem01
    {
        public static void Main()
        {
            var length = int.Parse(Console.ReadLine()) * 100;
            var width = double.Parse(Console.ReadLine());

            if (length == 0 || width == 0 || length % width == 0)
            {
                Console.WriteLine("{0:F2}", Math.Round(length * width, 2));
            }
            else
            {
                Console.WriteLine("{0:F2}%", Math.Round(length / width * 100, 2));
            }
        }
    }
}
