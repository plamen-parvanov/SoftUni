using System;


namespace Problem_01___Hungry_Garfield
{
    class Program
    {
        static void Main(string[] args)
        {
            var moneyHave = decimal.Parse(Console.ReadLine());
            var exchange = decimal.Parse(Console.ReadLine());
            var pizzaPrice = decimal.Parse(Console.ReadLine());
            var lasagnaPrice = decimal.Parse(Console.ReadLine());
            var sandwichPrice = decimal.Parse(Console.ReadLine());
            var pizzaQ = uint.Parse(Console.ReadLine());
            var lasagnaQ = uint.Parse(Console.ReadLine());
            var sandwichQ = uint.Parse(Console.ReadLine());
            var moneySpends = (decimal)0;

            moneySpends = pizzaPrice / exchange * pizzaQ
                + lasagnaPrice / exchange * lasagnaQ
                + sandwichPrice / exchange * sandwichQ;

            if (moneyHave >= moneySpends)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", moneyHave - moneySpends);
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", moneySpends - moneyHave);
            }


        }
    }
}
