namespace _04.Add_VAT
{
    using System;
    using System.Linq;

    public class Problem04
    {
        public static void Main()
        {
            Func<double, double> addVat = p => p * 1.2;
            Action<double> printPrice = p => Console.WriteLine($"{p:F2}");

            Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(addVat)
                .ToList()
                .ForEach(printPrice);
        }
    }
}
