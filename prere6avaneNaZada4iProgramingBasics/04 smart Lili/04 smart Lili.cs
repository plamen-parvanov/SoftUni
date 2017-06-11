using System;


namespace _04_smart_Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageLili = int.Parse(Console.ReadLine());
            double priceWM = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());
            int toys = 0;
            int money = 0;
            double spent = 0;

            for (int i = 1; i <= ageLili; i++)
            {
                if (i % 2 == 0)
                {
                    money += 10;
                    spent += money - 1;
                }
                else
                {
                    toys++;
                }
            }

            spent += (toys * priceToy);

            if (spent >= priceWM)
            {
                Console.WriteLine("Yes! {0:f2}", spent - priceWM);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", priceWM - spent);
            }
        }
    }
}
