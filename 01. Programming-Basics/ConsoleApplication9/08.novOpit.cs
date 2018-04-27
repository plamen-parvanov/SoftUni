using System;


namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            
            var oldNumber = 0;
            var newIncreasingRow = 0;
            var oldIncreasingRow = int.MinValue;

            for (int numEntries = 0; n > numEntries; numEntries++)
            {
                var newNumber = int.Parse(Console.ReadLine());

                if (newNumber > oldNumber)
                {
                    newIncreasingRow += 1;
                    newNumber = oldNumber;
                }
                else
                {
                    newIncreasingRow = oldIncreasingRow;
                    newNumber = oldNumber;
                }

                 if (newIncreasingRow > oldIncreasingRow)
                {
                    newIncreasingRow = oldIncreasingRow;
                }
            }

           


            Console.WriteLine(oldIncreasingRow);

        }
    }
}
