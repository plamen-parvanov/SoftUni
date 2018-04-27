using System;


namespace _03.Smallest_Element_in_Array
{
    class Program
    {
        static void Main()
        {
            string stringIntegers = Console.ReadLine();
            string[] stringIntArr = stringIntegers.Split(' ');

            int[] intArr = new int[stringIntArr.Length];
            int minValue = int.MaxValue;

            minValue = FindsMinValue(stringIntArr, intArr, minValue);

            Console.WriteLine(minValue);
        }

        private static int FindsMinValue(string[] stringIntArr, int[] intArr, int minValue)
        {
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = int.Parse(stringIntArr[i]);
                if (intArr[i] < minValue)
                {
                    minValue = intArr[i];
                }
            }

            return minValue;
        }
    }
}
