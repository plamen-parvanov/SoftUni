using System;


namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
