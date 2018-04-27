using System;


namespace _08.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double comission = 0;

            switch (town)
            {
                case "Sofia":
                    if (sales > 10000)
                    {
                        comission = 0.12;
                    }
                    else if (sales > 1000)
                    {
                        comission = 0.08;
                    }
                    else if (sales > 500)
                    {
                        comission = 0.07;
                    }
                    else if (sales >= 0)
                    {
                        comission = 0.05;
                    }
                    break;
                case "Varna":
                    if (sales > 10000)
                    {
                        comission = 0.13;
                    }
                    else if (sales > 1000)
                    {
                        comission = 0.1;
                    }
                    else if (sales > 500)
                    {
                        comission = 0.075;
                    }
                    else if (sales >= 0)
                    {
                        comission = 0.045;
                    }                    
                    break;
                case "Plovdiv":
                    if (sales > 10000)
                    {
                        comission = 0.145;
                    }
                    else if (sales > 1000)
                    {
                        comission = 0.12;
                    }
                    else if (sales > 500)
                    {
                        comission = 0.08;
                    }
                    else if (sales >= 0)
                    {
                        comission = 0.055;
                    }                
                    break;
            }
            if (comission != 0)
            {
                Console.WriteLine("{0:f2}", comission * sales);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
