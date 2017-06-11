using System;


namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] arrayN = new long[n];

            arrayN[0] = 1;

            for (int i = 1; i < n; i++)
            {
                
                arrayN[i] = GetsSumOfPeviousEl(arrayN, i, k);
                
            }

            Console.WriteLine(string.Join(" ", arrayN));

        }

        static long GetsSumOfPeviousEl(long[] array, int i, int k)
        {
            long sum = 0;
            
            for (int j = i - 1; j >= 0 && k > 0; j--, k--)
            {
                sum += array[j];              
            }       
            return sum;
        }
    }
}
