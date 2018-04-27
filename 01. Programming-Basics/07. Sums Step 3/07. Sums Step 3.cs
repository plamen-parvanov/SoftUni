using System;


namespace _07.Sums_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var numEntries = 0;
            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;
            var a = 1;


            while (n > numEntries)
            {
                var nextValue = int.Parse(Console.ReadLine());
                numEntries += 1;

                if (a > 2)
                {
                    sum3 += nextValue;
                    a -= 3;
                }

                else if (a > 1)
                {
                    sum2 += nextValue;
                }

                else
                {
                    sum1 += nextValue;
                }
                a += 1;
            }

            Console.WriteLine("sum1 ={0} \nsum2 ={1} \nsum3 ={2}", sum1, sum2, sum3);

        
        }
    }
}
