using System;

namespace _08.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            var comission = 0.0;
            bool positiveQuantity = quantity >= 0;

            if (positiveQuantity)
            {
                switch (city)
                {
                    case "sofia":
                        if (quantity > 10000.0)
                        {
                            comission = 0.12;
                        }

                        else if (quantity > 1000.0)
                        {
                            comission = 0.08;
                        }

                        else if (quantity > 500.0)
                        {
                            comission = 0.07;
                        }

                        else if (quantity > 0)
                        {
                            comission = 0.05;
                        }


                        Console.WriteLine("{0:F2}", comission * quantity);
                        break;

                    case "varna":
                        if (quantity > 10000.0)
                        {
                            comission = 0.13;
                        }

                        else if (quantity > 1000.0)
                        {
                            comission = 0.1;
                        }

                        else if (quantity > 500.0)
                        {
                            comission = 0.075;
                        }

                        else if (quantity > 0)
                        {
                            comission = 0.045;
                        }

                        Console.WriteLine("{0:F2}", comission * quantity);
                        break;

                    case "plovdiv":
                        if (quantity > 10000.0)
                        {
                            comission = 0.145;
                        }

                        else if (quantity > 1000.0)
                        {
                            comission = 0.12;
                        }

                        else if (quantity > 500.0)
                        {
                            comission = 0.08;
                        }

                        else if (quantity > 0)
                        {
                            comission = 0.055;
                        }

                        Console.WriteLine("{0:F2}", comission * quantity);
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            else
                Console.WriteLine("error");

        }
    }
}
