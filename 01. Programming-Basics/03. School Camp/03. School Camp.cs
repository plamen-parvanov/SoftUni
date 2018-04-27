using System;


namespace _03.School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            double price = 0;
            string sport = "";
            double bill = 0;

            switch (season)
            {
                case "Winter":
                    switch (group)
                    {
                        case "boys":
                            sport = "Judo";
                            price = 9.6;
                            break;
                        case "girls":
                            sport = "Gymnastics";
                            price = 9.6;
                            break;
                        case "mixed":
                            sport = "Ski";
                            price = 10;
                            break;
                    }
                    break;

                case "Spring":
                    switch (group)
                    {
                        case "boys":
                            sport = "Tennis";
                            price = 7.20;
                            break;
                        case "girls":
                            sport = "Athletics";
                            price = 7.20;
                            break;
                        case "mixed":
                            sport = "Cycling";
                            price = 9.50;
                            break;
                    }
                    break;
                      
                case "Summer":
                    switch (group)
                    {
                        case "boys":
                            sport = "Football";
                            price = 15;
                            break;
                        case "girls":
                            sport = "Volleyball";
                            price = 15;
                            break;
                        case "mixed":
                            sport = "Swimming";
                            price = 20;
                            break;
                    }
                    break;
            }

            bill = price * nights * students;

            if (students >= 50)
            {
                bill *= 0.5;
            }
            else if (students >= 20)
            {
                bill *= 0.85;
            }
            else if (students >= 10)
            {
                bill *= 0.95;
            }

            Console.WriteLine("{0} {1:f2} lv.", sport, bill);
        }
    }
}
