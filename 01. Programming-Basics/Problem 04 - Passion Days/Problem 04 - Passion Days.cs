using System;


namespace Problem_04___Passion_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyHave = decimal.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            decimal sum = 0m;
            int purchase = 0;

            while (text != "mall.Enter")
            {
                text = Console.ReadLine();
            }

            text = Console.ReadLine();
            while (text != "mall.Exit")
            {
                for (int i = 0; i < text.Length; i++)
                {
                    char a = text[i];
                    if (a >= 'A' && a <= 'Z')
                    {
                        sum = 0.5m * a;
                    }
                    else if (a >= 'a' && a <= 'z')
                    {
                        sum = 0.3m * a;
                    }
                    else if (a == '%')
                    {
                        sum = 0.5m * moneyHave;
                    }
                    else if (a == '*')
                    {
                        moneyHave += 10;
                        sum = 0;
                        purchase--;
                    }
                    else
                    {
                        sum = (int)a;
                    }

                    if (moneyHave >= sum)
                    {
                        moneyHave -= sum;
                        purchase++;
                    }
                }
                text = Console.ReadLine();
            }
            if (purchase == 0)
            {
                Console.WriteLine("No purchases. Money left: {0:f2} lv.", moneyHave);
            }
            else
            {
                Console.WriteLine("{0} purchases. Money left: {1:f2} lv.", purchase, moneyHave);
            }

        }
    }
}
