using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            int[] arrayK = new int[k];

            for (int i = 0; i < k; i++)
            {
                arrayK[i] = GetsSumOfPeviousEl(arrayK);
                Console.WriteLine(arrayK[i]);
            }
        }

        static int GetsSumOfPeviousEl(int[] array)
        {
            int sum = 0;
            array[0] = 1;
            foreach (var element in array)
            {
                sum += element;
            }
            return sum;
        }
    }
}
