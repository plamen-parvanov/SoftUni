using System;


namespace problem_01___vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegPrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            double vegKg = double.Parse(Console.ReadLine());
            double fruitKg = double.Parse(Console.ReadLine());

            double incomeEuro = (vegKg * vegPrice + fruitKg * fruitPrice) / 1.94;
            Console.WriteLine(incomeEuro);
        }
    }
}
