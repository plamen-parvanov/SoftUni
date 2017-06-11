using System;


namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var maxDiff = 0;
            var diff = 0;
            var oldSum = 0;
            var m = 0;

            if (n == 1)
            {
                var num1 = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());
                sum = num1 + num2;

                Console.WriteLine("Yes, value ={0}", sum);
            }



            else
            {
                for (int i = 0; i < n; i++)
                {
                    var num1 = int.Parse(Console.ReadLine());
                    var num2 = int.Parse(Console.ReadLine());

                    sum = num1 + num2;
                    if (i > 0)
                    {
                        diff = Math.Abs(sum - oldSum);
                        if (diff > maxDiff)
                        {
                            maxDiff = diff;
                        }

                        if (sum != oldSum)
                        {
                            m += 1;
                        }
                    }
                        oldSum = sum;
                   
                }
               
                        
            }

            if (m == 0)
            {
                Console.WriteLine("Yes , value={0}", sum);
            }
               else
            {
                Console.WriteLine("No maxdiff={0}", maxDiff);
            }
            
           
        }
    }
}
