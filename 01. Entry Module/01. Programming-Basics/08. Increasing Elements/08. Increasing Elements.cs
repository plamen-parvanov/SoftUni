using System;


namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());


            var oldNumber = 0;
            var oldIncreasingRow = 0;
            var newIncreasingRow = 0;

            for (int i = 0; n > i; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num > oldNumber)
                {
                    newIncreasingRow++;

                    if (newIncreasingRow > oldIncreasingRow)
                    {
                        oldIncreasingRow = newIncreasingRow;
                    }
                }

                else
                {
                    
                    newIncreasingRow = 1;

                }
                oldNumber = num;

            }

            Console.WriteLine(oldIncreasingRow);

        }
    }
}
