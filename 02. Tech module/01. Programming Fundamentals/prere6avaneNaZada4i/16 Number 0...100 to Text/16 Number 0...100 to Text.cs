using System;


namespace _16_Number_0._._._100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = n / 10;
            int b = n % 10;
            string first = "";
            string second = "";


            if (n == 0)
            {
                Console.WriteLine("zero");
            }
            else if (n == 10)
            {
                Console.WriteLine("ten");
            }
            else if (n == 11)
            {
                Console.WriteLine("eleven");
            }
            else if (n == 12)
            {
                Console.WriteLine("twelve");
            }
            else if (n == 13)
            {
                Console.WriteLine("thirteen");
            }
            else if (n == 15)
            {
                Console.WriteLine("fifteen");
            }
            else if (n == 100)
            {
                Console.WriteLine("one hundred");
            }
            else if (n < 0 || n > 100)
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                if (a == 2)
                {
                    first = "twenty";
                }
                else if (a == 3)
                {
                    first = "thirty";
                }
                else if (a == 4)
                {
                    first = "forty";
                }
                else if (a == 5)
                {
                    first = "fifty";
                }
                else if (a == 6)
                {
                    first = "sixty";
                }
                else if (a == 7)
                {
                    first = "seventy";
                }
                else if (a == 8)
                {
                    first = "eighty";
                }
                else if (a == 9)
                {
                    first = "ninety";
                }
                if (b == 1)
                {
                    second = "one";
                }
                else if (b == 2)
                {
                    second = "two";
                }
                else if (b == 3)
                {
                    second = "three";
                }
                else if (b == 4)
                {
                    second = "four";
                }
                else if (b == 5)
                {
                    second = "five";
                }
                else if (b == 6)
                {
                    second = "six";
                }
                else if (b == 7)
                {
                    second = "seven";
                }
                else if (b == 8)
                {
                    second = "eight";
                }
                else if (b == 9)
                {
                    second = "nine";
                }
                if (a == 1)
                {
                    Console.WriteLine("{0}teen", second);
                }
                else if (a > 1 )
                {
                    if (b != 0)
                    {
                        Console.WriteLine("{0} {1}", first, second);
                    }
                    else
                    {
                        Console.WriteLine("{0}", first);
                    }
                }
                else
                {
                    Console.WriteLine("{0}", second);
                }
            }
        }
    }
}
