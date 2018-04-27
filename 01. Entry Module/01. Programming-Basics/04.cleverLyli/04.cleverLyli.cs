using System;


namespace _04.cleverLyli
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageLyli = int.Parse(Console.ReadLine());
            double priceWashM = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            var money = 0d;
            var totalMoney = 0.0;
            var toys = 0;
            var diff = 0.0;

            for (int i = 1; i <= ageLyli; i++)
            {
                if (i % 2 == 1)
                {
                    toys += 1;
                }
                else
                {
                    money += (i / 2) * 10 - 1;
                }
                
                
                // i % 2 == 1 ? toys++ : money += 9;
            }

            totalMoney = toys * toyPrice + money;
            diff = Math.Abs(totalMoney - priceWashM);
            if (totalMoney >= priceWashM)
            {
                Console.WriteLine("Yes! {0:f2}", diff);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", diff);
            }


           
        }
    }
}
