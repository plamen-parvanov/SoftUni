using System;


namespace ConsoleApplication101.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double iuans = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double moneyInLeva = (iuans * 0.15 * 1.76) + bitcoins * 1168;
            double moneyInEuro = moneyInLeva / 1.95;
            double moneyHave = moneyInEuro * (1 - commision * 0.01);

            Console.WriteLine(moneyHave); 
        }
    }
}
