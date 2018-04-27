using System;


namespace _04___Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var points = 0.0;
            var firstGr = 0.0;
            var secondGr = 0.0;
            var thirdGr = 0.0;
            var forthGr = 0.0;
            var fifthGr = 0.0;
            var sixthGr = 0.0;

            for (int i = 0; i < n; i++)
            {
                var num = double.Parse(Console.ReadLine());

                if (num < 0 || num > 50)
                {
                    points /= 2;
                    sixthGr += 1;
                }

                else if (num > 39)
                {
                    points += 100;
                    fifthGr += 1;
                }

                else if (num > 29)
                {
                    points += 50;
                    forthGr += 1;
                }

                else if (num > 19)
                {
                    points += num * 0.4;
                    thirdGr += 1;
                }

                else if (num > 9)
                {
                    points += num * 0.3;
                    secondGr += 1;
                }

                else
                {
                    points += num * 0.2;
                    firstGr += 1;
                }

            }

            firstGr *= 100d / n;
            secondGr*= 100d / n;
            thirdGr *= 100d / n;
            forthGr *= 100d / n;
            fifthGr *= 100d / n;
            sixthGr *= 100d / n;
            Console.WriteLine("{0:f2}", points);
            Console.WriteLine("From 0 to 9: {0:f2}%", firstGr);
            Console.WriteLine("From 10 to 19: {0:f2}%", secondGr);
            Console.WriteLine("From 20 to 29: {0:f2}%", thirdGr);
            Console.WriteLine("From 30 to 39: {0:f2}%", forthGr);
            Console.WriteLine("From 40 to 50: {0:f2}%", fifthGr);
            Console.WriteLine("Invalid numbers: {0:f2}%", sixthGr);
        }
    }
}
