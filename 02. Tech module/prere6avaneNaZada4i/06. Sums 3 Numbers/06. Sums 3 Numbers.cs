using System;


namespace _06.Sums_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int firstNum = 0;
            int secondNum = 0;
            int thirdNum = 0;
            int counter = 0;

            if (a + b == c)
            {
                firstNum = Math.Min(a, b);
                secondNum = Math.Max(a, b);
                thirdNum = c;
                counter += 1;
               
                
            }
            if (a + c == b)
            {
                firstNum = Math.Min(a, c);
                secondNum = Math.Max(a, c);
                thirdNum = b;
                counter += 1;
               
            }
            if (b + c == a)
            {
                firstNum = Math.Min(c, b);
                secondNum = Math.Max(c, b);
                thirdNum = a;
                counter += 1;
               
            }
            if (counter != 0)
            {
                Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, thirdNum);  
            }
            else
            {
                Console.WriteLine("No");
            }

            
        }
    }
}
